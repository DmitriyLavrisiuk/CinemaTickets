-- Процедура для отображения диаграммы кол. фильмов по годам
-- EXAMPLE
-- EXEC DiagramFilmYear

GO
DROP PROC if exists DiagramFilmYear
GO
CREATE PROC DiagramFilmYear
AS
	SELECT Films.film_year AS 'Year', count(Films.id) AS 'CountFilms'
	FROM dbo.Films
	GROUP BY Films.film_year
GO
