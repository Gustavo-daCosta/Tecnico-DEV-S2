-- DML - Inserir dados nas tabelas

-- Usar o banco criado
USE Exercicio_1_0;

-- Inserir dados na tabela
INSERT INTO Empresa(Nome, CNPJ)
VALUES ('Localiza', '67152468875685'), ('Movidas', '13548465454894')

INSERT INTO Cliente(Nome, CPF)
VALUES ('Carlos', '12345678912'), ('Eduardo', '98765432101')

INSERT INTO Marca(Nome)
VALUES ('GM'), ('Fiat')

INSERT INTO Modelo(Nome)
VALUES ('Onix'), ('Argo')

INSERT INTO Veiculo(IdEmpresa, IdModelo, IdMarca, Placa)
VALUES (1, 2, 2, '1AS234G'), (1, 1, 1, 'A126HK7')

INSERT INTO Aluguel(IdVeiculo, IdCliente, Protocolo)
VALUES (2, 1, '138415568'), (1, 2, '1681358466')
