-- Процедура отображения всех жанров фильма по ID
-- EXAMPLE
-- EXEC GetAllProductionCountriesFilmById @id = 3

GO
DROP PROC if exists GetAllProductionCountriesFilmById
GO
CREATE PROC GetAllProductionCountriesFilmById
	@id int
AS
	SELECT
		Production.country_name
	FROM Films
	JOIN Films_production ON Films.id = Films_production.id_film
	JOIN Production ON Films_production.id_country = Production.id_country
	WHERE
		Films.id = @id
	GROUP BY 
		Production.country_name
GO
