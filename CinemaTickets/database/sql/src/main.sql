
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
GO
:r _procedures/getFullListOfGener.sql
:r _procedures/findFilmsByFilters_3.sql
:r _procedures/countResultFindFilmsByFilters_3.sql
:r _procedures/findFilmsByAllFilters.sql
:r _procedures/getAllInformationAboutTicketByUID.sql
:r _procedures/returnTicket.sql