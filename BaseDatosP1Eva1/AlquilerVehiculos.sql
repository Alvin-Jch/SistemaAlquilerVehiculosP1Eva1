CREATE DATABASE IF NOT EXISTS alquiler_vehiculos_db;
USE alquiler_vehiculos_db;

CREATE TABLE IF NOT EXISTS vehiculos (
    id_vehiculo INT AUTO_INCREMENT PRIMARY KEY,
    placa       VARCHAR(10)   NOT NULL UNIQUE,
    marca       VARCHAR(50)   NOT NULL,
    modelo      VARCHAR(50)   NOT NULL,
    anio        INT           NOT NULL,
    color       VARCHAR(30)   NOT NULL,
    precio_dia  DECIMAL(10,2) NOT NULL
);

CREATE TABLE IF NOT EXISTS clientes (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    cedula     VARCHAR(15)  NOT NULL UNIQUE,
    nombre     VARCHAR(50)  NOT NULL,
    apellido   VARCHAR(50)  NOT NULL,
    telefono   VARCHAR(20)  NOT NULL,
    correo     VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS alquileres (
    id_alquiler  INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente   INT           NOT NULL,
    id_vehiculo  INT           NOT NULL,
    fecha_inicio DATE          NOT NULL,
    fecha_fin    DATE          NOT NULL,
    total        DECIMAL(10,2) NOT NULL,
    CONSTRAINT fk_alquiler_cliente  FOREIGN KEY (id_cliente)
        REFERENCES clientes (id_cliente)   ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT fk_alquiler_vehiculo FOREIGN KEY (id_vehiculo)
        REFERENCES vehiculos (id_vehiculo) ON UPDATE CASCADE ON DELETE RESTRICT,
    CONSTRAINT chk_fechas CHECK (fecha_fin >= fecha_inicio)
);