-- Процедура для поиска фильмов по 14 параметрам
-- EXAMPLE
-- EXEC FindFilmsByAllFilters @production_to_search = "КНР,СССР,Россия"

GO
DROP PROC if exists FindFilmsByAllFilters
GO
CREATE PROC FindFilmsByAllFilters
	@count_films_on_page int = 20,
	@page_number int = 1,
	@year_from int = NULL,
	@year_to int = NULL,
	@age_limit_from int = NULL,
	@age_limit_to int = NULL,
	@length_from int = NULL,
	@length_to int = NULL,
	@price_ticket_from int = NULL,
	@price_ticket_to int = NULL,
	@description_words varchar(35) = NULL,
	@slogan_words varchar(35) = NULL,
	@gener_to_search varchar(256) = NULL,
	@production_to_search varchar(256) = NULL
AS
	IF (@gener_to_search IS NOT NULL)
	BEGIN
		DECLARE @g table(value varchar(50))
		INSERT INTO @g(Value) (select * from GetStrTable(@gener_to_search))
	END

	IF (@production_to_search IS NOT NULL)
	BEGIN
		DECLARE @p table(value varchar(50))
		INSERT INTO @p(Value) (select * from GetStrTable(@production_to_search))
	END

	SELECT
		Films.id,
		Films.film_name,
		Films.film_year,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_price_ticket,
		Films.film_photo,
		Films.film_description,
		Films.film_slogan
	FROM Films
	JOIN Films_gener ON Films.id = Films_gener.id_film
	JOIN Gener ON Films_gener.id_gener = Gener.id_gener
	JOIN Films_production ON Films.id = Films_production.id_film
	JOIN Production ON Films_production.id_country = Production.id_country
	WHERE
		Films.id > ((@count_films_on_page * @page_number) - @count_films_on_page)
		AND Films.id <= ((@count_films_on_page * @page_number))
		AND (@year_from IS NULL OR Films.film_year >= @year_from)
		AND (@year_to IS NULL OR Films.film_year <= @year_to)
		AND (@age_limit_from IS NULL OR Films.film_age_limit >= @age_limit_from)
		AND (@age_limit_to IS NULL OR Films.film_age_limit >= @age_limit_to)
		AND (@length_from IS NULL OR Films.film_length_min >= @length_from)
		AND (@length_to IS NULL OR Films.film_length_min <= @length_to)
		AND (@price_ticket_from IS NULL OR Films.film_price_ticket >= @price_ticket_from)
		AND (@price_ticket_to IS NULL OR Films.film_price_ticket <= @price_ticket_to)
		AND (@description_words IS NULL OR Films.film_description like @description_words)
		AND (@slogan_words IS NULL OR Films.film_description like @slogan_words)
		AND (@gener_to_search IS NULL OR Gener.gener_name in ((SELECT value FROM @g)))
		AND (@production_to_search IS NULL OR Production.country_name in ((SELECT value FROM @p)))
	GROUP BY 
		Films.id,
		Films.film_name,
		Films.film_year,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_price_ticket,
		Films.film_photo,
		Films.film_description,
		Films.film_slogan
	ORDER BY id ASC
GO
