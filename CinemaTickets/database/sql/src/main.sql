
-- Create DB and TABLES
:r createDB.sql

-- Insert values in TABLES
:r insertDB.sql

-- TRIGERS
:r _trigers/trigers.sql

-- FUNCTIONS
:r _functions/functions.sql

-- PROCEDURES
:r _procedures/procedures.sql

EXEC Show_Films_With_Filters 100,NULL,2014,2018,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,'ASC'
