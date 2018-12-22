-- Процедура добавления билета
-- EXAMPLE
-- EXEC BuyTicket @id_hall = 5, @date_time_session = "2018-12-31 14:25:00", @number_place = 20


GO
DROP PROC if exists BuyTicket
GO
CREATE PROC BuyTicket
	@id_hall int,
	@date_time_session smalldatetime,
	@number_place int
AS
	DECLARE @id_session INT = (
		SELECT Sessions_list.id
		FROM Sessions_list
		WHERE 
			id_hall = @id_hall
			AND date_time_session = @date_time_session
	)
	INSERT INTO Tickets (id_session, number_place)
	VALUES (@id_session, @number_place)
GO
