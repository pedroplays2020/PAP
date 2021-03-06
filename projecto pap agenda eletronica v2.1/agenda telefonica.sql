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

 create table Horario(
	idHorario int identity primary key,
	IdUtilizador int foreign key references Utilizador( IdUtilizador ),
	idDiaSemana int not null foreign key references DiasSemana( idDiaSemana),
	idTempo int not null foreign key references Tempo( idtempo ),
	disciplina varchar(40),
	sala varchar(20)
);


create table Registo
(

   idRegisto int identity primary key,
   data date not null,
   hora time not null,
   viacomunicação varchar(50)null, 
   qta integer, 
   distinario varchar(50)not null,
   turma varchar(20) null,
   tiposerviço varchar(20) not null,
obs varchar(50) null
);

create table Espaço(
idEspaco int identity primary key,
nomeespaço varchar (40),
tipoespaço varchar(40)
);




 






