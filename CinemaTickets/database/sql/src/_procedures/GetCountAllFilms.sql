-- Процедура для поиска фильмов по 3 параметрам
-- EXAMPLE
-- EXEC GetCountAllFilms


GO
DROP PROC if exists GetCountAllFilms
GO
CREATE PROC GetCountAllFilms
AS
	SELECT count(DISTINCT (Films.id))
	FROM Films
	JOIN Sessions_list ON Films.id = Sessions_list.id_film
GO