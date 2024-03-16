use master;
go
drop database if exists kazaliste;
go
create database kazaliste collate Croatian_CI_AS;
go
use kazaliste;


create table predstave (
    sifra int not null primary key identity(1,1),
    naziv varchar(255) not null,
    datum datetime not null,
    cijena decimal(10,2),
);

create table kupci (
    sifra int not null primary key identity(1,1),
    ime varchar(50) not null,
    prezime varchar(50) not null,
    email varchar(100),
    telefon varchar(20)
);

create table kupovine (
    sifra int not null primary key identity(1,1),
    kupac_sifra int not null,
    predstava_sifra int not null,
    broj_sjedala int not null,
    
	foreign key (kupac_sifra) references kupci(sifra),
    foreign key (predstava_sifra) references predstave(sifra)
);


insert into predstave (naziv, datum, cijena) values 
('Vesela udovica', '2024-03-19 18:00:00', 15.00),
('Maratonci tr�e po�asni krug', '2024-03-21 19:00:00', 15.00);


insert into kupci (ime, prezime, email, telefon) values 
('Ivana', 'Ivi�', 'ivanai@nekimail.com', '123456789'),
('Marko', 'Marki�', 'markom@nekimail.com', '234567891'),
('Pero', 'Peri�', 'perop@nekimail.com', '313131313');


insert kupovine (kupac_sifra, predstava_sifra, broj_sjedala) values 
(1, 2, 2),
(3, 1, 1),      
(2, 1, 4);

select * from predstave
select * from kupci
select * from kupovine