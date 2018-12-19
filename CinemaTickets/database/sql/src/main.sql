
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

:r _procedures/FindFilmsBy3Filters.sql
:r _procedures/FindFilmsByAllFilters.sql
:r _procedures/GetCountFilmsBy3Filters.sql
:r _procedures/GetCountFilmsByAllFilters.sql
:r _procedures/GetAllInformationAboutTicketByUID.sql
:r _procedures/GetFullListOfGener.sql
:r _procedures/GetFullListOfProductionCountries.sql
:r _procedures/ReturnTicket.sql