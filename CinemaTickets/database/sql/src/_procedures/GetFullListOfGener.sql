-- Получение спсика всех жанров
-- EXAMPLE
-- EXEC GetFullListGener

GO
DROP PROC if exists GetFullListOfGener
GO
CREATE PROC GetFullListOfGener
AS
	SELECT Gener.gener_name FROM Gener
GO