/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.5.5-10.3.16-MariaDB : Database - librodiario
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`librodiario` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */;

USE `librodiario`;

/*Table structure for table `asiento` */

DROP TABLE IF EXISTS `asiento`;

CREATE TABLE `asiento` (
  `id_asiento` int(11) NOT NULL AUTO_INCREMENT,
  `numero_asiento` int(11) NOT NULL,
  `fecha_asiento` date NOT NULL,
  `descr_asiento` varchar(40) COLLATE utf8_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`id_asiento`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

/*Data for the table `asiento` */

insert  into `asiento`(`id_asiento`,`numero_asiento`,`fecha_asiento`,`descr_asiento`) values (1,1,'2009-06-01','Inicio de Actividad'),(2,2,'2009-06-02','Deposito en el Banco');

/*Table structure for table `cuentas` */

DROP TABLE IF EXISTS `cuentas`;

CREATE TABLE `cuentas` (
  `id_cuenta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_cuenta` varchar(40) COLLATE utf8_spanish_ci NOT NULL,
  `tipocuenta_id` int(11) NOT NULL,
  PRIMARY KEY (`id_cuenta`),
  KEY `tipocuenta_id` (`tipocuenta_id`),
  CONSTRAINT `tipocuenta_id` FOREIGN KEY (`tipocuenta_id`) REFERENCES `tipocuenta` (`id_tipocuenta`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

/*Data for the table `cuentas` */

insert  into `cuentas`(`id_cuenta`,`nombre_cuenta`,`tipocuenta_id`) values (1,'Caja',1),(2,'Banco Rio C/C',1),(3,'Deudores por Venta',1),(4,'Documentos a Cobrar',1),(5,'Mercaderia',1),(6,'Rodados',1),(7,'Inmuebles',1),(8,'Instalaciones',1),(9,'Muebles y Utiles',1),(10,'Equipos de Computacion',1),(11,'Proveedores',2),(12,'Documentos a Pagar',2),(13,'Sueldos y Jornales a Pagar',2),(14,'Impuestos a Pagar',2),(15,'Capital Social',3),(16,'Resultados del Ejercicio',3),(17,'Resultados Acumulados de Ejerc',3),(18,'Ventas de Mercaderia',4),(19,'Ventas de Servicios',4),(20,'Intereses Ganados',4),(21,'Costo de Mercaderia Vendida',5),(22,'Costo de Servicio Prestado',5),(23,'Luz, Gas y Telefono',5),(24,'Servicios Publicos',5),(25,'Libreria y Papeleria',5),(26,'Fletes y Acarreos',5),(27,'Sueldos y Jornales',5),(28,'Impuestos y Tasas',5),(29,'Alquileres Perdidos',5),(30,'Gastos Generales',5),(31,'Gastos y Comisiones Bancarias',5),(32,'Gastos de Limpieza',5),(33,'Intereses Perdidos',5),(34,'Mermas y Roturas',5),(35,'Perdidas por Siniestros',5),(36,'Cheques Diferidos a Pagar',2);

/*Table structure for table `movimiento` */

DROP TABLE IF EXISTS `movimiento`;

CREATE TABLE `movimiento` (
  `id_movimiento` int(11) NOT NULL AUTO_INCREMENT,
  `asiento_id` int(11) NOT NULL,
  `cuenta_id` int(11) NOT NULL,
  `valor` float NOT NULL,
  `debeohaber` tinyint(1) NOT NULL,
  PRIMARY KEY (`id_movimiento`),
  KEY `cuenta_id` (`cuenta_id`),
  KEY `asiento_id` (`asiento_id`),
  CONSTRAINT `asiento_id` FOREIGN KEY (`asiento_id`) REFERENCES `asiento` (`id_asiento`),
  CONSTRAINT `cuenta_id` FOREIGN KEY (`cuenta_id`) REFERENCES `cuentas` (`id_cuenta`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

/*Data for the table `movimiento` */

insert  into `movimiento`(`id_movimiento`,`asiento_id`,`cuenta_id`,`valor`,`debeohaber`) values (1,1,1,315000,1),(2,1,3,236250,1),(3,1,5,157500,1),(4,1,9,157500,1),(5,1,8,472500,1),(6,1,6,236250,1),(7,1,15,1575000,0),(8,2,2,78750,1),(9,2,1,78750,0);

/*Table structure for table `tipocuenta` */

DROP TABLE IF EXISTS `tipocuenta`;

CREATE TABLE `tipocuenta` (
  `id_tipocuenta` int(11) NOT NULL AUTO_INCREMENT,
  `descr_tipocuenta` varchar(30) COLLATE utf8_spanish_ci NOT NULL,
  PRIMARY KEY (`id_tipocuenta`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;

/*Data for the table `tipocuenta` */

insert  into `tipocuenta`(`id_tipocuenta`,`descr_tipocuenta`) values (1,'Activo'),(2,'Pasivo'),(3,'Patrimonio Neto'),(4,'Resultado Positivo'),(5,'Resultado Negativo');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
