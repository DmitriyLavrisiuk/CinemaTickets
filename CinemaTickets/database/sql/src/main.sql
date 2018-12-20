
-- Create DB and TABLES
GO
:r createDB.sql

-- Insert values in TABLES
GO
:r insertDB.sql

-- TRIGERS
GO
:r _trigers/trigers.sql

-- FUNCTIONS
GO
:r _functions/functions.sql

-- PROCEDURES

-- FIND FILMS
:r _procedures/FindAllFilms.sql
:r _procedures/FindFilmsByAllFilters.sql
-- GET COUNT FILMS BY FILTERS
:r _procedures/GetCountFilmsByAllFilters.sql
:r _procedures/GetCountAllFilms.sql
-- GET FULL LIST GENERS / PRODUCTION COUNTRIES
:r _procedures/GetFullListOfGeners.sql
:r _procedures/GetFullListOfProductionCountries.sql
-- GET ALL GENERS / PRODUCTION COUNTRIES TO FILM BY ID
:r _procedures/GetAllProductionCountriesFilmById.sql
:r _procedures/GetAllGenersFilmById.sql
-- GET ALL INFORMATION ABOUT TICKET BY UID
:r _procedures/GetAllInformationAboutTicketByUID.sql
-- RETURN TICKET
:r _procedures/ReturnTicket.sql