-- Процедура для поиска фильмов по 3 параметрам
-- EXAMPLE
-- EXEC CountResultFindFilmsByFilters_3 @gener_to_search = "Ужасы,Фантастические"


GO
DROP PROC if exists CountResultFindFilmsByFilters_3
GO
CREATE PROC CountResultFindFilmsByFilters_3
	@year_from int = NULL,
	@year_to int = NULL,
	@gener_to_search varchar(256) = NULL
AS
	IF (@gener_to_search IS NOT NULL)
	BEGIN
		DECLARE @g table(value varchar(50))
		INSERT INTO @g(Value) (select * from GetStrTable(@gener_to_search))
	END

	SELECT
		Count(*)
	FROM Films
	JOIN Films_gener ON Films.id = Films_gener.id_film
	JOIN Gener ON Films_gener.id_gener = Gener.id_gener
	WHERE 
		(@year_from IS NULL OR Films.film_year >= @year_from)
		AND (@year_to IS NULL OR Films.film_year <= @year_to)
		AND (@gener_to_search IS NULL OR Gener.gener_name in ((SELECT value FROM @g)))
GO