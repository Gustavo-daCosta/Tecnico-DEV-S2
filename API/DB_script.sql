CREATE DATABASE Filmes_Tarde
USE Filmes_Tarde

CREATE TABLE Genero(
	IdGenero INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50) NOT NULL
);

CREATE TABLE Filme(
	IdFilme INT PRIMARY KEY IDENTITY,
	IdGenero INT FOREIGN KEY REFERENCES Genero(IdGenero) NOT NULL,
	Titulo VARCHAR(50) NOT NULL
);

INSERT INTO Genero(Nome)
VALUES ('Drama'), ('Comédia'), ('Ação')

INSERT INTO Filme(IdGenero, Titulo)
VALUES (2, 'SENAI Adventures'), (1, 'The Back-End returns')

SELECT * FROM Genero
SELECT * FROM Filme
