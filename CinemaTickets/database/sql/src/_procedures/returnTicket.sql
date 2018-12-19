-- Процедура возврата билета обратно в кассу
-- EXAMPLE
-- EXEC ReturnTicket @unique_id_tickets = '9762.269218.13254.521.59163'
-- INSERT INTO Tickets (id_session, number_place) VALUES (3, 39);


GO
DROP PROC if exists ReturnTicket
GO
CREATE PROC ReturnTicket
	@unique_id_tickets varchar(35)
AS
	-- Получение времени сеанса с Tickets
	DECLARE @datetimeOnTicket smalldatetime = (SELECT date_time_session FROM Tickets WHERE unique_id_tickets = @unique_id_tickets) 
	-- Получение времени сеанса с Sessions_list
	DECLARE @datetimeOnSession smalldatetime = (
	SELECT
		Sessions_list.date_time_session
	FROM Tickets
	JOIN Sessions_list ON Tickets.date_time_session = Sessions_list.date_time_session
	JOIN Films ON Sessions_list.id_film = Films.id
	WHERE 
		unique_id_tickets = @unique_id_tickets
	GROUP BY
		Sessions_list.date_time_session
	)

	IF(@datetimeOnTicket IS NOT NULL AND @datetimeOnSession IS NOT NULL)
	BEGIN
		-- Билет и сеанс существует
		-- Сравниваем время сеанса и время на билете
		IF((DATEDIFF(HOUR, SYSDATETIME(), @datetimeOnSession)) >= 1)
		BEGIN
			DELETE FROM Tickets WHERE unique_id_tickets = @unique_id_tickets
			SELECT('Возврат оформлен! Актуальность билета ' + CONVERT(varchar, (DATEDIFF(HOUR, SYSDATETIME(), @datetimeOnSession))) + 'ч.')
		END
		ELSE
		BEGIN
			SELECT('Возврат отклонен! Данный билет просрочен.')
		END
	END
	ELSE
	BEGIN
		SELECT('Билет не найден.')
	END
GO
