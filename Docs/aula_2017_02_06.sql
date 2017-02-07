use db_PerguntasRespostas
delete from tb_Perguntas where id > 21 and id < 24
delete from tb_Perguntas where id = 7
select * from tb_Perguntas
select * from tb_jogador
alter table tb_Perguntas add id_jogador int

select tb_jogador.id_jogador, tb_jogador.nome, tb_Perguntas.pergunta, tb_Perguntas.resposta_correta 
from tb_jogador join tb_Perguntas 
on tb_jogador.id_jogador = tb_Perguntas.id_jogador

insert into tb_jogador (nome) values ('Ananita')
select @@IDENTITY
select @@SERVERNAME