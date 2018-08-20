CREATE DATABASE BD_CRUD;
GO
USE BD_CRUD;

CREATE TABLE TB_LOGIN(
	USUARIO		VARCHAR(32) PRIMARY KEY,
	SENHA		VARCHAR(32) NOT NULL
);

CREATE TABLE TB_Coordenador(
	Cod		int identity(1,1),
	Nome	varchar(30) not null,
	Idade	int,
	Salario money,
	Constraint PK_Cod_Coordenador	Primary Key	(Cod),
	Constraint CK_Idade				Check		(Idade > 0),
	Constraint CK_Salario			Check		(Salario >= 0)
);

CREATE TABLE TB_ALUNO(
	RA Varchar(10),
	Nome varchar(30) not null,
	CPF char(11) not null,
	Idade int,
	Constraint PK_RA Primary Key (RA),
	Constraint UQ_CPF Unique(CPF),
	Constraint CK_Idade_Aluno Check(idade>0)
);

CREATE TABLE TB_CURSO(
	Cod				INT IDENTITY,
	Nome			VARCHAR(30) NOT NULL,
	Cod_Coordenador INT NOT NULL,
	CONSTRAINT PK_Curso PRIMARY KEY(Cod),
	CONSTRAINT FK_CursoCoord FOREIGN KEY (Cod_Coordenador)
		REFERENCES TB_COORDENADOR(Cod)
);

CREATE TABLE TB_MATRICULA(
	Cod_Curso		INT NOT NULL,
	RA_Aluno		VARCHAR(10) NOT NULL,
	Data_Matricula	DATE NOT NULL DEFAULT GETDATE(),
	CONSTRAINT PK_MATRICULA PRIMARY KEY(COD_Curso,RA_Aluno)
);

select convert(date,getdate(),103)

INSERT INTO TB_LOGIN(USUARIO,SENHA) VALUES ('USUARIO','123456');
select * from TB_LOGIN
insert into TB_LOGIN(USUARIO,SENHA) 
values ('Admin','827CCB0EEA8A706C4C34A16891F84E7B');
--12345

INSERT INTO TB_Coordenador(Nome,Idade,Salario) VALUES ('JOAO',33,5000);
INSERT INTO TB_Coordenador(Nome,Idade,Salario) VALUES ('RAFAEL',39,8000);
INSERT INTO TB_Coordenador(Nome,Idade,Salario) VALUES ('Marta',21,18000);
INSERT INTO TB_ALUNO(RA,Nome,Idade,CPF) VALUES ('123','PEDRO',15,'12345678910');
INSERT INTO TB_ALUNO(RA,Nome,Idade,CPF) VALUES ('456','MARIA',18,'10987654321');
INSERT INTO TB_CURSO(Nome,Cod_Coordenador) VALUES('Ensino Medio',1); -- 1 = Joao
INSERT INTO TB_CURSO(Nome,Cod_Coordenador) VALUES('Informatica',2); -- 2 = Rafael
--INSERT INTO TB_MATRICULA(Cod_Curso,RA_Aluno) VALUES(1,'123'); -- Pedro - Ensino Medio
--INSERT INTO TB_MATRICULA(Cod_Curso,RA_Aluno) VALUES(2,'456'); -- Maria - Informatica

--declare @nome varchar(30);
--set @nome = 'Ciclano';
--insert into TB_Coordenador(nome,idade,salario)
--	values (@nome,18,2000.00);
--select * from TB_Coordenador where nome like 'i%'

SELECT
    M.COD_CURSO,
    C.NOME AS NOME_CURSO,                                    
    M.RA_ALUNO,
    A.NOME
FROM TB_MATRICULA M
INNER JOIN TB_CURSO C 
    ON (M.COD_CURSO = C.COD)
INNER JOIN TB_ALUNO A
    ON (M.RA_ALUNO = A.RA)

--SELECT * FROM TB_ALUNO JOIN TB_MATRICULA
--ON RA = RA_ALUNO

delete from TB_MATRICULA


INSERT INTO TB_Coordenador(Nome,Idade,Salario) VALUES ('Rafaela',50,8000);
SELECT top 1 SCOPE_IDENTITY() as ChaveGerada FROM TB_Coordenador;

select * from TB_Coordenador







SELECT
    RA,
    Nome,
    CPF,
    Idade
FROM
    TB_ALUNO
WHERE
    RA = '123'

DECLARE @usuario varchar(32);
DECLARE @senha varchar(32);

set @usuario = 'usuario';
set @senha = '123456';

SELECT
    USUARIO,
    SENHA
FROM
    TB_LOGIN
WHERE
    USUARIO = @usuario
AND
    SENHA = @senha