/************************/
/*   Создание таблиц    */
/************************/
--Create database Cinema
use Cinema

drop table if exists Films_gener;
drop table if exists Gener;
drop table if exists Films_production;
drop table if exists Production;
drop table if exists Hall_type;
drop table if exists Place_type;
drop table if exists Tickets;
drop table if exists Sessions_list;
drop table if exists Films;
drop table if exists Halls;
	
	
-- Список фильмов
CREATE TABLE Films (
	id											decimal(6) identity(1,1) not null,
	film_name									varchar(60) not null,
	film_year									decimal(4) not null,
	film_age_limit								decimal(2) not null,
	film_length_min								decimal(3) not null,
	film_price_ticket							decimal(3) not null,
	film_photo									varchar(100) not null,
	film_description							varchar(200) not null,
	film_slogan									varchar(100) not null)
alter table Films add
	Constraint csPK1							primary key(id),
	Constraint csDefault_film_name				default '-' for film_name,
	Constraint csDefault_film_year				default 0 for film_year,
	Constraint csDefault_film_age_limit			default 0 for film_age_limit,
	Constraint csDefault_film_length_min		default 0 for film_length_min,
	Constraint csDefault_film_price_ticket		default 0 for film_price_ticket,
	Constraint csDefault_film_photo				default '-' for film_photo,
	Constraint csDefault_film_description		default '-' for film_description,
	Constraint csDefault_film_slogan			default '-' for film_slogan,
	Constraint csCheck_film_price_ticket		check (film_price_ticket Between 0 and 500)


-- Производство
CREATE TABLE Production (
	id_country									decimal(4) identity(1,1) not null,
	country_name								varchar(25) not null)
alter table Production add 
	Constraint csPK4							primary key(id_country),
	Constraint csDefault_country_name			default '-' for country_name;


-- Фильм Производство
CREATE TABLE Films_production (
	id											decimal(6) identity(1,1) not null,
	id_film										decimal(6) not null,
	id_country									decimal(4) not null)
alter table Films_production add
	Constraint csPK5_id_film					primary key(id),
	Constraint csFK_id_film						foreign key(id_film) references Films(id) on delete cascade,
	Constraint csFK_id_country					foreign key(id_country) references Production(id_country) on delete cascade


-- Типы жанров
CREATE TABLE Gener (
	id_gener									decimal(2) identity(1,1) not null,
	gener_name									varchar(20) not null)
alter table Gener add
	Constraint csPK3							primary key(id_gener),
	Constraint csDefault_gener_name				default '-' for gener_name


-- Жанр фильма
CREATE TABLE Films_gener (
	id											decimal(6) identity(1,1) not null,
	id_film										decimal(6) not null,
	id_gener									decimal(2) not null)
alter table Films_gener add
	Constraint csPK2							primary key(id),
	Constraint csFK_id_film2					foreign key(id_film) references Films(id) on delete cascade,
	Constraint csFK_id_gener					foreign key(id_gener) references Gener(id_gener) on delete cascade


-- Залы
CREATE TABLE Halls (
	id											decimal(2) identity(1,1) not null,
	hall_name									varchar(20) not null,
	hall_places_count							decimal(3) not null)
alter table Halls add
	Constraint csPK9							primary key(id)


-- Типы места
CREATE TABLE Place_type (
	id_place									decimal(1) identity(1,1) not null,
	place_name									varchar(20) not null,
	place_multiplier							float not null)
alter table Place_type add
	Constraint csPK7							primary key(id_place)


-- Зал_Тип
CREATE TABLE Hall_type (
	id											decimal(2) identity(1,1) not null,
	id_hall										decimal(2) not null,
	id_type										decimal(1) not null,
	place_from									decimal(3) not null,
	place_to									decimal(3) not null)
alter table Hall_type add
	Constraint csPK8							primary key(id),
	Constraint csFK_id_hall						foreign key(id_hall) references Halls(id) on delete cascade,
	Constraint csFK_id_type						foreign key(id_type) references Place_type(id_place),
	Constraint csCH_place_from					check(place_from > 0),
	Constraint csCH_place_to					check(place_to > place_from)


-- Список сеансов
CREATE TABLE Sessions_list (
	id											decimal(6) identity(1,1) not null,
	id_film										decimal(6) not null,
	id_hall										decimal(2),
	date_time_session							DATETIME not null)
alter table Sessions_list add
	Constraint csPK6							primary key(id),
	Constraint csFK_id_film6					foreign key(id_film) references Films(id) on delete cascade,
	Constraint csFK_id_hall6					foreign key(id_hall) references Halls(id) on delete cascade


-- Билеты
CREATE TABLE Tickets (
	id											int identity(1,1) not null,
	id_session									decimal(6) not null,
	number_place								decimal(3) not null,
	date_time_session							datetime default null,
	price										float default null,
	unique_id_tickets							varchar(35) default null)
alter table Tickets add
	Constraint csPK10							primary key(id),
	Constraint csFK_id_session					foreign key(id_session) references Sessions_list(id) on delete cascade