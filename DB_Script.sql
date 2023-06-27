create table produtos(
    produto_id int not null primary key auto_increment,
    descricao varchar(80) not null,
    ean varchar(15),
    marca varchar(60) not null,
    peso double,
    largura double,
    altura double,
    profundidade double,
    inativo boolean not null,
    preco_venda double, 
    quantidade int,
    data_cadastro date not null
);

create table ufs(
    uf_id int not null primary key auto_increment,
    uf varchar(2) not null  
);

 create table cidades(
    cidade_id int not null primary key auto_increment,
    nome varchar(100) not null,
    uf_id int har(2) not null,
    foreign key(uf_id) references ufs(uf_id)
);

create table pessoas(
    pessoa_id int not null primary key auto_increment,
    nome varchar(100) not null,
    inativo boolean not null,
    cpf varchar(15) not null,
    rg varchar(10),
    genero varchar(15),
    nascimento date,
    estado_civil varchar(15),
    profissao varchar(20),
    nacionalidade varchar(20),
    telefone varchar(15),
    celular varchar(15) not null,
    wp boolean,
    email varchar(100),
    endereco varchar(100) not null,
    numero varchar(6) not null,
    complemento varchar(10),
    bairro varchar(50) not null,
    cidade varchar(50) not null,
    uf varchar(2) not null,
    cep varchar(9) not null,
    observacoes varchar(200),
    data_cadastro datetime not null
);

create table usuarios(
    usuario_id int not null primary key auto_increment,
    pessoa_id int,
    login varchar(20) not null,
    senha varchar(20) not null,
    inativo boolean not null
);


create table vendas(
	venda_id int not null primary key auto_increment,
    venda_data datetime not null,
    pessoa_id int not null,
    foreign key(pessoa_id) references pessoas(pessoa_id),
    usuario_id integer,
    foreign key (usuario_id) references usuarios(usuario_id),
    total_itens int not null,
    subtotal double not null,
    desconto double,
    valor_total double not null,
    pag_forma varchar(10) not null, 
    situacao varchar(10) not null,
    observacoes varchar(200)
);

create table vendaitens(
    vendaitem_id int not null primary key auto_increment,
    venda_id int not null,
    foreign key(venda_id) references vendas(venda_id),
    produto_id integer not null,
    foreign key(produto_id) references produtos(produto_id),
    quantidade integer not null,
    valorunitario double not null,
    subtotal double not null
);