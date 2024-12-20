-- Script bbdd gestor de refrigerantes inserts
-- Carlos Manuel Martinez Pomares 
-- DAM Semipresencial Proyecto final
-- BBDD REFRIGERANTES

----------------------------------------------CREACION DE LOS INSERTS------------------------------------------

-- Inserts
-- GASES
INSERT INTO Refrigerante (nombre, CO2eq, clase, grupo)
VALUES 
    ('R22', 1810.00, 'HCFC', 'A1'),
    ('R134a', 1430.00, 'HFC', 'A1'),
    ('R410A', 2088.00, 'HFC', 'A1'),
    ('R32', 675.00, 'HFC', 'A2L'),
    ('R404A', 3922.00, 'HFC', 'A1'),
    ('R407C', 1774.00, 'HFC', 'A1'),
    ('R1234yf', 4.00, 'HFO', 'A2L'),
    ('R290', 3.00, 'HC', 'A3'),
    ('R600a', 3.00, 'HC', 'A3'),
    ('R744', 1.00, 'CO2', 'A1'); -- R744 es CO2
	
--TIPO EQUIPO
INSERT INTO Tipo_equipo (tipo_equipo) VALUES
    ('PARTIDA DOMESTICO'),
    ('PARTIDA INDUSTRIAL'),
    ('COMPACTA DOMESTICO'),
    ('COMPACTA INDUSTRIAL');

--CATEGORIA PROFESIONAL
INSERT INTO Categoria_profesional (categoria_profesional) VALUES
    ('OFICIAL_PRIMERA'),
    ('OFICIAL_SEGUNDA'),
    ('OFICIAL_TERCERA'),
    ('TECNICO'),
    ('INGENIERO');

-- CLIENTES
INSERT INTO Cliente (cif, nombre, direccion_facturacion) VALUES
    ('A12345678', 'Grupo Kinepolis', 'Calle Gran Vía 50, Madrid'),
    ('B23456789', 'Grupo Sanitas Clínicas', 'Avenida de la Salud 15, Barcelona'),
    ('C34567890', 'Grupo Fitness Pro', 'Calle del Deporte 27, Valencia'),
    ('D45678901', 'Grupo Inditex Textiles', 'Polígono Industrial Norte 12, La Coruña'),
    ('E56789012', 'Clinimed Grupo Hospitalario', 'Paseo de la Esperanza 7, Bilbao'),
    ('F67890123', 'CineWorld España', 'Calle de los Directores 56, Madrid'),
    ('G78901234', 'Grupo GymTime', 'Avenida de la Fuerza 23, Zaragoza'),
    ('H89012345', 'Fábricas Actiu Grupo Industrial', 'Polígono Sur 88, Castalla'),
    ('I90123456', 'Grupo FisioSalud', 'Calle Río Ebro 34, Sevilla'),
    ('J01234567', 'CineGlobal', 'Plaza de los Espectadores 10, Barcelona');

--OPERARIOS
INSERT INTO Operario (dni, nombre, apellido1, apellido2, email, password, categoria_profesional_id) VALUES
    ('12345678A', 'Carlos', 'Martinez', 'Lopez', 'carlos.martinez@refrigerante.com', 
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1),
    ('23456789B', 'Ana', 'Gomez', 'Garcia', 'ana.gomez@refrigerante.com',
     '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 2),
    ('34567890C', 'Luis', 'Hernandez', 'Sanchez', 'luis.hernandez@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 3),
    ('45678901D', 'Maria', 'Diaz', NULL, 'maria.diaz@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1),
    ('56789012E', 'Jose', 'Perez', 'Martinez', 'jose.perez@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 2),
    ('67890123F', 'Laura', 'Moreno', 'Lopez', 'laura.moreno@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 3),
    ('78901234G', 'Javier', 'Santos', 'Jimenez', 'javier.santos@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1),
    ('89012345H', 'Raquel', 'Romero', 'Cruz', 'raquel.romero@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 2),
    ('90123456I', 'David', 'Navarro', NULL, 'david.navarro@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 3),
    ('90123456H', 'Julian', 'Lopez', 'Navarro', 'julian.lopez@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 4),
    ('52764295H', 'Elver', 'Galarga', 'Astur', 'elver.galarga@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 5),
    ('01234567J', 'Sandra', 'Ortega', 'Marin', 'sandra.ortega@refrigerante.com',
    '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4', 1);

--INSTALACIONES
INSERT INTO Instalacion (cliente_id, nombre, direccion, horario) VALUES
    (1, 'Kinepolis Madrid - La Moraleja', 'Calle Moraleja 120, Madrid', '10:00 - 23:00'),
    (1, 'Kinepolis Valencia - Aqua', 'Avenida del Puerto 23, Valencia', '10:00 - 23:00'),
    (2, 'Clínica Sanitas Diagonal', 'Calle Diagonal 50, Barcelona', '08:00 - 20:00'),
    (2, 'Clínica Sanitas Central', 'Calle Salud 15, Madrid', '08:00 - 20:00'),
    (3, 'Fitness Pro Sevilla', 'Calle Deporte 32, Sevilla', '06:00 - 22:00'),
    (3, 'Fitness Pro Madrid', 'Avenida Atlética 10, Madrid', '06:00 - 22:00'),
    (4, 'Inditex Fábrica Principal', 'Polígono Norte 5, La Coruña', '07:00 - 19:00'),
    (5, 'Clinimed Bilbao', 'Calle Hospitalaria 12, Bilbao', '08:00 - 18:00'),
    (6, 'CineWorld Madrid', 'Calle Cinema 42, Madrid', '10:00 - 01:00'),
    (7, 'GymTime Zaragoza', 'Avenida Fitness 99, Zaragoza', '05:30 - 23:30'),
    (1, 'Kinepolis Barcelona - Diagonal Mar', 'Avenida Diagonal Mar 45, Barcelona', '10:00 - 23:00'),
    (1, 'Kinepolis Alicante - Plaza Mar', 'Avenida de la Estación 22, Alicante', '10:00 - 23:00'),
    (2, 'Clínica Sanitas Valencia', 'Calle Salud 78, Valencia', '08:00 - 20:00'),
    (2, 'Clínica Sanitas Sevilla', 'Avenida de Andalucía 30, Sevilla', '08:00 - 20:00'),
    (3, 'Fitness Pro Barcelona', 'Calle del Ejercicio 15, Barcelona', '06:00 - 22:00'),
    (3, 'Fitness Pro Málaga', 'Avenida del Deporte 55, Málaga', '06:00 - 22:00'),
    (4, 'Inditex Fábrica Este', 'Polígono Industrial Este 22, Zaragoza', '07:00 - 19:00'),
    (4, 'Inditex Fábrica Sur', 'Polígono Sur 55, Alicante', '07:00 - 19:00');

-- EQUIPOS
INSERT INTO Equipo (instalacion_id, refrigerante_id, tipo_equipo_id, marca, modelo, carga_refrigerante) VALUES
    (1, 1, 1, 'Daikin', 'FTXM35M', 1.200),
    (2, 2, 2, 'Mitsubishi Electric', 'MSZ-HR50VF', 5.500),
    (3, 3, 3, 'LG', 'S3-Q12JA3BA', 1.100),
    (4, 4, 4, 'Samsung', 'AR12TXHQASINEU', 5.800),
    (5, 5, 1, 'Panasonic', 'CS-Z25VKEW', 1.300),
    (6, 6, 2, 'Fujitsu', 'ASY35UI-LT', 6.200),
    (7, 7, 3, 'Hisense', 'CA35YR01G', 1.200),
    (8, 8, 4, 'Daikin', 'ATXN25M5V1B', 5.850),
    (9, 9, 1, 'Mitsubishi Electric', 'MSZ-SF25VE3', 1.050),
    (10, 10, 2, 'LG', 'S12EQ.NS3', 6.300),
    (1, 1, 3, 'Samsung', 'AR09TXEAAWKNEU', 1.100),
    (2, 2, 4, 'Panasonic', 'CS-TZ20WKEW', 5.900),
    (3, 3, 1, 'Daikin', 'FTX20J3V1B', 1.400),
    (4, 4, 2, 'Mitsubishi Electric', 'MSZ-AP50VGK', 6.500),
    (5, 5, 3, 'Fujitsu', 'ASY35UI-KP', 1.350),
    (6, 6, 4, 'Hisense', 'AUC-18HR4SX', 5.750),
    (7, 7, 1, 'Samsung', 'AR12RXHPEWKN', 1.250),
    (8, 8, 2, 'Panasonic', 'CS-XE12TKF', 6.450),
    (9, 9, 3, 'LG', 'S09ET.NS3', 1.150),
    (10, 10, 4, 'Daikin', 'FTXM25N', 5.600);

--OPERACIONES DE CARGA
INSERT INTO Operacion_carga (operario_id, equipo_id, fecha_operacion, descripcion, refrigerante_manipulado, recuperacion) VALUES
    (2, 6, '2023-11-01', 'Inspección de rutina, ajuste de carga.', 0.750, 0),
    (3, 9, '2023-11-03', 'Extracción de refrigerante por fuga.', 2.100, 1),
    (4, 4, '2023-11-05', 'Carga inicial de refrigerante para equipo nuevo.', 3.000, 0),
    (5, 2, '2023-11-07', 'Ajuste de carga de refrigerante en sistema.', 0.500, 0),
    (6, 7, '2023-11-09', 'Extracción de refrigerante en revisión de emergencia.', 0.800, 1),
    (7, 1, '2023-11-11', 'Carga parcial de refrigerante tras revisión.', 1.050, 0),
    (8, 5, '2023-11-13', 'Extracción de refrigerante por equipo dado de baja.', 4.200, 1),
    (9, 10, '2023-11-14', 'Mantenimiento y carga de refrigerante en sistema de enfriamiento.', 1.500, 0),
    (10, 8, '2023-11-15', 'Extracción de refrigerante tras reparación del compresor.', 2.300, 1);




