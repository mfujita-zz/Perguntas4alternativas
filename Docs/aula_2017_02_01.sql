create database db_PerguntasRespostas
use db_PerguntasRespostas

create table tb_jogador (
  id_jogador int identity not null, 
  nome varchar(50) not null
)

select * from tb_jogador
delete from tb_jogador where id_jogador = 5
insert into tb_jogador (nome) values ('Ana')
delete from tb_jogador

--limpa os dados da tabela e reinicia o campo identity
truncate table tb_jogador

drop table tb_Perguntas

create table tb_Perguntas (
  id_pergunta int identity primary key,
  pergunta varchar(max),
  resposta_correta varchar(max),
  id_jogador int,
  data datetime default getdate(),  
)

alter table tb_Perguntas add id_jogador int

select * from tb_Perguntas

insert into tb_Perguntas(pergunta, resposta_correta, id_jogador) values ('4^(5/2)', '32', '1');