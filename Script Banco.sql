--USE MASTER
--DROP DATABASE SEGURSYS
CREATE DATABASE SEGURSYS
go
USE SEGURSYS
go
CREATE TABLE Funcionario (
id_func INT IDENTITY (1, 1) NOT NULL,
cpf VARCHAR(11) NULL,
telefone CHAR(10) NULL,
celular CHAR(11) NULL,
rg VARCHAR(14) NULL,
nome VARCHAR(150) NULL,
usuario VARCHAR(50) NOT NULL,
senha VARCHAR(16) NOT NULL,
nivel_acesso CHAR(1) NOT NULL,
ativo CHAR(1) NOT NULL,
CONSTRAINT UQ_CPF UNIQUE (cpf),
CONSTRAINT UQ_USER UNIQUE (usuario),
CONSTRAINT CK_ATIVO CHECK(ativo in ('0', '1')),
CONSTRAINT CK_NV_ACESSO CHECK(nivel_acesso in ('1', '2')),
CONSTRAINT PK_FUNC PRIMARY KEY(id_func)
)

CREATE TABLE _Local (
id_local INT IDENTITY (1, 1) NOT NULL,
complemento VARCHAR(MAX) NULL,
cidade VARCHAR(150) NULL,
rua VARCHAR(150) NULL,
numero VARCHAR(10) NULL,
cep CHAR(8) NULL,
CONSTRAINT PK_LOCAL PRIMARY KEY(id_local)
)

CREATE TABLE Area (
id_area INT IDENTITY (1, 1) NOT NULL,
ponto VARCHAR(30) NOT NULL,
id_local INT NULL,
ativo VARCHAR NOT NULL,
CONSTRAINT PK_AREA PRIMARY KEY(id_area),
CONSTRAINT CK_ATIVO_LOCAL CHECK(ativo in ('0', '1')),
CONSTRAINT FK_AREA_LOCAL FOREIGN KEY(id_local) REFERENCES _Local (id_local)
)

CREATE TABLE Turno (
id_turno INT IDENTITY (1, 1) NOT NULL,
horario_termino_intervalo TIME NOT NULL,
horario_intervalo TIME NOT NULL,
periodo VARCHAR(7) NOT NULL,
horario_de_inicio TIME NOT NULL,
horario_de_termino TIME NOT NULL,
CONSTRAINT CK_PERIODO CHECK(periodo in ('Diurno', 'Noturno')),
CONSTRAINT PK_TURNO PRIMARY KEY(id_turno)
)


CREATE TABLE Escala (
id_escala INT IDENTITY (1, 1) NOT NULL,
id_func INT NOT NULL,
id_turno INT NOT NULL,
dia_semana VARCHAR(10) NOT NULL,
ativo CHAR(1) NOT NULL,
CONSTRAINT PK_ESCALA PRIMARY KEY(id_escala),
CONSTRAINT CK_ATIVO_ESCALA CHECK(ativo in ('0', '1')),
CONSTRAINT CK_DIA CHECK (dia_semana in ('Domingo', 'Segunda','Terça', 'Quarta','Quinta', 'Sexta', 'Sábado', 'Todos')),
CONSTRAINT FK_ESCALA_TURNO FOREIGN KEY(id_turno) REFERENCES Turno (id_turno),
CONSTRAINT FK_ESCALA_FUNC FOREIGN KEY(id_func) REFERENCES Funcionario (id_func)
)

CREATE TABLE Ronda (
id_ronda INT IDENTITY (1, 1) NOT NULL,
rota VARCHAR(100) NOT NULL,
tempo TIME NULL,
id_local INT NULL,
id_escala INT NOT NULL,
CONSTRAINT PK_RONDA PRIMARY KEY(id_ronda),
CONSTRAINT FK_RONDA_LOCAL FOREIGN KEY(id_local) REFERENCES _Local (id_local),
CONSTRAINT FK_RONDA_ESCALA FOREIGN KEY(id_escala) REFERENCES Escala (id_escala)
)

CREATE TABLE Ocorrencia (
id_ocorrencia INT IDENTITY (1, 1) NOT NULL,
nivel_ocorrencia VARCHAR(8) NOT NULL,
data_acontecimento DATE NOT NULL,
acontecimento VARCHAR(MAX) NOT NULL,
hora_do_termino TIME NULL,
hora_de_inicio TIME NOT NULL,
hora_data_registro DATETIME NOT NULL,
id_area INT NOT NULL,
id_func INT NOT NULL,
id_turno INT NULL,
visto_por INT NULL,
_status VARCHAR(26) NOT NULL,
CONSTRAINT CK_STATUS CHECK(_status in ('Solucionado', 'Em Aberto', 'Encaminhado para a Policia')),
CONSTRAINT CK_NV_OCO CHECK(nivel_ocorrencia in ('Baixo', 'Médio', 'Alto')),
CONSTRAINT PK_OCORRENIA PRIMARY KEY(id_ocorrencia),
CONSTRAINT FK_OCO_AREA FOREIGN KEY(id_area) REFERENCES Area(id_area),
CONSTRAINT FK_OCO_FUNC FOREIGN KEY(id_func) REFERENCES Funcionario(id_func),
CONSTRAINT FK_VISTO_POR_FUNC FOREIGN KEY(visto_por) REFERENCES Funcionario(id_func),
CONSTRAINT FK_OCO_TURNO FOREIGN KEY(id_turno) REFERENCES Turno(id_turno)
)


CREATE TABLE Atual(
id_atual INT,
trabalhando CHAR(3) NOT NULL,
intervalo CHAR(3) NOT NULL,
ponto_atual VARCHAR(30) NOT NULL,
proximo_ponto VARCHAR(30) NOT NULL,
id_func INT NOT NULL,
dia_semana VARCHAR(10),
CONSTRAINT PK_ATUAL PRIMARY KEY (id_atual),
CONSTRAINT CK_TRABALHANDO CHECK(trabalhando in ('Sim', 'Não')),
CONSTRAINT CK_INTERVALO CHECK(intervalo in ('Sim', 'Não')),
CONSTRAINT CK_DIA_ATUAL CHECK (dia_semana in ('Domingo', 'Segunda','Terça', 'Quarta','Quinta', 'Sexta', 'Sábado')),
CONSTRAINT FK_FUNC_ATUAL FOREIGN KEY (id_func) REFERENCES Funcionario (id_func)
)

create table relatorio(
id_relatorio int identity(1,1),
data date NOT NULL,
relatorio_dia varchar(max) NOT NULL,
id_func int NOT NULL,
constraint PK_ID_REL primary key(id_relatorio),
constraint FK_ID_FUNBC_REL foreign key (id_func) references funcionario(id_func)
)
