CREATE DATABASE AJUDA_I
GO

CREATE TABLE Cliente
(
	idCliente INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	ClienteLogin VARCHAR (50) NOT NULL,
	Senha VARCHAR (128) NOT NULL,
	Nome VARCHAR (100) NULL,
	Email VARCHAR (100) NULL,
	Telefone VARCHAR (20) NULL,
	Celular VARCHAR (20) NULL,
	CEP VARCHAR (10) NULL,
	Endereço VARCHAR (255) NULL,
	Cidade VARCHAR (50) NULL,
	UF CHAR (2) NULL,	
)

CREATE TABLE Funcionario
(
	idFuncionario INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	FuncionarioLogin VARCHAR (50) NOT NULL,
	Senha VARCHAR (128) NOT NULL,
	Nome VARCHAR (100) NULL,
	Email VARCHAR (100) NULL,
	Telefone VARCHAR (20) NULL,
	Celular VARCHAR (20) NULL,
	NivelAcesso CHAR (1) NULL,
	NomeExibicao VARCHAR (50) NULL,		
)

CREATE TABLE Produto
(
	idProduto INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	Nome VARCHAR (50) NOT NULL,
	Descricao VARCHAR (100) NOT NULL
)

CREATE TABLE Chamado
(
	idChamado INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
	idCliente INT NOT NULL,
	idProduto INT NOT NULL,
	idFuncionario INT NULL,
	dtAbertura DATETIME NULL,
	Tipo VARCHAR (50) NULL,
	Descricao_PosicionamentoCliente VARCHAR (500) NULL,
	Prioridade CHAR (1) NULL,
	dtAtendimento DATETIME NULL,
	PosicionamentoFuncionario VARCHAR (500) NULL,
	Status VARCHAR (50) NULL,
	dtSolucao DATETIME NULL,
	Solucao VARCHAR (255) NULL,	
	Avaliacao CHAR (1) NULL,
	CONSTRAINT FK_Chamado_idCliente FOREIGN KEY (idCliente)
                    REFERENCES Cliente (idCliente),
	CONSTRAINT FK_Chamado_idProduto FOREIGN KEY (idProduto)
                    REFERENCES Produto (idProduto),
	CONSTRAINT FK_Chamado_idFuncionario FOREIGN KEY (idFuncionario)
                    REFERENCES Funcionario (idFuncionario)
) 
