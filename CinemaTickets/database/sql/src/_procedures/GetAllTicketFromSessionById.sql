-- Процедура получение всех выкупленных мест в зале по id сессии
-- EXAMPLE
-- EXEC GetAllTicketFromSessionById @id_session = 1

GO
DROP PROC if exists GetAllTicketFromSessionById
GO
CREATE PROC GetAllTicketFromSessionById
	@id_session int
AS
	SELECT
		Tickets.number_place
	FROM Tickets
	JOIN Sessions_list ON Tickets.id_session = Sessions_list.id
	WHERE
		Tickets.id_session = @id_session
GO
