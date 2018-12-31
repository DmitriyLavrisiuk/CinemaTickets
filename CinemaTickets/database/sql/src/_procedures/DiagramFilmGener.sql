-- Процедура для отображения диаграммы кол. фильмов по жанрам
-- EXAMPLE
-- EXEC DiagramFilmGener

GO
DROP PROC if exists DiagramFilmGener
GO
CREATE PROC DiagramFilmGener
AS
	SELECT count(Films.id) AS 'CountFilms', Gener.gener_name AS 'Gener'
	FROM dbo.Films
	JOIN Films_gener ON Films.id = Films_gener.id_film
	JOIN Gener ON Films_gener.id_film = Gener.id_gener
	GROUP BY Gener.gener_name
GO
