drop database if exists mini_home_banking;
create database if not exists mini_home_banking;
use mini_home_banking;

-- Tabla de Roles
create table roles (
    id smallint auto_increment primary key,
    name varchar(32) not null
);
INSERT INTO roles (name) VALUES
	('ADMIN'),
    ('CLIENT');

-- Tabla de Usuarios
create table users (
    id bigint auto_increment primary key,
    role_id smallint not null,
    foreign key (role_id) references roles(id),
    username varchar(128) not null unique,
    full_name varchar(256) not null,
    email varchar(128) not null unique,
    password_hash varchar(64),
    created_at datetime not null default current_timestamp
);
INSERT INTO users (role_id, username, full_name, email, password_hash) VALUES
	(1, 'admin1', 'Admin Uno', 'admin1@example.com', MD5('pass1')),
	(2, 'client1', 'Cliente Uno', 'client1@example.com', MD5('pass2')),
	(2, 'client2', 'Cliente Dos', 'client2@example.com', MD5('pass3'));

-- Monedas
create table currencies (
	id smallint auto_increment primary key,
    code char(3) not null unique,
    name varchar(64) not null
);
INSERT INTO currencies (code, name) VALUES
	('USD', 'Dólar'),
    ('ARS', 'Peso Argentino'),
    ('EUR', 'Euro');

-- Tipos de cuenta
create table account_types (
	id smallint auto_increment primary key,
    code varchar(32) not null unique,
    description varchar(256) not null
);
INSERT INTO account_types (code, description) VALUES
	('SAV', 'Cuenta Ahorro'),
	('CHK', 'Cuenta Corriente');

-- Cuentas
create table accounts (
	id bigint auto_increment primary key,
    user_id bigint not null,
    foreign key (user_id) references users(id) on delete cascade,
    account_type_id smallint not null,
    foreign key (account_type_id) references account_types(id),
    currency_id smallint not null,
    foreign key (currency_id) references currencies(id),
    cbu varchar(34) not null unique,
    created_at datetime not null default current_timestamp,
    updated_at datetime null on update current_timestamp,
    current_balance decimal(20, 2) not null default 0.0,
    alias varchar(128) not null
);
INSERT INTO accounts (user_id, account_type_id, currency_id, cbu, current_balance, alias) VALUES
	(2, 1, 2, '1', 1000.0, 'Ahorro.ARS.Cliente1'),
	(3, 1, 2, '2', 2000.0, 'Ahorro.ARS.Cliente2'),
	(2, 2, 2, '3', 500.0, 'Corriente.ARS.Cliente1'),
	(3, 2, 2, '4', 1500.0, 'Corriente.ARS.Cliente2'),
	(2, 1, 1, '5', 300.0, 'Ahorro.USD.Cliente1'),
	(3, 1, 3, '6', 600.0, 'Ahorro.EUR.Cliente2'),
	(2, 2, 1, '7', 0.0, 'Corriente.USD.Cliente1'),
	(3, 2, 3, '8', 0.0, 'Corriente.EUR.Cliente2');

create index idx_accounts_user on accounts(user_id);
create index idx_accounts_cbu on accounts(cbu);

-- Movimientos / transacciones
create table transactions (
	id bigint auto_increment primary key,
    account_id bigint not null,
    foreign key (account_id) references accounts(id) ON DELETE CASCADE,
    destination_account_id bigint null,
	foreign key (destination_account_id) references accounts(id),
    type enum('DEBITO', 'CREDITO', 'INTERES', 'TARIFA') not null,
    amount decimal(20,4) not null,
    currency_id smallint not null,
    foreign key (currency_id) references currencies(id),
	description varchar(256),
	created_by bigint not null,
    foreign key (created_by) references users(id),
    created_at datetime not null default current_timestamp,
    updated_at datetime null on update current_timestamp
);
INSERT INTO transactions (account_id, destination_account_id, type, amount, currency_id, description, created_by) VALUES
	(1, 2, 'DEBITO', 100.0, 2, 'Pago de servicios', 2),
	(2, 1, 'CREDITO', 100.0, 2, 'Recibo de pago', 3);

create index idx_tx_account_date on transactions(account_id, created_at);

-- Tarjetas
create table cards (
	id bigint auto_increment primary key,
	user_id bigint,
	foreign key (user_id) references users(id),
	card_number char(16) unique,
	card_type enum('DEBITO', 'CREDITO') not null,
	expiration date,
	cvv char(4) null,
    available_limit decimal(20,4) not null default 0.0,
	balance_to_pay decimal(20,4) not null default 0.0,
    created_at datetime not null default current_timestamp,
    updated_at datetime null on update current_timestamp
);
INSERT INTO cards (user_id, card_number, card_type, expiration, cvv, available_limit, balance_to_pay) VALUES
	(2, '1111222233334444', 'DEBITO', '2026-12-31', '123', 1000.0, 0.0),
	(3, '5555666677778888', 'DEBITO', '2026-11-30', '456', 1500.0, 0.0),
	(2, '9999000011112222', 'CREDITO', '2027-01-31', '789', 5000.0, 100.0),
	(3, '3333444455556666', 'CREDITO', '2027-06-30', '012', 3000.0, 50.0),
	(2, '7777888899990000', 'DEBITO', '2026-09-30', '345', 800.0, 0.0),
	(3, '4444555566667777', 'DEBITO', '2026-10-31', '678', 1200.0, 0.0),
	(2, '2222333344445555', 'CREDITO', '2027-03-31', '901', 2000.0, 500.0),
	(3, '6666777788889999', 'CREDITO', '2027-05-31', '234', 4000.0, 0.0),
	(2, '8888999900001111', 'DEBITO', '2026-08-31', '567', 700.0, 0.0),
	(3, '0000111122223333', 'CREDITO', '2027-12-31', '890', 1000.0, 0.0);

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
INSERT INTO interest_rates (account_type_id, currency_id, annual_rate) VALUES
	(1, 1, 0.02),
	(1, 2, 0.03),
	(1, 3, 0.025),
	(2, 1, 0.01),
	(2, 2, 0.015),
	(2, 3, 0.012);

-- Auditoría
create table audit_logs (
	id bigint auto_increment primary key,
	user_id bigint null,
	foreign key (user_id) references users(id),
	action varchar(128) not null,
	details json null,
    created_at datetime not null default current_timestamp
);

-- Reportes exportados
create table reports_exported (
	id bigint auto_increment primary key,
	admin_user_id bigint not null,
	foreign key (admin_user_id) references users(id),
	report_type varchar(128) not null,
	params text,
	file_path varchar(512) null,
    created_at datetime not null default current_timestamp
);