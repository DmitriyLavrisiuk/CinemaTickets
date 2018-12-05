-- Процедура для поиска фильмов по 3 параметрам
-- EXAMPLE
-- EXEC findFilmsByFilters_3 @count_films_on_page = 8, @page_number = 3


GO
DROP PROC if exists findFilmsByFilters_3
GO
CREATE PROC findFilmsByFilters_3
	@count_films_on_page int = 20,
	@page_number int = 1,
	@year_from int = NULL,
	@year_to int = NULL,
	@gener_to_search varchar(256) = NULL
AS
	IF (@gener_to_search IS NOT NULL)
	BEGIN
		DECLARE @g table(value varchar(50))
		INSERT INTO @g(Value) (select * from GetStrTable(@gener_to_search))
	END

	SELECT TOP(@count_films_on_page)
		Films.id,
		Films.film_name,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
	FROM Films
	JOIN Films_gener ON Films.id = Films_gener.id_film
	JOIN Gener ON Films_gener.id_gener = Gener.id_gener
	WHERE 
		Films.id <= (@count_films_on_page * @page_number)
		AND (@year_from IS NULL OR Films.film_year >= @year_from)
		AND (@year_to IS NULL OR Films.film_year <= @year_to)
		AND (@gener_to_search IS NULL OR Gener.gener_name in ((SELECT value FROM @g)))
	GROUP BY 
		Films.id,
		Films.film_name,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
	ORDER BY id DESC
GO