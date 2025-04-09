drop database insert ;

create database dbTransforme;

use dbTransforme;

create table tbFuncionarios(
codFunc int not null auto_increment,
nome varchar(100),
email varchar(100),
cpf char(14) not null unique,
dataNascimento datetime,
telCel char(14),
sexo char(1),
lougradoro varchar(100),
cep char(9),
numero char(10),
complemento varchar(100),
bairro varchar(100),
cidade varchar(100),
uf varchar(2),
primary key(codFunc)
);

insert into tbFuncionarios
	(nome,email,cpf,dataNasc,telCel,sexo,lougradoro,cep,numero,complemento,bairro,cidade,uf)values();