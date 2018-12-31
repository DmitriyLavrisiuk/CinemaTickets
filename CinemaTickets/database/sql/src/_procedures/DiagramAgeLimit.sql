-- Процедура для отображения диаграммы кол фильмы по возр. ограничению
-- EXAMPLE
-- EXEC DiagramAgeLimit

GO
DROP PROC if exists DiagramAgeLimit
GO
CREATE PROC DiagramAgeLimit
AS
	SELECT count(Films.id) AS 'CountFilms', Films.film_age_limit AS 'AgeLimit'
	FROM dbo.Films
	GROUP BY Films.film_age_limit
GO
