CREATE TABLE jogos (
	
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100),
	genero VARCHAR(100),
	classificacao VARCHAR(100),
	preco DECIMAL(7,2),
	data_lancamento DATETIME2,
	qtd_estoque INT

);

SELECT * FROM jogos;

CREATE TABLE consoles (

	id INT PRIMARY KEY IDENTITY(1,1),
	tipo VARCHAR(100),
	versao VARCHAR(100),
	preco DECIMAL(8,2),
	qtd_estoque INT
);