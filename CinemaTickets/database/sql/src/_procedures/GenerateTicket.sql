-- Процедура отображения предварительного билета
-- EXAMPLE
-- EXEC GenerateTicket @id_session = 2, @number_place = 56

GO
DROP PROC if exists GenerateTicket
GO
CREATE PROC GenerateTicket
	@id_session INT,
	@number_place INT
AS
	SELECT
		Films.film_name,
		Sessions_list.date_time_session,
		Sessions_list.id_hall,
		Films.film_price_ticket * Place_type.place_multiplier,
		Films.film_length_min,
		Films.film_age_limit,
		Films.film_photo
	FROM Sessions_list
	JOIN Films ON Sessions_list.id_film = Films.id
	JOIN Hall_type ON Sessions_list.id_hall = Hall_type.id_hall
	JOIN Place_type ON Hall_type.id_type = Place_type.id_place
	WHERE
		Sessions_list.id = @id_session
		AND @number_place BETWEEN Hall_type.place_from and Hall_type.place_to
GO
