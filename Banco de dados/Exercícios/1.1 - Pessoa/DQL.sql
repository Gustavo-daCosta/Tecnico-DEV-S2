-- Atividade DQL
-- Listar as pessoas em ordem alfabética reversa, mostrando seus telefones, seus emails e suas CNHs

USE Exercicio_1_1;

SELECT
	Pessoa.Nome,
	Telefone.Numero AS Telefone,
	Email.Endereco AS Email,
	Pessoa.CNH
FROM
	Pessoa,
	Email,
	Telefone
WHERE 
	Pessoa.IdPessoa = Email.IdPessoa
	AND Pessoa.IdPessoa = Telefone.IdPessoa
ORDER BY 
	-- Faz com que os itens apareçam em ordem decrescente
	Nome DESC


SELECT
	*
FROM
	Pessoa INNER JOIN Telefone ON Pessoa.IdPessoa = Telefone.IdPessoa