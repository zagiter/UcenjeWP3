use edunovawp3;

select * from smjerovi;

insert into smjerovi (naziv,trajanje,cijena,vaucer) values
('Web programiranje', 225, 1500.50,1);

insert into smjerovi (naziv) values ('čćšđ ČĆŠĐ');


select * from predavaci;

insert into predavaci (ime,prezime,email) values
--1
('Tomislav','Jakopec','tjakopec@gmail.com'),
--2
('Shaquille','O''Neal','shaki@gmail.com');


select * from polaznici;

--1 do 24
insert into polaznici(ime,prezime,email) values
('Slaven','Poznić','slaven.poznic@hotmail.com'),
('Karla','Kraljik','kraljikkarla@gmail.com'),
('Dino','Sabljić','dino.sabljic@gmail.com'),
('Luka','Crljić','lukacrljic7@gmail.com'),
('Mario','Baliban','mariobalibanos@gmail.com'),
('Branimir','Fekete','branimir.fekete@gmail.com'),
('Dajana','Tolić','dajanabozic@gmail.com'),
('Ivan','Tolić','ivan.tolic1989@gmail.com'),
('Tomislav','Kučić','tomislavkucic@gmail.com'),
('Zdenko','Barić','zbaric_hr@yahoo.com'),
('Mihael','Žulj','mihaelzulj@gmail.com'),
('Ivan','Marošević','ivanmarosevic4@gmail.com'),
('Goran','Kovačić','kovacic.go@gmail.com'),
('Nataša','Jakopec','njakopec@gmail.com'),
('Goran','Franjić','goran@proces.hr'),
('Ana','Jurić','ana.juric19@gmail.com'),
('Emina','Vejsilović','emiomiemi@gmail.com'),
('Josip','Rebolj','rebolj.josip031@gmail.com'),
('Merlin','Jišše','jisse.merlin@gmail.com'),
('Snežana','Grković','snezana4688@yahoo.com'),
('Rade','Jasenovčanin','rade.jasenovcanin@yahoo.com'),
('Krešimir','Bilokapić','ilead7@gmail.com'),
('Srđan','Filipović','srdjanfilipovic991@gmail.com'),
('Veljko','Vujić','veljko2805vujic@gmail.com');


insert into grupe (naziv,predavac,datumpocetka,smjer,maxpolaznika) values
--1
('WP3',1,'2023-11-29 19:00:00',1,25),
--2
('WP2', null,'2023-11-07 17:00:00',1,25);
