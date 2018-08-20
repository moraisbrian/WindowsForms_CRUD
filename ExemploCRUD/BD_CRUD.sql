CREATE DATABASE BD_CRUD;
GO
USE BD_CRUD;

CREATE TABLE TB_LOGIN(
USUARIO VARCHAR(32) PRIMARY KEY,
SENHA VARCHAR(32) NOT NULL
);

CREATE TABLE TB_COORDENADOR(
Cod int identity(1,1),
Nome varchar(30) not null,
Idade int,
Salario money,
Constraint PK_Cod_Coordenador Primary Key (cod),
Constraint CK_Idade Check (Idade > 0),
Constraint CK_Salario Check (Salario >= 0)
);

CREATE TABLE TB_ALUNO(
RA VARCHAR(10),
Nome varchar(30) not null,
CPF char(11) not null,
Idade int,
Constraint PK_RA Primary Key (RA),
Constraint UQ_CPF Unique (CPF),
Constraint CK_Idade_Aluno Check (Idade > 0 )
);

CREATE TABLE TB_CURSO(
Cod int identity,
Nome varchar(30) not null,
Cod_Coordenador int not null,
Constraint PK_Curso Primary Key (cod),
Constraint FK_CursoCoord Foreign Key (Cod_Coordenador) 
references TB_COORDENADOR(Cod)
);

CREATE TABLE TB_MATRICULA(
Cod_Curso int not null,
RA_Aluno varchar(10) not null,
Data_Matricula date not null default getdate(),
Constraint PK_Matricula Primary Key (Cod_Curso, RA_Aluno),
constraint FK_ALUNO foreign key (RA_Aluno) references TB_ALUNO(RA),
constraint FK_CURSO foreign key (Cod_Curso) references TB_CURSO(Cod)
);

--TRUNCATE TABLE TB_LOGIN;
--INSERT INTO TB_LOGIN(USUARIO, SENHA) VALUES ('USUARIO', '123456');
--INSERT INTO TB_COORDENADOR (Nome, Idade, Salario) VALUES ('JOAO', 33, 5000);
--INSERT INTO TB_LOGIN(USUARIO, SENHA) VALUES ('ADM', 123);
--INSERT INTO TB_LOGIN(USUARIO,SENHA) VALUES ('Admin','827CCB0EEA8A706C4C34A16891F84E7B'); 12345
--INSERT INTO TB_COORDENADOR(Nome, Idade, Salario)VALUES ('JOAO', 33, 5000);
--INSERT INTO TB_LOGIN(USUARIO, SENHA) VALUES('JOAO', '1212');


--INSERT INTO TB_Coordenador(Nome,Idade,Salario) VALUES ('JOAO',33,5000);
--INSERT INTO TB_Coordenador(Nome,Idade,Salario) VALUES ('RAFAEL',39,8000);
--INSERT INTO TB_Coordenador(Nome,Idade,Salario) VALUES ('Marta',21,18000);
--INSERT INTO TB_ALUNO(RA,Nome,Idade,CPF) VALUES ('123','PEDRO',15,'12345678910');
--INSERT INTO TB_ALUNO(RA,Nome,Idade,CPF) VALUES ('456','MARIA',18,'10987654321');
--INSERT INTO TB_CURSO(Nome,Cod_Coordenador) VALUES('Ensino Medio',1); -- 1 = Joao
--INSERT INTO TB_CURSO(Nome,Cod_Coordenador) VALUES('Informatica',2); -- 2 = Rafael
--INSERT INTO TB_MATRICULA(Cod_Curso,RA_Aluno) VALUES(1,'123'); -- Pedro - Ensino Medio
--INSERT INTO TB_MATRICULA(Cod_Curso,RA_Aluno) VALUES(2,'456'); -- Maria - Informatica
