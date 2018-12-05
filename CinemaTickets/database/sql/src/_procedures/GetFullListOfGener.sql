-- Получение спсика всех жанров
-- EXAMPLE
-- EXEC getFullListGener

GO
DROP PROC if exists getFullListOfGener
GO
CREATE PROC getFullListOfGener
AS
	SELECT Gener.gener_name FROM Gener
GO