-- Script bbdd gestor de refrigerantes creacion base y tablas.
-- Carlos Manuel Martinez Pomares 
-- DAM Semipresencial Proyecto final
-- BBDD REFRIGERANTES

USE master;
GO

IF EXISTS(SELECT * FROM sys.databases WHERE name = 'Refrigerantes')
BEGIN
    DROP DATABASE Refrigerantes;
END
GO

CREATE DATABASE Refrigerantes ON
(NAME = Refrigerantes_dat,
    FILENAME = 'C:\Users\carlo\RefrigerantesDB\refrigerantes.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5)
LOG ON
(NAME = Refrigerantes_log,
    FILENAME = 'C:\Users\carlo\RefrigerantesDB\refrigerantes_log.ldf',
    SIZE = 5 MB,
    MAXSIZE = 25 MB,
    FILEGROWTH = 5 MB);
GO

USE Refrigerantes;
GO
----------------------------------------------CREACION DE LAS TABLAS------------------------------------------

-- TABLA REFRIGERANTES

CREATE TABLE Refrigerante (
    refrigerante_id INT IDENTITY(1,1) PRIMARY KEY,
    nombre NVARCHAR(50) NOT NULL,
    CO2eq DECIMAL(10,2) NOT NULL,
    clase NVARCHAR(50) NOT NULL,
    grupo NVARCHAR(50) NOT NULL
);

-- TABLA TIPO EQUIPO

CREATE TABLE Tipo_equipo (
    tipo_equipo_id INT IDENTITY(1,1) PRIMARY KEY,
    tipo_equipo NVARCHAR(50) NOT NULL
);

-- TABLA CATEGORIA PROFESIONAL

CREATE TABLE Categoria_profesional (
    categoria_profesional_id INT IDENTITY(1,1) PRIMARY KEY,
    categoria_profesional NVARCHAR(50) NOT NULL
);

-- TABLA CLIENTE

CREATE TABLE Cliente (
    cliente_id INT IDENTITY(1,1) PRIMARY KEY,
    cif NVARCHAR(15) NOT NULL,
    nombre NVARCHAR(100) NOT NULL,
    direccion_facturacion NVARCHAR(200) NOT NULL
);

-- TABLA OPERARIO

CREATE TABLE Operario (
    operario_id INT IDENTITY(1,1) PRIMARY KEY,
    dni NVARCHAR(15) NOT NULL,
    nombre NVARCHAR(100) NOT NULL,
    apellido1 NVARCHAR(100) NOT NULL,
    apellido2 NVARCHAR(100),
    email NVARCHAR(50) NOT NULL,
    password NVARCHAR(64) NOT NULL,
    categoria_profesional_id INT NOT NULL,

    CONSTRAINT UQ_Operario_DNI UNIQUE (dni),

    CONSTRAINT FK_Operario_Categoria_profesional FOREIGN KEY (categoria_profesional_id)
        REFERENCES Categoria_profesional(categoria_profesional_id)
        ON DELETE CASCADE
);

-- TABLA INSTALACION

CREATE TABLE Instalacion (
    instalacion_id INT IDENTITY(1,1) PRIMARY KEY,
    cliente_id INT NOT NULL,
    nombre NVARCHAR(100) NOT NULL,
    direccion NVARCHAR(200) NOT NULL,
    horario NVARCHAR(50) NOT NULL,
    
    CONSTRAINT FK_Instalacion_Cliente FOREIGN KEY (cliente_id)
        REFERENCES Cliente(cliente_id)
        ON DELETE CASCADE
);

-- TABLA EQUIPO

CREATE TABLE Equipo (
    equipo_id INT IDENTITY(1,1) PRIMARY KEY,
    instalacion_id INT NOT NULL,
    refrigerante_id INT NOT NULL,  
    tipo_equipo_id INT NOT NULL,
    marca NVARCHAR(100) NOT NULL,
    modelo NVARCHAR(200) NOT NULL,
    carga_refrigerante DECIMAL(5,3) NOT NULL, 
    
    CONSTRAINT FK_Equipo_Instalacion FOREIGN KEY (instalacion_id)
        REFERENCES Instalacion(instalacion_id)
        ON DELETE CASCADE,
    
    CONSTRAINT FK_Equipo_Refrigerante FOREIGN KEY (refrigerante_id)
        REFERENCES Refrigerante(refrigerante_id)
        ON DELETE CASCADE,  
    
    CONSTRAINT FK_Equipo_Tipo_equipo FOREIGN KEY (tipo_equipo_id)
        REFERENCES Tipo_equipo(tipo_equipo_id)
        ON DELETE CASCADE
);

-- TABLA OPERACION DE CARGA

CREATE TABLE Operacion_carga (
    operacion_carga_id INT IDENTITY(1,1) PRIMARY KEY,
    operario_id INT NOT NULL,
    equipo_id INT NOT NULL,
    fecha_operacion DATETIME2 NOT NULL,
    descripcion NVARCHAR(500) NOT NULL,
    refrigerante_manipulado DECIMAL(5,3) NOT NULL,
    recuperacion BIT NOT NULL,
    
    CONSTRAINT FK_Operacion_carga_Operario FOREIGN KEY (operario_id)
        REFERENCES Operario(operario_id)
        ON DELETE CASCADE,

    CONSTRAINT FK_Operacion_carga_Equipo FOREIGN KEY (equipo_id)
        REFERENCES Equipo(equipo_id)
        ON DELETE CASCADE    
);
