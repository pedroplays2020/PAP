use master
go
drop database Agenda
go
create  database Agenda 
go 

use Agenda 

create table Funcao(
	idFuncao int identity(1,1) primary key,
	funcao varchar(50) not null
);

create table Areav(
	idArea int identity(1,1) primary key,
	nome varchar(50) not null,
	idFuncao int not null foreign key references Funcao( idFuncao )
);

create table Utilizador(
	 idUtilizador int identity(1,1) primary key,
	 utilizador varchar(15), 
	 chave varchar(15),
	 estado varchar(10),
	 tipodeutilizador varchar(20),
	 dtRegisto varchar(10),
	 horaRegisto varchar(8),
	 nome varchar(30),
	 morada varchar(30), 
	 codigoPostal varchar(4),
	 codigoPostal2 varchar(3),
	 localidade varchar(20), 
	 telefone varchar(9),
	 telemovel varchar(9), 
	 email varchar (25),
	 dataNascimento varchar(10),
	 idFuncao int foreign key references Funcao( idFuncao ),
	 idArea int foreign key references Areav( idArea ),
	 obs  varchar(50),
	 foto varchar(50)
);
 

create table Tempo(
	idtempo int identity primary key,
	intervaloHorario varchar(40) not null
);
create table DiasSemana(
	idDiaSemana int identity  primary key,
	diaSemana varchar(20) not null
);

create table area
(
idarea int identity primary key,
nomearea varchar(25)
);


create table Disciplina(

idDisciplina int identity primary key,
Nomedisciplina varchar(50),
idarea int foreign key references Area(idarea));

create table bloco (
idbloco int identity primary key, 
nomebloco varchar(20)
);

create table sala 
(
idsala int identity,
sala varchar (20),
idbloco int foreign key references bloco (idbloco),
primary key (idsala, idbloco)
);

 create table Horario(
	idHorario int identity primary key,
	IdUtilizador int foreign key references Utilizador( IdUtilizador ),
	NumHorario varchar (5),
	hora varchar (10),
	disc_seg varchar (20),
	sala_seg varchar (10),
	disc_ter varchar (20),
	sala_ter varchar (10),
	disc_qua varchar (20),
	sala_qua varchar (10),
	disc_qui varchar (20),
	sala_qui varchar (10),
	disc_sex varchar (20),
	sala_sex varchar (10),
);

create table Anolectivo(
idAnolectivo int identity primary key,
anolectivo varchar (9),
estado varchar(10)
);

create table turma(
idTurma int identity primary key,
descricao varchar(6),
ano varchar(5),
tipocurso varchar(15),
idAnoLectivo int foreign key references anolectivo(idanolectivo)
);

create table Registo(
   idregisto int identity primary key,
   idUtilizador int foreign key references  Utilizador(idUtilizador),
   data date,
   hora time,
   viacomunicação varchar(50),
   telefone varchar(9),
   telemovel varchar(9), 
   qta integer, 
   destinario varchar(50),
   turma varchar(20),
   tiposerviço varchar(20),
   anoletivo int foreign key references anolectivo(idanolectivo),
   obs varchar(150)
);

insert into funcao values('Administrador');
insert into Areav values('Administrador','1');
insert into utilizador values('Admin','123','ativo','Administrador',null,null,'Administrador',null,null,null,null,null,null,null,null,1,1,null,null);




 






