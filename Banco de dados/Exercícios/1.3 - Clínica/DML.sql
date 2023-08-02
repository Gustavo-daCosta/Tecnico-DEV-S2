-- DML - Inserir dados nas tabelas

-- Usar o banco criado
USE Exercicio_1_3;

-- Inserir dados na tabela
INSERT INTO Clinica(Endereco)
VALUES ('Rua Niterói'), ('Avenida Brasil');

INSERT INTO Veterinario(IdClinica, Nome, CRMV)
VALUES (1, 'Carlos', '123456'),(2, 'Eduardo', '654321');

INSERT INTO TipoPet(Descricao)
VALUES ('Cachorro'), ('Gato')

INSERT INTO Raca(Descricao)
VALUES ('Yorkshire'), ('Shitzu'), ('Pastor Alemão')

INSERT INTO Dono(Nome)
VALUES ('Gabriel'), ('Gustavo'), ('Guilherme')

INSERT INTO Pet(IdTipoPet, IdRaca, IdDono, Nome, DataNascimento)
VALUES (1, 1, 1, 'Tobi', '2021-10-31'), (1, 2, 2, 'Orion', '2016-04-20')

INSERT INTO Atendimentos(IdVeterinario, IdPet)
VALUES (1, 2), (1, 2)

SELECT * FROM Pet;