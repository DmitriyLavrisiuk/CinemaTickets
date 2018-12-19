-- Процедура для поиска фильмов по 3 параметрам
-- EXAMPLE
-- EXEC GetCountAllFilms @year_from = 2017


GO
DROP PROC if exists GetCountAllFilms
GO
CREATE PROC GetCountAllFilms
AS
	SELECT
		Count(DISTINCT (Films.id))
	FROM Films
GO