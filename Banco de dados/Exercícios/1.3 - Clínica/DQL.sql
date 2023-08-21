-- DQL - Data Query Language

USE Exercicio_1_3;

-- listar todos os veterinários (nome e CRMV) de uma clínica (razão social)
SELECT 
	Clinica.Endereco AS 'Endereco Clinica',
	Veterinario.Nome AS 'Nome Veterinario',
	Veterinario.CRMV
FROM Clinica
INNER JOIN Veterinario ON Veterinario.IdClinica = Clinica.IdClinica
WHERE Clinica.Endereco LIKE 'Rua Niterói' -- 'Avenida Brasil'
-- WHERE Clinica.IdClinica LIKE 1


-- listar todas as raças que começam com a letra S
SELECT Raca.Descricao
FROM Raca
WHERE Raca.Descricao LIKE 'S%'

-- listar todos os tipos de pet que terminam com a letra O
SELECT TipoPet.Descricao
FROM TipoPet
WHERE TipoPet.Descricao LIKE '%O'

-- listar todos os pets mostrando os nomes dos seus donos
SELECT 
	Pet.Nome AS 'Nome do Pet',
	Dono.Nome AS 'Nome do Dono'
FROM Pet
INNER JOIN Dono ON Dono.IdDono = Pet.IdDono

-- listar todos os atendimentos mostrando o nome do veterinário que atendeu, o nome, a raça e o tipo do pet que foi atendido,
-- o nome do dono do pet e o nome da clínica onde o pet foi atendido
SELECT
	Clinica.Nome AS 'Nome da Clínica',
	Clinica.Endereco AS 'Endereço da Clínica',
	Veterinario.Nome AS 'Nome do Veterinário',
	Pet.Nome AS 'Nome do Pet',
	Raca.Descricao AS 'Raça do Pet',
	TipoPet.Descricao AS 'Tipo do Pet',
	Dono.Nome AS 'Nome do dono'
FROM Pet
INNER JOIN Atendimentos ON Atendimentos.IdPet = Pet.IdPet
INNER JOIN Veterinario ON Atendimentos.IdVeterinario = Veterinario.IdVeterinario
INNER JOIN Clinica ON Atendimentos.IdClinica = Clinica.IdClinica
INNER JOIN Raca ON Pet.IdRaca = Raca.IdRaca
INNER JOIN TipoPet ON Pet.IdTipoPet = TipoPet.IdTipoPet
INNER JOIN Dono ON Pet.IdDono = Dono.IdDono
