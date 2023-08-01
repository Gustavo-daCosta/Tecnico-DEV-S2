-- DDL - Criar banco e tabelas

-- Criar um banco de dados
CREATE DATABASE Exercicio_1_1

-- Usar o banco criado
USE Exercicio_1_1;

-- Criar tabelas do banco
CREATE TABLE Pessoa (
	IdPessoa INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(45) NOT NULL,
	CNH CHAR(11) NOT NULL UNIQUE,
);

CREATE TABLE Telefone (
	IdTelefone INT PRIMARY KEY IDENTITY,
	IdPessoa INT FOREIGN KEY REFERENCES Pessoa(IdPessoa) NOT NULL,
	Numero VARCHAR(20) NOT NULL UNIQUE,
);

CREATE TABLE Email (
	IdEmail INT PRIMARY KEY IDENTITY,
	IdPessoa INT FOREIGN KEY REFERENCES Pessoa(IdPessoa) NOT NULL,
	Endereco VARCHAR(30) NOT NULL UNIQUE,
);

SELECT * FROM Pessoa, Email, Telefone;
