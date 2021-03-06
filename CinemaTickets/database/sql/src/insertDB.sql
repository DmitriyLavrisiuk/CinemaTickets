﻿GO
BEGIN TRY
	BEGIN TRAN

		/*17 country*/
		INSERT INTO Production (country_name) VALUES 
		('Россия'), ('США'), ('Беларусь'), 
		('Швеция'), ('Англия'), ('Япония'), 
		('Китай'), ('Бразилия'), ('Амстердам'),
		('ОАР'), ('КНР'), ('СССР'),
		('Швейцария'), ('Азербайджан'), ('Алжир'),
		('Австрия'), ('Андорра');
		PRINT 'INSERT INTO Production'

		/*19 gener*/
		INSERT INTO Gener (gener_name) VALUES
		('Ужасы'), ('Триллеры'), ('Фантастические'), 
		('Боевики'), ('Комедии'), ('Криминальные'), 
		('Драмы'), ('Мультфильмы'), ('Мелодрамы'), 
		('Боевые искусства'), ('Детективы'), ('Семейные'),
		('Военные'), ('Приключенческие'), ('Мюзиклы'),
		('Спортивные'), ('Исторические'), ('Вестерны'),
		('Биографические');
		PRINT 'INSERT INTO Gener'

		/* 6 Hall */
		INSERT INTO Halls (hall_name, hall_places_count) VALUES
		('Hall 1', 60), ('Hall 2', 60), ('Hall 3', 60), 
		('Hall 4', 60), ('Hall 5', 60), ('Hall 6', 60),
		('Hall 7', 60), ('Hall 8', 60), ('Hall 9', 60); 
		PRINT 'INSERT INTO Halls'

		/* 3 Place_type */
		INSERT INTO Place_type (place_name, place_multiplier) VALUES
		('Standart', 1), ('Comfort', 1.2), ('Luxury', 1.5);
		PRINT 'INSERT INTO Place_type'
		
		/* Films */
		INSERT INTO Films (film_name, film_year, film_age_limit, film_length_min, film_price_ticket, film_photo, film_description, film_slogan) VALUES
		('Патрик', 2018, 16, 90, 10, 'images/1/logo.jpg', 'Сара — молодая женщина, которая никак не может привести свою жизнь в порядок, несмотря на все старания.', '-'),
		('Хищник', 2018, 18, 110, 8, 'images/2/logo.jpg', 'На нашу планету прибывает инопланетный корабль. На место крушения прибывает элитный отряд спецназа, бойцы которого даже не представляют, с каким врагом им предстоит столкнуться. Выжить удается только одному бойцу, который пытается предупредить всех об опасности. Однако никто не хочет верить в то, что планете угрожают кровожадные убийцы из космоса. Главный герой воспитывает сына-аутиста, у которого нет друзей. Одноклассники постоянно издеваются над ним, но именно он может стать ключевой фигурой в схватке с Хищниками. Все дело в том, что парень способен невероятно быстро выучить любой новый язык и судя по всему он сможет понять, чего хотят пришельцы...', '«Youll never see him coming»'),
		('Поиск', 2018, 12, 110, 5, 'images/3/logo.jpg', 'Дэвид Ким в одиночку воспитывает дочь-подростка Марго. После смерти жены он уделяет девочке максимум внимания и обеспечивает ее всем необходимым. Она — самое дорогое, что есть у него в жизни и ради нее он готов на все. В один из дней Дэвид не может выйти на связь с Марго. Она не берет трубку и не отвечает на смс, а вечером выясняется, что ее не было днем в школе. Мужчина понимает, что она пропала и обращается за помощью в полицию. Он начинает поиски по всей Калифорнии и о пропаже девушки сообщают по всем новостным каналам. Однако все эти усилия не приносят никаких результатов. Тогда Дэвид пытается узнать хоть какую-то полезную информацию с помощью ноутбука дочери. Взломав устройство, он очень быстро осознает, что совершенно ничего не знает о своем ребенке...', '	«He just missed his daughters final call»'),
		('Миссия невыполнима: Последствия', 2018, 16, 100, 10, 'images/4/logo.jpg', 'Итан Хант — лучший специальный агент ЦРУ, выполняющий самые опасные и сложные миссии, с которыми многие просто не в состоянии справиться. Он не раз подвергал себя опасности ради своей страны и, наверное, каждый раз оказывался в невероятно сложной ситуации, в которой от него отворачивалось правительство и руководство. Несмотря ни на что, Итан всегда доводил свое дело до конца, принимая решение самостоятельно. На этот раз он вновь оказывается втянут в неприятную историю, которая может привести к огромному количеству жертв. У него нет поддержки правительства и ЦРУ, но Итан не намерен отступать и сделает все, чтобы решить проблему и вновь спасти мир. Единственные люди, на которых он может рассчитывать, — его верная команда профессионалов...', '-'),
		('22 мили', 2018, 12, 100, 15, 'images/5/logo.jpg', 'Призраки — элитный отряд секретной разведки, о существовании которого не знает даже правительство. Они берутся за дело только в том случае, когда проверенные методы уже не работают. На их плечи ложится колоссальная ответственность и они всегда добиваются поставленной цели. На этот раз им предстоит сотрудничать с ЦРУ. Их миссия — вывести из Индонезии полицейского, который владеет доказательствами коррупции в высших политических кругах. Влиятельные люди не могут допустить утечку такой информации, поэтому на свидетеля открыта настоящая охота. До спасительного самолета призракам предстоит преодолеть 22 смертельно опасные мили...', '«Призраки не играют по правилам»'),
		('Прибытие', 2016, 10, 115, 15, 'images/6/logo.jpg', 'Доктор Люси Бэнкс преподает лингвистику в одном из престижных университетов. Она является пожалуй лучшим специалистом по переводам, и именно поэтому к ней за помощью обращаются представители спецслужб. Однако женщина даже не подозревает, что ей предстоит переводить. На нашу планету прибыло несколько инопланетных кораблей, и никто не знает, что за собой несет их визит. Пришельцы выходят на контакт с людьми, и Люси пытается научиться общаться с ними. Постепенно, в процессе изучения неизвестного ранее языка, с ней начинает происходить серия флешбэков, благодаря чему она узнает тайну, с которой и связано прибытие инопланетной расы...', '-'),
		('Большая легенда', 2018, 16, 89, 15, 'images/7/logo.jpg', 'Тайлер Лэйрд — бывший рейнджер, который, вместе с любимой невестой Натали, отправился в отдаленную местность на рыбалку. Они разместились в лагере, но уже ночью на них напал неизвестный хищник, который унес девушку с собой. Тайлер заявляет о нападении Снежного человека, но никто не верит его словам. Все убеждены, что боль утраты сказалась на его психике, и Лэйрд оказывается в психушке. Из клиники он выходит спустя год и сразу же отправляется в те места, надеясь найти зверя и свою любимую. Даже если это не удастся ему, то возможно он хотя бы найдет ответы на многочисленные вопросы. В лесу он сталкивается с охотником Эли, который слышал о таинственном звере. Мужчины объединяют свои усилия в поисках Бигфута...', '-'),
		('Интервью с Богом', 2018, 16, 97, 15, 'images/8/logo.jpg', 'Пол Ашер — журналист, который даже бывал в горячих точках. Он безумно любит свою работу и готов на все, ради написания интересной статьи. Однако в данный момент он столкнулся с кризисом веры. Оказавшись на войне Пол думал, что станет ближе к Богу, но чем больше он молился, тем более пустыми оказывались его мольбы. Он надеялся, что получит какой-то знак, но этого не происходило. Дома его ждет любящая жена, отношения с которой в последнее время разладились. Однажды он отправляется на очередное интервью, которое перевернет всю его жизнь. Дело не в том, что его собеседник называет себя Богом, а в том, что вера Пола подвергнется настоящей проверке... ', '-'),
		('Шпион, который меня кинул', 2018, 16, 100, 15, 'images/9/logo.jpg', 'Одри и Морган — лучшие подруги, у которых нет секретов. Они знают друг о друге все, поэтому Морган была очень удивлена, когда стало известно, что бывший парень ее подруги оказался шпионом ЦРУ. Но не она одна была ошарашена этой новостью, поскольку сама Одри тоже ни о чем не подозревала. Она просто встречалась с обычным парень, которой в итоге просто бросил ее. Теперь ей сообщают о его смерти, но самое страшное то, что на плечи девушек ложится его незаконченная миссия, а вместе с ней и множество сопутствующих неприятностей и опасных испытаний, за которые можно заплатить собственной жизнью...', 'The Spy Who Dumped Me'),
		('Проклятие монахини', 2018, 16, 100, 15, 'images/10/logo.jpg', 'В одном из румынских монастырей совершает самоубийство юная монахиня. Ватикан начинает внутреннее расследование и отправляет на место происшествия священника с туманным прошлым и молодую послушницу. Прибыв в монастырь, они и представить себе не могли, с чем им предстоит столкнуться. Им предстоит противостоять злобной силе, принявшей облик демонической монахини. Рискуя не только собственными жизнями, но и верой, а также своими душами, герои выходят на поле ужасающей битвы между живыми и проклятыми. Смогут ли они преодолеть все испытания и одержать победу над настоящим исчадием ада?..', '«Witness the Darkest Chapter in The Conjuring Universe»'),
		('Мачо и ботан', 2012, 16, 109, 20, 'images/11/logo.jpg', 'Один из них был просто супер звездой в школе, его любили девушки, а все парни либо боялись либо уважали. Второй был просто классическим школьным ботаником, заучкой и стеснительным неудачником. Так сложились обстоятельства что оба этих кардинально разных парня пошли учится в полицейскую академию, которую и окончили. Свой первый же выход на патрулирование в роли уже настоящих полицейских парни с треском провалили, теперь шансы остаться на этой работе у них минимальны. Но появляется шанс и у этих неудачников. В полицейском департаменте сформировано специальное подразделение, агенты которого будут внедряться в учебные заведения в роли учеников. Наши двое парней идеально подходят для такого рода работы, в школе куда они отправляются вовсю торгуют новыми синтетическими наркотиками, а вот кто это делает не понятно. Теперь два новоиспечённых школьника должны найти источник поставок наркотиков и постараться обезвредить его, а при этом ещё и успеть вдоволь повеселится.', '«Операция «Анти-косяк»'),
		('Мстители: Война бесконечности', 2018, 16, 120, 15, 'images/12/logo.jpg', 'Мстители и их союзники продолжают защищать нашу планету, справляясь с опасностями, которые не под силу одному герою. На этот раз им предстоит посмотреть в лицо новой угрозе, возникшей из космоса. На нашу планету прибыл великий Танос — межгалактический тиран, который давно преследует цель собрать все шесть камней Бесконечности. Долгое время он не знал о месте их нахождения, но все тайное когда-нибудь становится явным. Теперь он готов уничтожить любую планету, на которой находятся камни. Его безжалостная армия разрушит все на своем пути и никто не сможет помешать ему. В этом предстоит убедиться и Мстителям, которые еще не сталкивались со столь мощным врагом. Все, что пережили герои, так или иначе вело именно к этому моменту...', '-');
		PRINT 'INSERT INTO Films'

		/* Films_gener */
		INSERT INTO Films_gener (id_film, id_gener) VALUES
		(1,3), (2,1), (3,3), (4,4), (5,4), (6,3), (7,4), (7,2), (7,3), (7,14),
		(8,7), (8,11), (9,4), (9,5), (10,1), (10,2), (10,11), (11,4), (11,5), (11,6),
		(12,3), (12,4), (12,14);
		PRINT 'INSERT INTO Films_gener'

		/* Films_production */
		INSERT INTO Films_production (id_film, id_country) VALUES
		(1,1), (2,4), (3,2), (3,3), (4,5), (5,4), (6,1), (7,2), (8,2), (9,2), (10,2),
		(11,2), (12,2);
		PRINT 'INSERT INTO Films_gener'

		/* Sessions_list */
		INSERT INTO Sessions_list (id_film, id_hall, date_time_session) VALUES
		(1, 1, '01/01/2019 10:00');
		INSERT INTO Sessions_list (id_film, id_hall, date_time_session) VALUES
		(2, 1, '01/01/2019 13:00');
		INSERT INTO Sessions_list (id_film, id_hall, date_time_session) VALUES
		(3, 1, '01/01/2019 17:00');
		INSERT INTO Sessions_list (id_film, id_hall, date_time_session) VALUES
		(4, 1, '01/01/2019 20:00');
		PRINT 'INSERT INTO Sessions_list'

		/* Hall_type */
		INSERT INTO Hall_type (id_hall, id_type, place_from, place_to) VALUES
		(1, 1, 1, 36), (1, 2, 37, 48), (1, 3, 49, 60),
		(2, 1, 1, 36), (2, 2, 37, 48), (2, 3, 49, 60),
		(3, 1, 1, 36), (3, 2, 37, 48), (3, 3, 49, 60),
		(4, 1, 1, 26), (4, 2, 27, 48), (4, 3, 49, 60),
		(5, 1, 1, 36), (5, 2, 37, 48), (5, 3, 49, 60),
		(6, 1, 1, 36), (6, 2, 37, 48), (6, 3, 49, 60),
		(7, 1, 1, 36), (7, 2, 37, 48), (7, 3, 49, 60),
		(8, 1, 1, 36), (8, 2, 37, 48), (8, 3, 49, 60)
		PRINT 'INSERT INTO Hall_type'

	COMMIT TRAN
END TRY
BEGIN CATCH
	ROLLBACK TRAN
	RAISERROR('Error in Transaction!',14,1)
END CATCH
GO
