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