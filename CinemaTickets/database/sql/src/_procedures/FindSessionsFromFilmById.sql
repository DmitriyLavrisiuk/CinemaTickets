-- Процедура для поиска актуальных сеансов для фильма по ID
-- EXAMPLE
-- EXEC FindSessionFromsFilmById @film_id = 2

GO
DROP PROC if exists FindSessionFromsFilmById
GO
CREATE PROC FindSessionFromsFilmById
	@film_id INT
AS
	SELECT
		id_hall,
		date_time_session,
		id
	FROM Sessions_list
	WHERE
		Sessions_list.id_film = @film_id
		AND (DATEDIFF(HOUR, SYSDATETIME(), Sessions_list.date_time_session)) >= 1
GO
