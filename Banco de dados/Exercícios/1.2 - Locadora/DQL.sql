-- DQL - Data Query Language


-- Listar todos os alugueis mostrando as datas de início e fim, o nome do cliente que alugou e nome do modelo do carro
SELECT
	distinct
	A.DataInicio,
	A.DataFim,
	C.Nome,
	M.Nome,
	A.IdAluguel
FROM
	Empresa AS E,
	Cliente AS C,
	Modelo AS M,
	Marca AS Ma,
	Veiculo AS V,
	Aluguel AS A
WHERE
	A.IdCliente = C.IdCliente
	AND A.IdVeiculo = V.IdVeiculo
	AND M.IdModelo = V.IdModelo 
	AND V.IdMarca = Ma.IdMarca


-- Listar os alugueis de um determinado cliente mostrando seu nome, as datas de início e fim e o nome do modelo do carro