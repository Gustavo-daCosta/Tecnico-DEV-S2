-- DML - Inserir dados nas tabelas

-- Usar o banco criado
USE Exercicio_1_0;

-- Inserir dados na tabela
INSERT INTO Genero(Nome)
VALUES ('Drama'), ('Comédia')

INSERT INTO Filme(IdGenero, Nome, DataLancamento)
VALUES (1, 'Oppenheimer', '2023-12-25')

SELECT * FROM Filme;
