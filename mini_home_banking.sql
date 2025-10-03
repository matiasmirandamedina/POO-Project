drop database if exists mini_home_banking;
create database if not exists mini_home_banking;
use mini_home_banking;

-- Tabla de Roles
create table roles (
    id smallint auto_increment primary key,
    name varchar(32) not null
);

-- Tabla de Usuarios
create table users (
    id bigint auto_increment primary key,
    role_id smallint not null,
    foreign key (role_id) references roles(id),
    username varchar(128) not null unique,
    full_name varchar(256) not null,
    email varchar(128) not null unique,
    password_hash varchar(256),
    created_at datetime not null default current_timestamp
);

-- Monedas
create table currencies (
	id smallint auto_increment primary key,
    code char(3) not null unique,
    name varchar(64) not null
);

-- Tipos de cuenta
create table account_types (
	id smallint auto_increment primary key,
    code varchar(32) not null unique,
    description varchar(256) not null
);

-- Cuentas
create table accounts (
	id bigint auto_increment primary key,
    user_id bigint not null,
    foreign key (user_id) references users(id) on delete cascade,
    account_type_id smallint not null,
    foreign key (account_type_id) references account_types(id),
    currency_id smallint not null,
    foreign key (currency_id) references currencies(id),
    cbu varchar(34) null unique,
    created_at datetime not null default current_timestamp,
    updated_at datetime null on update current_timestamp,
    current_balance decimal(20, 4) not null default 0.0,
    alias varchar(128) null
);

create index idx_accounts_user on accounts(user_id);
create index idx_accounts_cbu on accounts(cbu);

-- Movimientos / transacciones
create table transactions (
	id bigint auto_increment primary key,
    account_id bigint not null,
    foreign key (account_id) references accounts(id) ON DELETE CASCADE,
    type enum('DEBITO', 'CREDITO', 'INTERES', 'TARIFA') not null,
    amount decimal(20,4) not null,
    currency_id smallint not null,
    foreign key (currency_id) references currencies(id),
	description varchar(256),
	created_by bigint null,
    foreign key (created_by) references users(id),
    created_at datetime not null default current_timestamp,
    updated_at datetime null on update current_timestamp,
	reference varchar(256) null
);

create index idx_tx_account_date on transactions(account_id, created_at);

-- Tarjetas
create table cards (
	id bigint auto_increment primary key,
    user_id bigint not null,
    foreign key (user_id) references users(id) on delete cascade,
	account_id bigint null,
	foreign key (account_id) references accounts(id),
	card_number_hash char(16) unique,
	card_type enum('DEBITO', 'CREDITO') not null,
	expiration date,
	cvv_hash char(4) null,
    available_limit decimal(20,4) not null default 0.0,
	balance_to_pay decimal(20,4) not null default 0.0,
    created_at datetime not null default current_timestamp,
    updated_at datetime null on update current_timestamp
);

create index idx_cards_user on cards(user_id);

-- Movimientos de tarjeta
CREATE TABLE card_movements (
	id bigint auto_increment primary key,
	card_id bigint not null,
	foreign key (card_id) references cards(id) on delete cascade,
	amount decimal(20, 4) not null,
	type enum('CARGA', 'PAGO', 'TARIFA', 'REEMBOLSO') not null,
	description varchar(256),
	created_by bigint not null,
	foreign key (created_by) references users(id),
    created_at datetime not null default current_timestamp
);

create index idx_card_movements_card_date on card_movements(card_id, created_at);

-- Auditoría
create table audit_logs (
	id bigint auto_increment primary key,
	user_id bigint null,
	foreign key (user_id) references users(id),
	action varchar(128) not null,
	details json null,
    created_at datetime not null default current_timestamp
);

-- Tasas de interés
create table interest_rates (
	id bigint auto_increment primary key,
	account_type_id smallint not null,
	foreign key (account_type_id) references account_types(id),
	currency_id smallint not null,
	foreign key (currency_id) references currencies(id),
	annual_rate decimal(7, 6) not null default 0.0,
	unique (account_type_id, currency_id)
);

-- Reportes exportados
create table reports_exported (
	id bigint auto_increment primary key,
	admin_user_id bigint not null,
	foreign key (admin_user_id) references users(id),
	report_type varchar(128) not null,
	params json,
	file_path varchar(512) null,
    created_at datetime not null default current_timestamp
);
