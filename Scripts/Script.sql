CREATE DATABASE 
DB_JsonWebToken
GO

USE DB_JsonWebToken
GO

CREATE TABLE dbo.Users(
	UserID varchar(20) NOT NULL,
	AccessKey varchar(32) NOT NULL,
	CONSTRAINT PK_Clientes PRIMARY KEY (UserID)
)
GO

CREATE TABLE dbo.Equipamento(
	IDEquipamento varchar(20) NOT NULL,
	Descricao varchar(32) NOT NULL,
	Status varchar(32) NOT NULL,
	CONSTRAINT PK_Ativo PRIMARY KEY (IDEquipamento)
)
GO

INSERT INTO dbo.Users (UserID,AccessKey) VALUES ('usuario01','74edv94vsd4v9sd4vsdFVBDF89FDSD94')
INSERT INTO dbo.Users (UserID,AccessKey) VALUES ('usuario02','654Vsdd84f6es4f6f84fsFERE6FDF51F')

INSERT INTO dbo.Equipamento (IDEquipamento,Descricao,Status) VALUES ('01','EletroA','Ativo')
INSERT INTO dbo.Equipamento (IDEquipamento,Descricao,Status) VALUES ('02','EletroB','Inativo')
INSERT INTO dbo.Equipamento (IDEquipamento,Descricao,Status) VALUES ('03','EletroC','Aguardando')
