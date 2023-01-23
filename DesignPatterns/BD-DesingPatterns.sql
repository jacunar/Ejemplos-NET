Create DATABASE DesignPatterns;
GO

USE DesignPatterns;
GO

CREATE TABLE Beer (
	Id INT IDENTITY(1,1) NOT NULL,
	Nombre nvarchar(50),
	 CONSTRAINT [PK_dbo.GeoUsers] PRIMARY KEY CLUSTERED ([Id] ASC)
	)
GO

