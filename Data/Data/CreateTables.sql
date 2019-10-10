CREATE TABLE Tema(
	Id INT PRIMARY KEY,
	Descripcion NVARCHAR(MAX)
)

CREATE TABLE Categoria(
	Id INT PRIMARY KEY,
	Descripcion NVARCHAR(MAX)
)


CREATE TABLE TipoUsuario(
	Id INT PRIMARY KEY,
	Descripcion NVARCHAR(MAX)
)
create table Genero(
	Id INT PRIMARY KEY,
	Descripcion NVARCHAR(MAX)
)

create table Usuario(
	Id int identity(1,1) primary key,
	Nombre varchar(max),
	Apellido varchar(max),
	GeneroId int,
	TipoUsuarioId int,
	CONSTRAINT FK_Usuario_Genero FOREIGN KEY (GeneroId) 
	references Genero (Id),
	CONSTRAINT FK_Usuario_TipoUsuario FOREIGN KEY (TipoUsuarioId) 
	references TipoUsuario (Id)
)

CREATE TABLE Pregunta(
	Id BIGINT IDENTITY (1,1) PRIMARY KEY,
	Descripcion NVARCHAR(MAX) NOT NULL,
	SelMultiple BIT NOT NULL,
	TemaId INT,
	CategoriaId INT,
	CONSTRAINT FK_Pregunta_Tema FOREIGN KEY (TemaId) 
	references Tema(Id),
	CONSTRAINT FK_Pregunta_Categoria FOREIGN KEY (CategoriaId) 
	references Categoria(Id)
)


CREATE TABLE Respuesta(
	Id BIGINT PRIMARY KEY,
	Descripcion NVARCHAR(MAX),
	Correcta bit
)

CREATE TABLE RespuestaXPregunta(
	PreguntaId BIGINT,
	RespuestaId BIGINT,
	CONSTRAINT PK_RespuestaXPregunta PRIMARY KEY (PreguntaId,RespuestaId),
	CONSTRAINT FK_RespuestaXPregunta_Pregunta FOREIGN KEY (PreguntaId) 
	references Pregunta(Id),
	CONSTRAINT FK_RespuestaXPregunta_Respuesta FOREIGN KEY (RespuestaId) 
	references Respuesta(Id)
)


Create table Sesion(	
	Id Bigint identity(1,1) primary key,
	UsuarioId int,
	ContadorRespuestas int,
	MaxPreguntas int,
	CONSTRAINT FK_Sesion_Usuario FOREIGN KEY (UsuarioId) 
	references Usuario(Id)
)


Create table RespuestaXSesion(
	Id Bigint identity(1,1) primary key,
	PreguntaId bigint,
	RespuestaId bigint,
	SesionId bigint,
	CONSTRAINT FK_RespuestaXSesion_Pregunta FOREIGN KEY (PreguntaId) 
	references Pregunta(Id),
	CONSTRAINT FK_RespuestaXSesion_Respuesta FOREIGN KEY (RespuestaId) 
	references Respuesta(Id),
	CONSTRAINT FK_RespuestaXSesion_Sesion FOREIGN KEY (SesionId) 
	references Sesion(Id)
)

create table TipoLog(
	Id int primary key,
	Descripcion varchar(max)
)

create table Log(
	Id bigint identity(1,1) primary key,
	Descripcion varchar(max),
	TipoLogId int,
	Fecha datetime,
	CONSTRAINT FK_Log_TipoLog FOREIGN KEY (TipoLogId) 
	references TipoLog(Id)
)