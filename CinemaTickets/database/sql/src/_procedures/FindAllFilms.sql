-- Процедура для отображение всех фильмов
-- EXAMPLE
-- EXEC FindAllFilms @count_films_on_page = 10, @page_number = 1


GO
DROP PROC if exists FindAllFilms
GO
CREATE PROC FindAllFilms
	@count_films_on_page int = 20,
	@page_number int = 1
AS
	DECLARE @countFilms int = (
		SELECT count(DISTINCT (Films.id))
		FROM Films
		JOIN Sessions_list ON Films.id = Sessions_list.id_film
	)

	if(@page_number = 1)
		BEGIN
			SET @page_number = 0
		END
	ELSE
		BEGIN
			SET @page_number -= 1 
		END
		
	SELECT
		Films.id,
		Films.film_name,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
	FROM Films
	JOIN Sessions_list ON Films.id = Sessions_list.id_film
	WHERE Films.id = Sessions_list.id_film
	GROUP BY 
		Films.id,
		Films.film_name,
		Films.film_age_limit,
		Films.film_length_min,
		Films.film_photo
	ORDER BY id DESC
	OFFSET @page_number * @count_films_on_page ROW FETCH NEXT @count_films_on_page ROWS ONLY;
GO
