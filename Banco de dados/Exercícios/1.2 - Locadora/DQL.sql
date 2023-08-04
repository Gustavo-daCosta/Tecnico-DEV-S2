-- DQL - Data Query Language

USE Exercicio_1_2;

-- Listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro
SELECT
	Aluguel.DataInicio,
	Aluguel.DataFim,
	Cliente.Nome,
	Modelo.Nome
FROM Veiculo
INNER JOIN Aluguel ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
INNER JOIN Cliente ON Aluguel.IdCliente = Cliente.IdCliente
INNER JOIN Modelo ON Modelo.IdModelo = Veiculo.IdModelo

-- Listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro
SELECT
	Aluguel.DataInicio,
	Aluguel.DataFim,
	Cliente.Nome,
	Modelo.Nome
FROM Cliente
INNER JOIN Aluguel ON Aluguel.IdCliente = Aluguel.IdCliente
INNER JOIN Veiculo ON Veiculo.IdVeiculo = Aluguel.IdVeiculo
INNER JOIN Modelo ON Modelo.IdModelo = Veiculo.IdModelo

SELECT
	Aluguel.DataInicio,
	Aluguel.DataFim,
	Cliente.Nome,
	Modelo.Nome
FROM Veiculo
	INNER JOIN Aluguel ON Aluguel.IdVeiculo = Veiculo.IdVeiculo
	INNER JOIN Cliente ON Aluguel.IdCliente = Cliente.IdCliente
	INNER JOIN Modelo ON Modelo.IdModelo = Veiculo.IdModelo
WHERE
	Cliente.Nome LIKE 'Eduardo'