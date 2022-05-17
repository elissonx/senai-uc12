CREATE DATABASE UC12SA3
GO

CREATE DATABASE UC12SA3
GO

USE UC12SA3
GO

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Senha VARCHAR(50) NOT NULL
)
GO

INSERT INTO Usuarios VALUES ('email@email.com', 1234)
INSERT INTO Usuarios VALUES ('email2@email.com', 1234) 
INSERT INTO Usuarios VALUES ('email3@email.com', 12345656) 

SELECT * FROM Usuarios

SELECT Email, HASHBYTES ('MD2', Senha) AS 'Senha HASH' FROM Usuarios Where Id = 1
SELECT Email, HASHBYTES ('MD4', Senha) AS 'Senha HASH' FROM Usuarios Where Id = 1
SELECT Email, HASHBYTES ('MD5', Senha) AS 'Senha HASH' FROM Usuarios Where Id = 1
SELECT Email, HASHBYTES ('SHA1', Senha) AS 'Senha HASH' FROM Usuarios Where Id = 1
SELECT Email, HASHBYTES ('SHA2_265', Senha) AS 'Senha HASH' FROM Usuarios Where Id = 1
SELECT Email, HASHBYTES ('SHA_512', Senha) AS 'Senha HASH' FROM Usuarios Where Id = 1
