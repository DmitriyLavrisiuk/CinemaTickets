-- Процедура для отображение всех фильмов
-- EXAMPLE
-- EXEC FindAllFilms @count_films_on_page = 3, @page_number = 5


GO
DROP PROC if exists FindAllFilms
GO
CREATE PROC FindAllFilms
	@count_films_on_page int = 20,
	@page_number int = 1
AS
	SELECT
		Films.id,
		Films.film_name,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
	FROM Films
	WHERE
		Films.id > ((@count_films_on_page * @page_number) - @count_films_on_page)
		AND Films.id <= ((@count_films_on_page * @page_number))
	GROUP BY 
		Films.id,
		Films.film_name,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
	ORDER BY id ASC
GO
