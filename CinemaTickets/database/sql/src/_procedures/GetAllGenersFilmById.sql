-- Процедура отображения всех жанров фильма по ID
-- EXAMPLE
-- EXEC GetAllGenersFilmById @id = 11

GO
DROP PROC if exists GetAllGenersFilmById
GO
CREATE PROC GetAllGenersFilmById
	@id int
AS
	SELECT
		Gener.gener_name
	FROM Films
	JOIN Films_gener ON Films.id = Films_gener.id_film
	JOIN Gener ON Films_gener.id_gener = Gener.id_gener
	WHERE
		Films.id = @id
	GROUP BY 
		Gener.gener_name
GO
