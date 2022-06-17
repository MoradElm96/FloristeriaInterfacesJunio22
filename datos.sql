GRANT ALL PRIVILEGES ON *.* TO 'user'@'localhost' IDENTIFIED BY 'password';
GRANT ALL PRIVILEGES ON *.* TO 'user'@'%' IDENTIFIED BY 'password';
CREATE DATABASE IF NOT EXISTS dweb; 

USE dweb;

CREATE TABLE `flores` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `foto` varchar(100) NOT NULL,
  `precio` float(4,2) NOT NULL,
  `codigo_color` int(3) NOT NULL,
  `estacion` varchar(50) NOT NULL);

ALTER TABLE `flores` ADD PRIMARY KEY (`codigo`);

CREATE TABLE `pedidos` (
  `codigo_pedido` int(11) NOT NULL AUTO_INCREMENT,
  `codigo_flor` int(11) NOT NULL,
  `codigo_cliente` varchar(100) NOT NULL,
  `fecha` datetime NOT NULL,
  `cantidad` int(3) NOT NULL,
 PRIMARY KEY (`codigo_pedido`));

INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (1, 'Margarita (Bellis perennis)','foto1.jpg',12.30,1,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (2, 'Violeta','foto2.jpg',12.30,1,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (3, 'Jazmin','foto3.jpg',12.30,6,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (4, 'Rosa','foto4.jpg',12.30,5,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (5, 'Clavel','foto5.jpg',12.30,3,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (6, 'Lila','foto6.jpg',12.30,2,'Verano');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (7, 'Petunia','foto7.jpg',12.30,1,'Primavera');


INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (11, 'Margarita (Bellis perennis)','foto1.jpg',12.30,2,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (12, 'Violeta','foto2.jpg',12.30,2,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (13, 'Jazmin','foto3.jpg',12.30,1,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (14, 'Rosa','foto4.jpg',12.30,1,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (15, 'Clavel','foto5.jpg',12.30,2,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (16, 'Lila','foto6.jpg',12.30,6,'Verano');


INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (21, 'Margarita (Bellis perennis)','foto1.jpg',12.30,3,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (24, 'Rosa','foto4.jpg',12.30,1,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (25, 'Clavel','foto5.jpg',12.30,2,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (26, 'Lila','foto6.jpg',12.30,3,'Verano');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (27, 'Petunia','foto7.jpg',12.30,4,'Primavera');


INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (31, 'Margarita (Bellis perennis)','foto1.jpg',12.30,4,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (32, 'Violeta','foto2.jpg',12.30,4,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (35, 'Clavel','foto5.jpg',12.30,4,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (36, 'Lila','foto6.jpg',12.30,1,'Verano');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (37, 'Petunia','foto7.jpg',12.30,5,'Primavera');


INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (41, 'Margarita (Bellis perennis)','foto1.jpg',12.30,2,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (42, 'Violeta','foto2.jpg',12.30,5,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (43, 'Jazmin','foto3.jpg',12.30,1,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (45, 'Clavel','foto5.jpg',12.30,5,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (46, 'Lila','foto6.jpg',12.30,5,'Verano');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (47, 'Petunia','foto7.jpg',12.30,5,'Primavera');


INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (53, 'Jazmin','foto3.jpg',12.30,2,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (54, 'Rosa','foto4.jpg',12.30,6,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (55, 'Clavel','foto5.jpg',12.30,3,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (56, 'Lila','foto6.jpg',12.30,6,'Verano');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (57, 'Petunia','foto7.jpg',12.30,4,'Primavera');


INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (61, 'Margarita (Bellis perennis)','foto1.jpg',12.30,7,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (62, 'Violeta','foto2.jpg',12.30,3,'Otoño');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (63, 'Jazmin','foto3.jpg',12.30,2,'Primavera');
INSERT INTO `flores` (`codigo`, `nombre`, `foto`,`precio`,`codigo_color`,`estacion`) 
VALUES (64, 'Rosa','foto4.jpg',12.30,1,'Otoño');
