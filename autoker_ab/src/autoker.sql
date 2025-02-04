create table autoker(
autoid int auto_increment primary key,
rendszam varchar(6) not null,
tipus varchar(50) not null,
szin varchar(10) not null,
tulajszam tinyint not null,
ar int not null
);

insert into autoker(rendszam,tipus,szin,tulajszam,ar)
values
("ABC123","Trabant","fehér",12,750000),
("XYZ987","Renault Thalia","szürke",3,450000),
("FGH654","Mustang","fekete",2,2500000),
("WER555","Ferrari","piros",1,150000000),
("GYP999","BMW","fekete",6,7500000);