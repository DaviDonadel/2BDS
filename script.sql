-- CRIANDO BANCO DE DADOS
create database dbpizza;
-- USANDO BANCO DE DADOS
use dbpizza;
-- CRIANDO AS TABELAS DO BANCO DE DADOS
CREATE TABLE tbPedido(
codPedido int primary key auto_increment,
tipoPizza varchar(50),
valorPizza varchar(50),
valorOpcao varchar(50),
valorTotal varchar(50)
);

-- CONSULTANDO AS TABELAS DO BANCO DE DADOS
select * from tbPedido;
