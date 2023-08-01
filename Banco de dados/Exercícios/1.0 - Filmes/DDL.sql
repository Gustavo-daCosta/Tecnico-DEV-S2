-- DDL - Criar banco e tabelas

-- Criar um banco de dados
CREATE DATABASE Exercicio_1_0;

-- Usar o banco criado
USE Exercicio_1_0;

-- Criar tabelas do banco
CREATE TABLE Genero(
	IdGenero INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(25) NOT NULL UNIQUE,
);

CREATE TABLE Filme(
	IdFilme INT PRIMARY KEY IDENTITY,
	IdGenero INT FOREIGN KEY REFERENCES Genero(IdGenero) NOT NULL,
	Nome VARCHAR(50) NOT NULL UNIQUE,
	DataLancamento DATE NOT NULL,
);

SELECT * FROM Genero;
