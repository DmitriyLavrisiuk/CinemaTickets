-- Процедура возврата билета обратно в кассу
-- EXAMPLE
-- EXEC getAllInformationAboutTicketByUID @unique_id_tickets = "4061.951035.518764.383.72146"


GO
DROP PROC if exists getAllInformationAboutTicketByUID
GO
CREATE PROC getAllInformationAboutTicketByUID
	@unique_id_tickets varchar(35)
AS
	SELECT
		Films.film_name,
		Sessions_list.date_time_session,
		Sessions_list.id_hall,
		Tickets.number_place,
		Tickets.price,
		Tickets.unique_id_tickets,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
	FROM Tickets
	JOIN Sessions_list ON Tickets.date_time_session = Sessions_list.date_time_session
	JOIN Films ON Sessions_list.id_film = Films.id
	WHERE 
		unique_id_tickets = @unique_id_tickets
	GROUP BY
		Films.film_name,
		Sessions_list.date_time_session,
		Sessions_list.id_hall,
		Tickets.number_place,
		Tickets.price,
		Tickets.unique_id_tickets,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
GO
