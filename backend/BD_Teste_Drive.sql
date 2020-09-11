create database db_tstdrive;
use db_tstdrive;

/*
select*from tb_login;
select*from tb_agendamento;
*/

create table tb_login(
id_usuario int auto_increment primary key,
nm_usuario varchar(255),
ds_senha varchar(225),
ds_endereco varchar (255),
ds_bairro varchar (255),
ds_cep varchar(255) ,
ds_telefone varchar (50),
ds_celular varchar (50),
ds_status varchar (255),
ds_imagem varchar(255),
bt_funcionario bool,
ds_email varchar(255),
bt_adm bool,
dt_inclusao date,
dt_ultimo_acesso datetime
);

create table tb_agendamento(
id_agendamento int auto_increment primary key,
id_usuario int not null,
ds_status varchar (255),
dt_agendamento date,
hr_inicial time,
hr_final time,
ds_veiculo varchar (255),
ds_acompanhante varchar (255),
foreign key (id_usuario) references tb_login (id_usuario)
);