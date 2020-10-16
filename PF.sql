drop database if exists PF;
create database PF;
use PF;

create table pays (
id int,
nom varchar(200),
primary key (id)
);

create table fromage (
id int,
paysorigineid int,
nom varchar(200),
creation date,
image varchar(200),
primary key (id),
foreign key (paysorigineid) references pays (id)
);

select * from pays;