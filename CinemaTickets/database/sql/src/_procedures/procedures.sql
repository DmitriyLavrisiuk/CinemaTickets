/********************************/
/*          Процедуры          */
/******************************/

-- 1. Отображение списка фильмов c применением фильтров всех видов
GO
DROP PROC if exists Show_Films_With_Filters
GO
CREATE PROC Show_Films_With_Filters
	@count_films_on_page int,
	@page_number int,
	@year_on decimal(4, 0),
	@year_to decimal(4, 0),
	@age_limit_on decimal(2, 0),
	@age_limit_to decimal(2, 0),
	@length_on decimal(3, 0),
	@length_to decimal(3, 0),
	@price_ticket_on decimal(3, 0),
	@price_ticket_to decimal(3, 0),
	@film_desc text, 
	@film_slogan text,
	@sort_type varchar(4)
AS DECLARE 
	@query varchar(355)

	-- COUNT FILMS ON PAGE
	if(@count_films_on_page IS NULL or @count_films_on_page <= 0) BEGIN
		SET @count_films_on_page = 20
	END

	-- PAGE NUMBER
	if(@page_number IS NULL or @page_number <= 0) BEGIN
		SET @page_number = 1
	END

	SET @query = 'SELECT TOP(' + CONVERT(varchar, @count_films_on_page) + ') * FROM dbo.Films WHERE id > ' + CONVERT(varchar, (@count_films_on_page * @page_number) - @count_films_on_page) + ' '

	-- YEAR
	-- where (@year_on is null or (@year_on > 0 and film_year >= @year_on))


	if(@year_on IS NOT NULL AND @year_on > 0) BEGIN
		SET @query += 'AND film_year >= ' + CONVERT(varchar, @year_on) + ' '
		if(@year_to IS NOT NULL AND @year_on < @year_to) BEGIN
			SET @query += 'AND film_year <= ' + CONVERT(varchar, @year_to) + ' '
		END
	END

	-- AGE LIMIT
	if(@age_limit_on IS NOT NULL AND @age_limit_on >= 0) BEGIN
		SET @query += 'AND film_age_limit >= ' + CONVERT(varchar, @age_limit_on) + ' '
		if(@age_limit_to IS NOT NULL AND @age_limit_on < @age_limit_to) BEGIN
			SET @query += 'AND film_age_limit <= ' + CONVERT(varchar, @age_limit_to) + ' '
		END
	END
	
	-- LENGTH
	if(@length_on IS NOT NULL AND @length_on > 0) BEGIN
		SET @query += 'AND film_length_min >= ' + CONVERT(varchar, @length_on) + ' '
		if(@length_to IS NOT NULL AND @length_on < @length_to) BEGIN
			SET @query += 'AND film_length_min <= ' + CONVERT(varchar, @length_to) + ' '
		END
	END

	-- PRICE TICKET
	if(@price_ticket_on IS NOT NULL AND @price_ticket_on > 0) BEGIN
		SET @query += 'AND film_price_ticket >= ' + CONVERT(varchar, @price_ticket_on ) + ' '
		if(@price_ticket_to IS NOT NULL AND @price_ticket_on < @price_ticket_to) BEGIN
			SET @query += 'AND film_price_ticket <= ' + CONVERT(varchar, @price_ticket_to) + ' '
		END
	END

	-- LIKE DESCRIPTION
	if(@film_desc IS NOT NULL) BEGIN
		SET @query += 'AND film_description LIKE ' + CONVERT(varchar, @film_desc) + ' '
	END

	-- LIKE SLOGAN
	if(@film_slogan IS NOT NULL) BEGIN
		SET @query += 'AND film_slogan LIKE ' + CONVERT(varchar, @film_slogan) + ' '
	END
	
	-- SORT BY ASC | DESC
	if(@sort_type != 'DESC' and @sort_type != 'ASC') BEGIN
		SET @sort_type = 'DESC'
	END

	EXEC(@query + 'ORDER BY id ' + @sort_type)





/* ==== EXAMPLE CALL PROCEDURE Show_Films_With_Filters ==== */
-- EXEC Show_Films_With_Filters NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'ASC'











/*
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
WHERE Gener.gener_name = 'Триллеры' OR Gener.gener_name = 'Фантастические'
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
*/




