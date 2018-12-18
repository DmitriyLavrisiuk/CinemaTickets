-- Получение спсика всех жанров
-- EXAMPLE
-- EXEC GetFullListOfProductionCountries

GO
DROP PROC if exists GetFullListOfProductionCountries
GO
CREATE PROC GetFullListOfProductionCountries
AS
	SELECT Production.country_name FROM Production
GO