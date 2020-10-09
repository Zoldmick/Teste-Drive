create database teste_drive;
use teste_drive;

create table tb_login(
id_login 				int primary key auto_increment,
nr_nivel 				int not null default 0,
ds_senha 				varchar(255) not null,
ds_email				varchar(255) not null unique,
nr_codigo_alteracao 	int
);


create table tb_notificacao(
id_notificacao		int primary key auto_increment,
id_login 			int not null,
ds_mensagem			varchar(255) not null,
dt_envio 			datetime not null,
ds_status 			varchar(255) not null,
bt_disponivel		bool,
FOREIGN KEY (id_login) REFERENCES tb_login(id_login) on delete cascade
);

create table tb_veiculo(
id_veiculo 			int primary key auto_increment,
ds_modelo			varchar(255) not null,
ds_placa 			varchar(50) not null unique,
vl_valor_veiculo  	decimal(10,2) not  null,
bt_carro_pcd		bool not null,
ds_adaptacao		varchar(255),
ds_imagem 			varchar(255),
dt_ano_modelo		date,
bt_disponivel 		bool not null,
ds_cor 				varchar(50),
ds_combustivel 		varchar(100),
ds_marca			varchar(100)
);

create table tb_cliente (
id_cliente 			int primary key auto_increment,
id_login			int not null,
nm_cliente 			varchar(100) not null,
ds_cpf 				varchar(12) not null,
ds_cnh				varchar(12) not null,
dt_nascimeto		datetime,
ds_imagem 			varchar(255),
ds_endereco 		varchar(255) not null,
ds_celular  		varchar(12) not null,
ds_telefone 		varchar(12) not null,
nr_residencia		int not null,
bt_deficiente		bool not null,
FOREIGN KEY (id_login) REFERENCES tb_login(id_login) on delete cascade
);


create table tb_agendamento (
id_agendamento 		int primary key auto_increment,
id_cliente 			int not null,
id_veiculo 			int not null,
dt_agendamento 		datetime not null,
ds_rota_inicial		varchar(255) not null,
ds_rota_final 		varchar(255) not null,
ds_status 			varchar(255) not null,
dt_final 			datetime not null,
nr_avaliacao		int,
ds_feedback			varchar(255),
ds_acompanhante 	varchar(255),
FOREIGN KEY (id_cliente) REFERENCES tb_cliente (id_cliente) on delete cascade ,
FOREIGN KEY (id_veiculo) REFERENCES tb_veiculo (id_veiculo) on delete cascade
);


insert into tb_login(ds_senha,ds_email,nr_codigo_alteracao) values ("kajabksxySLW882272","ex@gmail.com",109100);

show tables;

insert into tb_veiculo(ds_modelo,ds_placa,ds_marca,vl_valor_veiculo,bt_carro_pcd,dt_ano_modelo,ds_cor,ds_combustivel,bt_disponivel)
values ('Meriva','rbv-5331','chevrolet',34.000,false,'2020-06-21','cinza','Gasolina',true);

insert into tb_cliente(id_login,nm_cliente,ds_cpf,ds_cnh,ds_endereco,ds_celular,ds_telefone,nr_residencia,bt_deficiente)
values (1,'jose carlos','12345678900','12345678910','R. Alvares cabral','1195235648','11568975564',56,false);
select * from teste_drive.tb_login;
select * from teste_drive.tb_veiculo;
select * from tb_agendamento;