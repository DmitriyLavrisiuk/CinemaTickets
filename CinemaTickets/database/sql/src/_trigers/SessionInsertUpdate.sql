-- Триггер на добавление и изменение сеанса
GO
DROP TRIGGER if exists SessionInsertUpdate
GO
CREATE TRIGGER SessionInsertUpdate ON Sessions_list
AFTER INSERT, UPDATE AS

	DECLARE
		@id_film						decimal(6, 0),	/* ID фильма */
		@film_lenght_min				decimal(3, 0),	/* Продолжительность фильма */
		@id_hall						decimal(3, 0),	/* ID зала */
		@date_time_session				smalldatetime,	/* Дата сеанса */
		@current_date_time_session_end	smalldatetime,	/* Дата окончания фильма */

		@previous_id_film				decimal(6, 0),	/* ID предыдущего фильма */
		@previous_film_lenght_min		decimal(3, 0),	/* Продолжительность предыдущего фильма */
		@previous_date_time_session		smalldatetime,	/* Дата предыдущего сеанса */
		@previous_date_time_session_end smalldatetime,	/* Дата окончания предыдущего фильма */

		@next_date_time_session			smalldatetime,		/* Дата следующего сеанса */

		@time_for_cleaning				tinyint;		/* Время на уборку между сеансами */

	SET @time_for_cleaning = 15
	SET @id_film = (SELECT id FROM inserted)
	SET @film_lenght_min = (SELECT dbo.Films.film_length_min FROM dbo.Films WHERE dbo.Films.id = (SELECT id_film FROM inserted))
	SET @id_hall = (SELECT id_hall FROM inserted)
	SET @date_time_session = (SELECT date_time_session FROM inserted)

	-- Определение даты и времени следующего сеанса
	SET @next_date_time_session = (
		SELECT MIN(dbo.Sessions_list.date_time_session)
		FROM dbo.Sessions_list
		WHERE dbo.Sessions_list.id_hall = @id_hall
			AND dbo.Sessions_list.date_time_session > @date_time_session
	)

	-- Определение даты и времени предыдущего сеанса
	SET @previous_date_time_session = (
		SELECT MAX(dbo.Sessions_list.date_time_session)
		FROM dbo.Sessions_list
		WHERE dbo.Sessions_list.id_hall = @id_hall
			AND dbo.Sessions_list.date_time_session < @date_time_session
	)
	
	-- Определение id предыдущего фильма
	SET @previous_id_film = (
		SELECT dbo.Sessions_list.id_film
		FROM dbo.Sessions_list
		WHERE dbo.Sessions_list.id_hall = @id_hall
			AND dbo.Sessions_list.date_time_session = @previous_date_time_session
	)

	-- Определение продолжительности пердыдущего фильма
	SET @previous_film_lenght_min = (
		SELECT dbo.Films.film_length_min
		FROM dbo.Films
		WHERE dbo.Films.id = @previous_id_film
	)

	SET @previous_date_time_session_end = DATEADD (
		minute,
		@previous_film_lenght_min + @time_for_cleaning,
		@previous_date_time_session
	)

	SET @current_date_time_session_end = DATEADD (
		minute,
		@film_lenght_min + @time_for_cleaning,
		@date_time_session
	)

	IF (@previous_date_time_session_end > @date_time_session
		OR
		@current_date_time_session_end > @next_date_time_session
		OR
		1 != (SELECT COUNT(*)
		FROM dbo.Sessions_list
		WHERE dbo.Sessions_list.id_hall = @id_hall
			AND dbo.Sessions_list.date_time_session = @date_time_session)
	)
	BEGIN
		ROLLBACK TRAN
		PRINT 'Конфликт по времени между несколькими сеансами.'
	END
GO