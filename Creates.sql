create  database hotel;
use hotel;

CREATE TABLE `tipohabitacion` (
  `id` int NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `estadohabitacion` (
  `id` int NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `estado_reserva` (
  `id` int NOT NULL,
  `descripcion` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `email` varchar(50) DEFAULT NULL,
  `dni` int NOT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `habitaciones` (
  `id` int NOT NULL AUTO_INCREMENT,
  `numero` int DEFAULT NULL,
  `tipo` int DEFAULT NULL,
  `precioPorNoche` decimal(10,2) NOT NULL,
  `estado` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `numero` (`numero`),
  FOREIGN KEY (`tipo`) REFERENCES `tipohabitacion` (`id`),
  FOREIGN KEY (`estado`) REFERENCES `estadohabitacion` (`id`)
);

CREATE TABLE `reservas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idCliente` int DEFAULT NULL,
  `idHabitacion` int DEFAULT NULL,
  `FechaInicio` date NOT NULL,
  `FechaFinalizacion` date NOT NULL,
  `idEstadoReserva` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idCliente` (`idCliente`),
  KEY `idHabitacion` (`idHabitacion`),
  KEY `idEstadoReserva` (`idEstadoReserva`),
  CONSTRAINT `reservas_ibfk_1` FOREIGN KEY (`idCliente`) REFERENCES `clientes` (`id`),
  CONSTRAINT `reservas_ibfk_2` FOREIGN KEY (`idHabitacion`) REFERENCES `habitaciones` (`id`),
  CONSTRAINT `reservas_ibfk_3` FOREIGN KEY (`idEstadoReserva`) REFERENCES `estado_reserva` (`id`)
);

CREATE TABLE `factura` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idCliente` int DEFAULT NULL,
  `idReserva` int DEFAULT NULL,
  `MontoTotal` decimal(10,2) DEFAULT NULL,
  `fechaEmision` date NOT NULL,
  PRIMARY KEY (`id`),
  KEY `idCliente` (`idCliente`),
  KEY `idReserva` (`idReserva`),
  CONSTRAINT `factura_ibfk_1` FOREIGN KEY (`idCliente`) REFERENCES `clientes` (`id`),
  CONSTRAINT `factura_ibfk_2` FOREIGN KEY (`idReserva`) REFERENCES `reservas` (`id`)
);