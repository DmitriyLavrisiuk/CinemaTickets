-- Процедура для получения всех типо мест по номерам
-- EXAMPLE
-- EXEC GetAllTypesPlacesInHall @hall_id = 2

GO
DROP PROC if exists GetAllTypesPlacesInHall
GO
CREATE PROC GetAllTypesPlacesInHall
	@hall_id INT
AS	
	SELECT
		Place_type.place_name,
		Place_type.place_multiplier,
		place_from,
		place_to
	FROM Hall_type
	JOIN Place_type ON Hall_type.id_type = Place_type.id_place
	WHERE
		Hall_type.id_hall = @hall_id
GO
