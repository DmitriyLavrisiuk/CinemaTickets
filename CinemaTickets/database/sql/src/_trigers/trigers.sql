/************************/
/*       ��������       */
/************************/

DROP TRIGGER if exists Tickets_INSERT
GO
CREATE TRIGGER Tickets_INSERT ON Tickets
AFTER INSERT, UPDATE AS

DECLARE @id					decimal(3, 0),	/* ID */
		@id_session			decimal(3, 0),	/* ID ������ */
		@number_place		decimal(3, 0),	/* ����� ����� */
		@price_ticket_film	decimal(3, 0),	/* ������� ���� ������ �� ����� */
		@hall_places_count	decimal(3, 0),	/* ���������� ���� � ���� */
		@multiplier			float,			/* ��������� ��� ������� ��������� ������ ������ �� ����� */
		@date_session		datetime		/* ���� ������ */

SET @id						= (SELECT id FROM INSERTED)
SET @id_session				= (SELECT id_session FROM INSERTED)
SET @number_place			= (SELECT number_place FROM INSERTED)
SET @price_ticket_film		= (SELECT film_price_ticket FROM Films WHERE id = (SELECT id_film FROM Sessions_list WHERE id = @id_session))
SET @hall_places_count		= (SELECT hall_places_count FROM Halls WHERE id = (SELECT id_hall FROM Sessions_list WHERE id = @id_session))
SET @multiplier				= (SELECT place_multiplier FROM Place_type WHERE id_place = (SELECT id_type FROM Hall_type WHERE id_hall = (SELECT id FROM Halls WHERE id = (SELECT id_hall FROM Sessions_list WHERE id = @id_session)) AND place_from <= @number_place AND place_to >= @number_place))
SET @date_session			= (SELECT date_time_session FROM Sessions_list WHERE id = @id_session)

IF (@number_place > @hall_places_count OR @number_place <= 0)
	BEGIN
	ROLLBACK TRAN
	PRINT '����� � ����� id �� �������!'
END

IF ((SELECT count(id) FROM Tickets WHERE id_session = @id_session AND number_place = @number_place AND date_time_session = @date_session) != 0)
	BEGIN
	ROLLBACK TRAN
	PRINT '����� ��� ������!'
END

UPDATE Tickets 
SET date_time_session = @date_session, price = (@price_ticket_film * @multiplier), unique_id_tickets = CONVERT(varchar, RAND()*10000+@id) + CONVERT(varchar, RAND()*10000+@id) + CONVERT(varchar, RAND()*10000+@id) + CONVERT(varchar, RAND()*@id)
WHERE id = @id


