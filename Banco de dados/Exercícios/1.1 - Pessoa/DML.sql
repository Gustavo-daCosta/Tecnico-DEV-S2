-- DML - Inserir dados nas tabelas

-- Usar o banco criado
USE Exercicio_1_1;

-- Inserir dados na tabela
INSERT INTO Pessoa(Nome, CNH)
VALUES('Carlos', '123456789'), ('Eduardo', '987654321')

-- INSERT INTO Pessoa(Nome, CNH) VALUES('Carlos','123456789')

INSERT INTO Email(IdPessoa, Endereco)
VALUES(1, 'carlos@email.com')

INSERT INTO Telefone(IdPessoa, Numero)
VALUES(2, '145236987')
