Create DATABASE DesignPatterns;
GO

USE DesignPatterns;
GO

CREATE TABLE Beer (
	Id INT IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(50),
	 CONSTRAINT [PK_dbo.Beer] PRIMARY KEY CLUSTERED ([Id] ASC)
	)
GO

CREATE TABLE Brand (
	Id INT IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(50),
	 CONSTRAINT [PK_dbo.Brand] PRIMARY KEY CLUSTERED ([Id] ASC)
	)
GO