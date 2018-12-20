-- Получение спсика всех жанров
-- EXAMPLE
-- EXEC GetFullListOfGeners

GO
DROP PROC if exists GetFullListOfGeners
GO
CREATE PROC GetFullListOfGeners
AS
	SELECT Gener.gener_name FROM Gener
GO