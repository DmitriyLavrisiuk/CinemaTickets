GO
BEGIN TRY
	BEGIN TRAN

	/*17 country*/
	INSERT INTO Production (country_name) VALUES 
		('Россия'), ('США'), ('Беларусь'), 
		('Швеция'), ('Англия'), ('Япония'), 
		('Китай'), ('Бразилия'), ('Амстердам'),
		('ОАР'), ('КНР'), ('СССР'),
		('Швейцария'), ('Азербайджан'), ('Алжир'),
		('Австрия'), ('Андорра');

	/*21 gener*/
	INSERT INTO Gener (gener_name) VALUES
		('Ужасы'), ('Триллеры'), ('Фантастические'), 
		('Боевики'), ('Комедии'), ('Криминальные'), 
		('Драмы'), ('Мультфильмы'), ('Мелодрамы'), 
		('Боевые искусства'), ('Детективы'),
		('Семейные'), ('Драмы'), ('Военные'), 
		('Приключенческие'), ('Военные'), ('Мюзиклы'),
		('Спортивные'), ('Исторические'), ('Вестерны'),
		('Биографические');

	INSERT INTO Halls (hall_name, hall_places_count) VALUES
		('Hall 1', 100), ('Hall 2', 80), ('Hall 3', 120), 
		('Hall 4', 90), ('Hall 5', 60), ('Hall 6', 100);

	INSERT INTO Place_type (place_name, place_multiplier) VALUES
		('Standart', 1), ('Comfort', 1.2), ('Luxury', 1.5);

	INSERT INTO Films (film_name, film_year, film_length_min, film_price_ticket, film_photo, film_description, film_slogan) VALUES
		('Мстители 1', 2014, 114, 10, 'logoFilm.png', 'Описание фильма Мстители - Война бесконечности', 'Слоган 1'),
		('Астрал', 2015, 109, 8, 'logoFilm2.png', 'Описание фильма Астрал', 'Слоган 2'),
		('Матрица', 2006, 120, 5, 'logoFilm3.png', 'Описание фильма Матрица', 'Слоган 3'),
		('Аватар', 2009, 135, 10, 'logoFilm4.png', 'Описание фильма Аватар', 'Слоган 4'),
		('Мстители - Война бесконечности', 2018, 120, 15, 'logoFilm5.png', 'Описание фильма Мстители - Война бесконечности', 'Цвет настроение синий');

	INSERT INTO Films_gener (id_film, id_gener) VALUES
		(1, 2), (1, 3), (2, 9), (3, 4), (4, 4), (4, 3), (5, 1);

	INSERT INTO Films_production (id_film, id_country) VALUES
		(1, 1), (2, 11), (3, 3), (4, 1), (5, 2),
		(1, 2), (2, 12), (3, 4), (4, 2), (5, 3);

	INSERT INTO Sessions_list (id_film, id_hall, date_time_session) VALUES
		(1, 1, '2018-01-01 10:55:00'),
		(2, 2, '2018-02-02 12:45:00'),
		(3, 3, '2018-03-03 18:30:00'),
		(4, 4, '2018-04-04 23:10:00'),
		(5, 5, '2018-05-05 23:00:00');

	INSERT INTO Hall_type (id_hall, id_type, place_from, place_to) VALUES
		(1, 1, 1, 80), (1, 2, 81, 90), (1, 3, 91, 100),
		(2, 1, 1, 60), (2, 2, 61, 70), (2, 3, 71, 80),
		(3, 1, 1, 100), (3, 2, 101, 110), (3, 3, 111, 120),
		(4, 1, 1, 70), (4, 2, 71, 80), (4, 3, 81, 90),
		(5, 1, 1, 20), (5, 2, 21, 40), (5, 3, 41, 60),
		(6, 1, 1, 80), (6, 2, 81, 90), (6, 3, 91, 100)

	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	RAISERROR('Error in Transaction!',14,1)
END CATCH
GO