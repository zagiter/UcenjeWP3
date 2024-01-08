use master;
go
drop database if exists tvrtka;
go
create database tvrtka collate Croatian_CI_AS;
go
use tvrtka;

create table zaposlenici (
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datum_rodjenja datetime,
invalid bit not null
);


create table slike (
sifra int not null primary key identity(1,1),
zaposlenik int not null,
redni_broj char not null,
putanja varchar(100) not null
);

alter table slike add foreign key (zaposlenik) references zaposlenici(sifra);


--select * from zaposlenici;

insert into zaposlenici (ime,prezime,datum_rodjenja,invalid) values
--1
('Marko','Markić','1980','0'),
--2
('Ivo','Ivić','1982','1'),
--3
('Tea','Teić','1986','0');
--datumi bzvz :-)