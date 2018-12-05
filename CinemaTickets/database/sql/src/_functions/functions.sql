/********************************/
/*           Functions         */
/******************************/

GO
DROP TABLE if exists Numbers
GO
SELECT TOP 50 Number = IDENTITY(int, 1, 1)
   INTO   Numbers
   FROM   sysobjects t1, sysobjects t2, sysobjects t3

GO
DROP FUNCTION if exists GetStrTable
GO
CREATE FUNCTION GetStrTable (@param varchar(max)) RETURNS TABLE AS
   RETURN(SELECT substring(',' + @param + ',', Number + 1,
                    charindex(',', ',' + @param + ',', Number + 1) - Number - 1)
                 AS Str
          FROM   Numbers
          WHERE  Number <= len(',' + @param + ',') - 1
            AND  substring(',' + @param + ',', Number, 1) = ',')
GO
--DECLARE @t table(Value varchar(max)) 
--INSERT INTO @t(Value) (select * from GetStrTable('Country7,Country2,Country4'))
--SELECT * FROM @t