-- CRIANDO O BANCO DE DADOS
CREATE DATABASE dbProjetoLoja1;

-- USANDO O BANCO DE DADOS
USE dbProjetoLoja1;

-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tb_Usuario(
 Id int primary key auto_increment,
 Nome varchar(50) not null,
 Email varchar(50) not null,
 Senha varchar(250) not null,
 Nivel varchar(50) not null
);

CREATE TABLE tb_produtos(
Id INT PRIMARY KEY AUTO_INCREMENT,
Nome VARCHAR(50) NOT NULL,
DataCadastro DATETIME DEFAULT CURRENT_TIMESTAMP
);


show databases;


--  CONSULTANDO A TABELA DO BANCO DE DADOS

SELECT * FROM tb_Usuario;

SELECT * FROM tb_produtos;

-- INSERINDO DADOS NA TABELA DO BANCO DE DADOS

INSERT INTO tb_Usuario(Nome,Email,Senha, Nivel) VALUES 
('Administrador','admin@email.com','123456','Admin');


INSERT INTO tb_produtos(nome) VALUES ("Mouse");
INSERT INTO tb_produtos(nome) VALUES ("Teclado");
INSERT INTO tb_produtos(nome) VALUES ("Cadeira");
