-- Получение спсика всех жанров
-- EXAMPLE
-- EXEC GetFullListGener

GO
DROP PROC if exists GetFullListGener
GO
CREATE PROC GetFullListGener
AS
	SELECT Gener.gener_name FROM Gener
GO