-- MySQL dump 10.14  Distrib 5.5.65-MariaDB, for Linux (x86_64)
--
-- Host: localhost    Database: sistema_telediagnostico
-- ------------------------------------------------------
-- Server version	5.5.65-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary table structure for view `Pacientes`
--

DROP TABLE IF EXISTS `Pacientes`;
/*!50001 DROP VIEW IF EXISTS `Pacientes`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8;
/*!50001 CREATE TABLE `Pacientes` (
  `Cedula` tinyint NOT NULL,
  `Nombre Completo` tinyint NOT NULL,
  `Fecha de Nacimiento` tinyint NOT NULL,
  `Telefono` tinyint NOT NULL,
  `Email` tinyint NOT NULL,
  `Direccion` tinyint NOT NULL,
  `Nucleo Familiar` tinyint NOT NULL,
  `Antecedentes Familiares` tinyint NOT NULL,
  `Antecedentes Laborales` tinyint NOT NULL
) ENGINE=MyISAM */;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `atienden`
--

DROP TABLE IF EXISTS `atienden`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `atienden` (
  `idConsulta` bigint(20) unsigned NOT NULL,
  `ciMedico` int(8) unsigned DEFAULT NULL,
  `desarrollo` varchar(1024) NOT NULL,
  `medicacion` varchar(512) DEFAULT NULL,
  PRIMARY KEY (`idConsulta`),
  KEY `ciMedico` (`ciMedico`),
  CONSTRAINT `atienden_ibfk_1` FOREIGN KEY (`idConsulta`) REFERENCES `consultas` (`id`),
  CONSTRAINT `atienden_ibfk_2` FOREIGN KEY (`ciMedico`) REFERENCES `personas` (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `atienden`
--

LOCK TABLES `atienden` WRITE;
/*!40000 ALTER TABLE `atienden` DISABLE KEYS */;
/*!40000 ALTER TABLE `atienden` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `chats`
--

DROP TABLE IF EXISTS `chats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `chats` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `idConsulta` bigint(20) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idConsulta` (`idConsulta`),
  CONSTRAINT `chats_ibfk_1` FOREIGN KEY (`idConsulta`) REFERENCES `consultas` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `chats`
--

LOCK TABLES `chats` WRITE;
/*!40000 ALTER TABLE `chats` DISABLE KEYS */;
INSERT INTO `chats` (`id`, `fechaHora`, `idConsulta`) VALUES (1,'2020-09-03 19:26:57',1),(2,'2020-09-03 19:26:57',2),(3,'2020-09-03 19:26:57',3),(4,'2020-09-03 19:26:57',4),(5,'2020-09-03 19:26:58',5),(6,'2020-09-03 19:26:58',6),(7,'2020-09-03 19:26:58',7),(8,'2020-09-03 19:26:58',8),(9,'2020-09-03 19:26:58',9);
/*!40000 ALTER TABLE `chats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultas`
--

DROP TABLE IF EXISTS `consultas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consultas` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `idSucursal` tinyint(3) unsigned NOT NULL,
  `ciPaciente` int(8) unsigned NOT NULL,
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `tipo` enum('A','M') NOT NULL DEFAULT 'A',
  PRIMARY KEY (`id`,`tipo`),
  KEY `ciPaciente` (`ciPaciente`),
  KEY `idSucursal` (`idSucursal`),
  CONSTRAINT `consultas_ibfk_1` FOREIGN KEY (`ciPaciente`) REFERENCES `personas` (`ci`),
  CONSTRAINT `consultas_ibfk_2` FOREIGN KEY (`idSucursal`) REFERENCES `sucursales` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultas`
--

LOCK TABLES `consultas` WRITE;
/*!40000 ALTER TABLE `consultas` DISABLE KEYS */;
INSERT INTO `consultas` (`id`, `idSucursal`, `ciPaciente`, `fechaHora`, `tipo`) VALUES (1,1,11111111,'2020-09-03 19:26:57','A'),(2,1,22222222,'2020-09-03 19:26:57','A'),(3,1,33333333,'2020-09-03 19:26:57','A'),(4,1,44444444,'2020-09-03 19:26:57','A'),(5,1,55555555,'2020-09-03 19:26:57','A'),(6,1,66666666,'2020-09-03 19:26:57','A'),(7,1,77777777,'2020-09-03 19:26:57','A'),(8,1,88888888,'2020-09-03 19:26:57','A'),(9,1,99999999,'2020-09-03 19:26:57','A');
/*!40000 ALTER TABLE `consultas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `diagnostica`
--

DROP TABLE IF EXISTS `diagnostica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `diagnostica` (
  `idConsulta` bigint(20) unsigned NOT NULL DEFAULT '0',
  `idEnfermedad` smallint(5) unsigned NOT NULL DEFAULT '0',
  `tipoConsulta` enum('Autoconsulta','Médica') NOT NULL DEFAULT 'Autoconsulta',
  PRIMARY KEY (`idConsulta`,`idEnfermedad`,`tipoConsulta`),
  KEY `idConsulta` (`idConsulta`,`tipoConsulta`),
  KEY `idEnfermedad` (`idEnfermedad`),
  CONSTRAINT `diagnostica_ibfk_1` FOREIGN KEY (`idConsulta`, `tipoConsulta`) REFERENCES `consultas` (`id`, `tipo`),
  CONSTRAINT `diagnostica_ibfk_2` FOREIGN KEY (`idEnfermedad`) REFERENCES `enfermedades` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `diagnostica`
--

LOCK TABLES `diagnostica` WRITE;
/*!40000 ALTER TABLE `diagnostica` DISABLE KEYS */;
/*!40000 ALTER TABLE `diagnostica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `direcciones`
--

DROP TABLE IF EXISTS `direcciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `direcciones` (
  `id` mediumint(8) unsigned NOT NULL AUTO_INCREMENT,
  `calle` varchar(50) NOT NULL,
  `numero` smallint(4) unsigned NOT NULL,
  `localidad` varchar(50) NOT NULL,
  `departamento` enum('Montevideo','Canelones','San_Jose','Colonia','Maldonado','Rocha','Lavalleja','Florida','Flores','Soriano','Rio_Negro','Durazno','Treinta_y_Tres','Cerro_Largo','Tacuarembó','Paysandú','Salto','Rivera','Artigas') NOT NULL,
  `detalle` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `direcciones`
--

LOCK TABLES `direcciones` WRITE;
/*!40000 ALTER TABLE `direcciones` DISABLE KEYS */;
INSERT INTO `direcciones` (`id`, `calle`, `numero`, `localidad`, `departamento`, `detalle`) VALUES (1,'8 de Octubre',4589,'Montevideo','Montevideo',''),(2,'Boulevar Artigas',3172,'Montevideo','Montevideo',''),(3,'José Belloni',1034,'Montevideo','Montevideo',''),(4,'La Paz',1380,'Montevideo','Montevideo',''),(5,'Galicia',1280,'Montevideo','Montevideo','bis'),(6,'Cerro Largo',1180,'Montevideo','Montevideo',''),(7,'Paysandú',1080,'Montevideo','Montevideo',''),(8,'Avenida Uruguay',1081,'Montevideo','Montevideo','bis'),(9,'Mercedes',1181,'Montevideo','Montevideo',''),(10,'Colonia',1281,'Montevideo','Montevideo','bis'),(11,'Francisco Lavandeira',456,'Canelones','Canelones',''),(12,'Florencio Sanches',564,'Canelones','Canelones','bis'),(13,'Zorrilla de San MartÃ­n',654,'Canelones','Canelones',''),(14,'Baltasar Brum',645,'Canelones','Canelones',''),(15,'Treinta y Tres',334,'Canelones','Canelones',''),(16,'Colon',433,'Canelones','Canelones','bis'),(17,'Camino Fuster',322,'Canelones','Canelones',''),(18,'Ariel',323,'Canelones','Canelones',''),(19,'Simon del Pino',367,'Canelones','Canelones','bis'),(20,'Rocha',1020,'Santa LucÃ­a','Canelones',''),(21,'29 de Diciembre',1021,'Santa LucÃ­a','Canelones',''),(22,'ConstituciÃ³n',1022,'Santa LucÃ­a','Canelones',''),(23,'Francia',1023,'Santa LucÃ­a','Canelones',''),(24,'Chile',1024,'Santa LucÃ­a','Canelones',''),(25,'18 de Julio',1025,'Santa LucÃ­a','Canelones',''),(26,'Brasil',1026,'Santa LucÃ­a','Canelones',''),(27,'Amsterdam',1027,'Santa LucÃ­a','Canelones',''),(28,'Colombia',1028,'Santa LucÃ­a','Canelones',''),(29,'Bolivia',1029,'Santa LucÃ­a','Canelones',''),(30,'Sanrandá',892,'Trinidad','Flores',''),(31,'Florencio Sanchez',882,'Trinidad','Flores',''),(32,'Uruguay',883,'Montevideo','',''),(33,'Carlos MarÃ­a Ramirez',884,'Trinidad','Flores',''),(34,'Manuel Irazabal',885,'Trinidad','Flores',''),(35,'José Gonzalez',886,'Trinidad','Flores',''),(36,'Avenida Brasil',887,'Trinidad','Flores',''),(37,'General Leandro Gomez',888,'Trinidad','Flores',''),(38,'25 de Agosto',889,'Trinidad','Flores',''),(39,'Santísima Trinidad',895,'Trinidad','Flores',''),(40,'12 de Octubre',1348,'Young','',''),(41,'19 de Abril',1340,'Young','',''),(42,'Asencio',1341,'Young','',''),(43,'Piedra Alta',1342,'Young','',''),(44,'Wilson Ferreira Aldunate',1343,'Young','',''),(45,'12 de Octubre',1344,'Young','',''),(46,'Soriano',1345,'Young','',''),(47,'Colonia',1346,'Young','',''),(48,'Hervidero',1347,'Young','',''),(49,'SanaquÃ©',1348,'Young','',''),(50,'Melo',1349,'Young','',''),(51,'Sarandí',1350,'Ciudad Vieja','Montevideo',''),(52,'Av Sayago',7896,'Sayago','Montevideo',''),(53,'Eliseo Marzoil',8956,'Rocha','Rocha',''),(54,'Amarillo',4529,'Cerro del Estado','Rocha',''),(55,'Camino Al Pozo',6745,'Villa Felicidad','Canelones',''),(56,'Jose Ignacio',6788,'Inve','Maldonado',''),(57,'Cruz Sur',7864,'Parque Pinares 2','Maldonado',''),(58,'Ramon Ortíz',5667,'Barrio María Isabel','',''),(59,'Av. Salto',5367,'Paysandú','Paysandú',''),(60,'Palleja',5345,'Villa del Carmen','Durazno',''),(61,'1 de Marzo',5045,'Villa del Carmen','Durazno',''),(62,'Tijereta',5944,'Punta Colorada','Maldonado',''),(63,'Gowland',6845,'La Teja','Montevideo',''),(64,'Camino Ariel',6667,'Sayago','Montevideo',''),(65,'Tala',2349,'Villa Maria','',''),(66,'Treinta y Tres',7678,'San José','',''),(67,'Av Italia',6745,'Hipódromo de San José','',''),(68,'Botavara',5245,'La Paloma','Rocha',''),(69,'Anaconda',4356,'La Paloma','Rocha',''),(70,'Independencia',8745,'Florida','Florida',''),(71,'Dayman',6775,'Centro','',''),(72,'Lezica',5678,'Colón','Montevideo',''),(73,'Sepe',6734,'Real de San Carlos','',''),(74,'Elena Barros',2346,'Dolores','',''),(75,'Rincon',7745,'Fray Bentos','',''),(76,'Rincon',7789,'Fray Bentos','','');
/*!40000 ALTER TABLE `direcciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfermedades`
--

DROP TABLE IF EXISTS `enfermedades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enfermedades` (
  `id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(512) DEFAULT NULL,
  `urgencia` enum('Baja','Media','Alta') NOT NULL,
  `ENABLED` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfermedades`
--

LOCK TABLES `enfermedades` WRITE;
/*!40000 ALTER TABLE `enfermedades` DISABLE KEYS */;
INSERT INTO `enfermedades` (`id`, `nombre`, `descripcion`, `urgencia`, `ENABLED`) VALUES (1,'COVID-19','Default','Media',1),(2,'Gripe','Default','Baja',1),(3,'Artrosis','Default','Baja',1),(4,'Diabetes','Default','Alta',1),(5,'ENF5','Default','Media',1),(6,'ENF6','Default','Baja',1),(7,'ENF7','Default','Baja',1),(8,'ENF8','Default','Alta',1),(9,'ENF9','Default','Media',1),(10,'ENF10','Default','Baja',1),(11,'ENF11','Default','Media',1),(12,'ENF12','Default','Baja',1),(13,'ENF13','Default','Baja',1),(14,'ENF14','Default','Alta',1),(15,'ENF15','Default','Media',1),(16,'ENF16','Default','Baja',1),(17,'ENF17','Default','Baja',1),(18,'ENF18','Default','Alta',1),(19,'ENF19','Default','Media',1),(20,'ENF20','Default','Baja',1);
/*!40000 ALTER TABLE `enfermedades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfermedades_sintomas`
--

DROP TABLE IF EXISTS `enfermedades_sintomas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enfermedades_sintomas` (
  `idEnfermedad` smallint(5) unsigned NOT NULL DEFAULT '0',
  `idSintoma` smallint(5) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`idEnfermedad`,`idSintoma`),
  KEY `idSintoma` (`idSintoma`),
  CONSTRAINT `enfermedades_sintomas_ibfk_1` FOREIGN KEY (`idEnfermedad`) REFERENCES `enfermedades` (`id`),
  CONSTRAINT `enfermedades_sintomas_ibfk_2` FOREIGN KEY (`idSintoma`) REFERENCES `sintomas` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfermedades_sintomas`
--

LOCK TABLES `enfermedades_sintomas` WRITE;
/*!40000 ALTER TABLE `enfermedades_sintomas` DISABLE KEYS */;
INSERT INTO `enfermedades_sintomas` (`idEnfermedad`, `idSintoma`) VALUES (1,1),(1,2),(1,3),(1,4),(1,5),(1,19),(2,6),(2,8),(3,7),(3,9),(3,10),(11,11),(12,12),(13,13),(14,14),(15,15),(16,16),(17,17),(18,18);
/*!40000 ALTER TABLE `enfermedades_sintomas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidades`
--

DROP TABLE IF EXISTS `especialidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `especialidades` (
  `id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidades`
--

LOCK TABLES `especialidades` WRITE;
/*!40000 ALTER TABLE `especialidades` DISABLE KEYS */;
INSERT INTO `especialidades` (`id`, `nombre`) VALUES (1,'Alerglogía'),(2,'Cardiología'),(3,'Dermatología'),(4,'Ecografía'),(5,'Endocrinología'),(6,'Gastroenterología'),(7,'Ginecología Oncológica'),(8,'Ginecología y Obstetricia'),(9,'Medicina Física y Rehabilitación'),(10,'Medicina General'),(11,'Neumología'),(12,'Neurocirugía'),(13,'Neurología'),(14,'Nutrición'),(15,'Odontología'),(16,'Oftamología'),(17,'Pediatría'),(18,'Psicología'),(19,'Radiología'),(20,'Reumatología'),(21,'Urología');
/*!40000 ALTER TABLE `especialidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicos_especialidades`
--

DROP TABLE IF EXISTS `medicos_especialidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medicos_especialidades` (
  `ciMedico` int(8) unsigned NOT NULL DEFAULT '0',
  `idEspecialidad` smallint(5) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`ciMedico`,`idEspecialidad`),
  KEY `idEspecialidad` (`idEspecialidad`),
  CONSTRAINT `medicos_especialidades_ibfk_1` FOREIGN KEY (`ciMedico`) REFERENCES `personas` (`ci`),
  CONSTRAINT `medicos_especialidades_ibfk_2` FOREIGN KEY (`idEspecialidad`) REFERENCES `especialidades` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicos_especialidades`
--

LOCK TABLES `medicos_especialidades` WRITE;
/*!40000 ALTER TABLE `medicos_especialidades` DISABLE KEYS */;
INSERT INTO `medicos_especialidades` (`ciMedico`, `idEspecialidad`) VALUES (12121212,3),(12761197,2),(12761197,13),(13131313,3),(21170323,10),(21170323,16),(25816822,15),(25816822,17),(39763392,5),(40428036,7),(40428036,8),(40428036,10),(52539869,10),(52539869,11),(63841116,10),(63841116,21);
/*!40000 ALTER TABLE `medicos_especialidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mensajes`
--

DROP TABLE IF EXISTS `mensajes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mensajes` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `idChat` bigint(20) unsigned DEFAULT NULL,
  `ciPersona` int(8) unsigned DEFAULT NULL,
  `fechaHora` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `mensaje` varchar(1024) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idChat` (`idChat`),
  KEY `ciPersona` (`ciPersona`),
  CONSTRAINT `mensajes_ibfk_1` FOREIGN KEY (`idChat`) REFERENCES `chats` (`id`),
  CONSTRAINT `mensajes_ibfk_2` FOREIGN KEY (`ciPersona`) REFERENCES `personas` (`ci`)
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mensajes`
--

LOCK TABLES `mensajes` WRITE;
/*!40000 ALTER TABLE `mensajes` DISABLE KEYS */;
INSERT INTO `mensajes` (`id`, `idChat`, `ciPersona`, `fechaHora`, `mensaje`) VALUES (1,1,11111111,'2020-09-03 19:26:57','P1Msg1'),(2,1,11111111,'2020-09-03 19:26:57','P1Msg2'),(3,1,12761197,'2020-09-03 19:26:57','M1Msg1'),(4,1,12761197,'2020-09-03 19:26:57','M1Msg2'),(5,1,11111111,'2020-09-03 19:26:57','P1Msg3'),(6,2,22222222,'2020-09-03 19:26:57','CHAT2 P2Msg1'),(7,2,22222222,'2020-09-03 19:26:57','CHAT2 P2Msg2'),(8,2,40428036,'2020-09-03 19:26:57','CHAT2 M2Msg1'),(9,2,40428036,'2020-09-03 19:26:57','CHAT2 M2Msg2'),(10,2,22222222,'2020-09-03 19:26:57','CHAT2 P2Msg3'),(11,2,33333333,'2020-09-03 19:26:57','CHAT2 P3Msg1'),(12,2,33333333,'2020-09-03 19:26:57','CHAT2 P3Msg2'),(13,2,21170323,'2020-09-03 19:26:57','CHAT2 M3Msg1'),(14,2,21170323,'2020-09-03 19:26:57','CHAT2 M3Msg2'),(15,2,33333333,'2020-09-03 19:26:57','CHAT2 P3Msg3'),(16,2,44444444,'2020-09-03 19:26:57','CHAT2 P4Msg1'),(17,2,44444444,'2020-09-03 19:26:57','CHAT2 P4Msg2'),(18,2,39763392,'2020-09-03 19:26:57','CHAT2 M4Msg1'),(19,2,39763392,'2020-09-03 19:26:58','CHAT2 M4Msg2'),(20,2,44444444,'2020-09-03 19:26:58','CHAT2 P4Msg3'),(21,2,55555555,'2020-09-03 19:26:58','CHAT2 P5Msg1'),(22,2,55555555,'2020-09-03 19:26:58','CHAT2 P5Msg2'),(23,2,25816822,'2020-09-03 19:26:58','CHAT2 M5Msg1'),(24,2,25816822,'2020-09-03 19:26:58','CHAT2 M5Msg2'),(25,2,55555555,'2020-09-03 19:26:58','CHAT2 P5Msg3'),(26,2,66666666,'2020-09-03 19:26:58','CHAT2 P6Msg1'),(27,2,66666666,'2020-09-03 19:26:58','CHAT2 P6Msg2'),(28,2,63841116,'2020-09-03 19:26:58','CHAT2 M6Msg1'),(29,2,63841116,'2020-09-03 19:26:58','CHAT2 M61Msg2'),(30,2,66666666,'2020-09-03 19:26:58','CHAT2 P6Msg3'),(31,2,77777777,'2020-09-03 19:26:58','CHAT2 P7Msg1'),(32,2,77777777,'2020-09-03 19:26:58','CHAT2 P7Msg2'),(33,2,52539869,'2020-09-03 19:26:58','CHAT2 M71Msg1'),(34,2,52539869,'2020-09-03 19:26:58','CHAT2 M7Msg2'),(35,2,77777777,'2020-09-03 19:26:58','CHAT2 P7Msg3'),(36,2,88888888,'2020-09-03 19:26:58','CHAT2 P8Msg1'),(37,2,88888888,'2020-09-03 19:26:58','CHAT2 P8Msg2'),(38,2,12121212,'2020-09-03 19:26:58','CHAT2 M8Msg1'),(39,2,12121212,'2020-09-03 19:26:58','CHAT2 M81Msg2'),(40,2,88888888,'2020-09-03 19:26:58','CHAT2 P8Msg3'),(41,2,99999999,'2020-09-03 19:26:58','CHAT2 P9Msg1'),(42,2,99999999,'2020-09-03 19:26:58','CHAT2 P9Msg2'),(43,2,13131313,'2020-09-03 19:26:58','CHAT2 M9Msg1'),(44,2,13131313,'2020-09-03 19:26:58','CHAT2 M9Msg2'),(45,2,99999999,'2020-09-03 19:26:58','CHAT2 P9Msg3');
/*!40000 ALTER TABLE `mensajes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `personas`
--

DROP TABLE IF EXISTS `personas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `personas` (
  `ci` int(8) unsigned NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidoP` varchar(50) DEFAULT NULL,
  `apellidoM` varchar(50) DEFAULT NULL,
  `fechaNacimiento` date NOT NULL,
  `telefono` int(9) NOT NULL,
  `esEmpleado` tinyint(1) DEFAULT '0',
  `esMedico` tinyint(1) DEFAULT '0',
  `extendido` tinyint(1) DEFAULT '0',
  `esPaciente` tinyint(1) DEFAULT '0',
  `esRRHH` tinyint(1) DEFAULT '0',
  `esRecepcionista` tinyint(1) DEFAULT '0',
  `esDuenno` tinyint(1) DEFAULT '0',
  `email` varchar(40) DEFAULT NULL,
  `nucleoFlia` varchar(256) DEFAULT NULL,
  `antecedentesFlia` varchar(512) DEFAULT NULL,
  `antecedentesLab` varchar(512) DEFAULT NULL,
  `password` varchar(64) NOT NULL,
  `idDireccion` mediumint(8) unsigned DEFAULT NULL,
  `ENABLED` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`ci`),
  KEY `idDireccion` (`idDireccion`),
  CONSTRAINT `personas_ibfk_1` FOREIGN KEY (`idDireccion`) REFERENCES `direcciones` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `personas`
--

LOCK TABLES `personas` WRITE;
/*!40000 ALTER TABLE `personas` DISABLE KEYS */;
INSERT INTO `personas` (`ci`, `nombre`, `apellidoP`, `apellidoM`, `fechaNacimiento`, `telefono`, `esEmpleado`, `esMedico`, `extendido`, `esPaciente`, `esRRHH`, `esRecepcionista`, `esDuenno`, `email`, `nucleoFlia`, `antecedentesFlia`, `antecedentesLab`, `password`, `idDireccion`, `ENABLED`) VALUES (8327111,'Recep 6','A1R6','A2R6','1988-03-20',95454678,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',34,1),(11111111,'Paciente 1','A1P1','A2P1','2000-07-19',91111111,0,0,0,1,0,0,0,'paciente1@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',1,1),(12121212,'Medico 8','A1M1','A2M1','2000-02-01',99473972,1,1,1,0,0,0,0,NULL,NULL,NULL,NULL,'123',27,1),(12162092,'RRHH 4','A1H4','A2H4','1995-07-27',93225667,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',42,1),(12761197,'Medico 1','A1M1','A2M1','2000-02-01',91111111,1,1,0,0,0,0,0,NULL,NULL,NULL,NULL,'123',21,1),(13131313,'Medico 9','A1M1','A2M1','2000-02-01',91222222,1,1,1,0,0,0,0,NULL,NULL,NULL,NULL,'123',28,1),(14852255,'Paciente 20','A1P20','A2P20','2000-01-30',91111111,0,0,0,1,0,0,0,'paciente20@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',20,1),(15879868,'Recep 5','A1R5','A2R5','1996-05-06',97898987,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',33,1),(18318449,'RRHH 2','A1H2','A2H2','1998-10-28',96778332,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',40,1),(18988696,'Recep 2','A1R2','A2R2','1998-12-11',95676879,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',30,1),(21170323,'Medico 3','A1M1','A2M1','2000-02-01',98899889,1,1,0,0,0,0,0,NULL,NULL,NULL,NULL,'123',22,1),(21736098,'Paciente 16','A1P16','A2P16','2000-01-04',91111111,0,0,0,1,0,0,0,'paciente16@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',16,1),(22222222,'Paciente 2','A1P2','A2P2','2000-07-18',91111111,0,0,0,1,0,0,0,'paciente2@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',2,1),(23295298,'Recep 7','A1R7','A2R7','1991-09-09',93222909,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',35,1),(23520049,'Recep 1','A1R1','A2R1','2000-03-01',92222222,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',29,1),(24637435,'Paciente 15','A1P15','A2P15','2000-01-05',91111111,0,0,0,1,0,0,0,'paciente15@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',15,1),(24659934,'Recep 9','A1R9','A2R9','2000-10-30',95466766,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',36,1),(25426526,'RRHH 10','A1H10','A2H10','2000-03-01',93477898,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',47,1),(25816822,'Medico 5','A1M1','A2M1','2000-02-01',99876732,1,1,0,0,0,0,0,NULL,NULL,NULL,NULL,'123',24,1),(28390386,'Paciente 13','A1P13','A2P13','2000-01-07',91111111,0,0,0,1,0,0,0,'paciente13@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',13,1),(31541142,'RRHH 1','A1H1','A2H1','1999-04-12',9134532,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',39,1),(31983639,'Paciente 18','A1P18','A2P18','2000-01-02',91111111,0,0,0,1,0,0,0,'paciente18@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',18,1),(33333333,'Paciente 3','A1P3','A2P3','2000-01-17',91111111,0,0,0,1,0,0,0,'paciente3@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',3,1),(34477798,'RRHH 9','A1H9','A2H1','1990-05-11',96557887,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',46,1),(34964248,'Recep 10','A1R10','A2R10','1960-10-26',98878654,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',37,1),(36213344,'RRHH 6','A1H6','A2H6','1971-11-02',97668905,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',43,1),(38166482,'Paciente 11','A1P11','A2P11','2000-01-09',91111111,0,0,0,1,0,0,0,'paciente11@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',11,1),(39763392,'Medico 4','A1M1','A2M1','2000-02-01',98754573,1,1,0,0,0,0,0,NULL,NULL,NULL,NULL,'123',23,1),(40428036,'Medico 2','A1M1','A2M1','2000-02-01',92345678,1,1,0,0,0,0,0,NULL,NULL,NULL,NULL,'123',22,1),(44444444,'Paciente 4','A1P4','A2P4','2000-01-16',91111111,0,0,0,1,0,0,0,'paciente4@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',4,1),(52539869,'Medico 7','A1M1','A2M1','2000-02-01',92764839,1,1,0,0,0,0,0,NULL,NULL,NULL,NULL,'123',26,1),(55555555,'Paciente 5','A1P5','A2P5','2000-01-15',91111111,0,0,0,1,0,0,0,'paciente5@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',5,1),(56319556,'Paciente 12','A1P12','A2P12','2000-01-08',91111111,0,0,0,1,0,0,0,'paciente12@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',12,1),(56646612,'Paciente 14','A1P14','A2P14','2000-01-06',91111111,0,0,0,1,0,0,0,'paciente14@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',14,1),(63841116,'Medico 6','A1M1','A2M1','2000-02-01',91837464,1,1,0,0,0,0,0,NULL,NULL,NULL,NULL,'123',25,1),(64763288,'RRHH 3','A1H3','A2H3','1971-01-08',9676889,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',41,1),(66666666,'Paciente 6','A1P6','A2P6','2000-01-14',91111111,0,0,0,1,0,0,0,'paciente6@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',6,1),(74171659,'Paciente 19','A1P19','A2P19','2000-01-01',91111111,0,0,0,1,0,0,0,'paciente19@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',19,1),(76986763,'RRHH 11','A1H11','A2H11','2000-04-01',98374657,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',48,1),(77333179,'Recep3','A1R3','A2R3','1978-02-15',92234522,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',31,1),(77777777,'Paciente 7','A1P7','A2P7','2000-01-13',91111111,0,0,0,1,0,0,0,'paciente7@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',7,1),(80908935,'RRHH 7','A1H7','A2H7','1995-01-05',91145667,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',44,1),(82133479,'Recep 11','A1R11','A2R11','2000-05-21',98984853,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',38,1),(88699740,'Paciente 17','A1P17','A2P17','2000-01-03',91111111,0,0,0,1,0,0,0,'paciente17@hotmail.com','Nucleo Familiar','An7tecedentes Familiares','Antecedentes Laborales','123',17,1),(88888888,'Paciente 8','A1P8','A2P8','2000-01-12',91111111,0,0,0,1,0,0,0,'paciente8@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',8,1),(89325839,'Paciente 10','A1P10','A2P10','2000-01-10',91111111,0,0,0,1,0,0,0,'paciente10@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',10,1),(92824717,'Recep4','A1R4','A2R4','2001-11-01',96453543,1,0,0,0,0,1,0,NULL,NULL,NULL,NULL,'123',32,1),(92910356,'RRHH 8','A1H8','A2H8','2000-01-02',98889907,1,0,0,0,1,0,0,NULL,NULL,NULL,NULL,'123',45,1),(99999999,'Paciente 9','A1P9','A2P9','2000-01-11',91111111,0,0,0,1,0,0,0,'paciente9@hotmail.com','Nucleo Familiar','Antecedentes Familiares','Antecedentes Laborales','123',9,1);
/*!40000 ALTER TABLE `personas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rec_password_log`
--

DROP TABLE IF EXISTS `rec_password_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rec_password_log` (
  `ciRecepcionista` int(8) unsigned NOT NULL DEFAULT '0',
  `ciPaciente` int(8) unsigned NOT NULL DEFAULT '0',
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ciRecepcionista`,`ciPaciente`,`timestamp`),
  KEY `ciPaciente` (`ciPaciente`),
  CONSTRAINT `rec_password_log_ibfk_1` FOREIGN KEY (`ciRecepcionista`) REFERENCES `personas` (`ci`),
  CONSTRAINT `rec_password_log_ibfk_2` FOREIGN KEY (`ciPaciente`) REFERENCES `personas` (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rec_password_log`
--

LOCK TABLES `rec_password_log` WRITE;
/*!40000 ALTER TABLE `rec_password_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `rec_password_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `registra`
--

DROP TABLE IF EXISTS `registra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `registra` (
  `idConsulta` bigint(20) unsigned NOT NULL DEFAULT '0',
  `idSintoma` smallint(5) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`idConsulta`,`idSintoma`),
  KEY `idSintoma` (`idSintoma`),
  CONSTRAINT `registra_ibfk_1` FOREIGN KEY (`idConsulta`) REFERENCES `consultas` (`id`),
  CONSTRAINT `registra_ibfk_2` FOREIGN KEY (`idSintoma`) REFERENCES `sintomas` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registra`
--

LOCK TABLES `registra` WRITE;
/*!40000 ALTER TABLE `registra` DISABLE KEYS */;
/*!40000 ALTER TABLE `registra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rrhh_password_log`
--

DROP TABLE IF EXISTS `rrhh_password_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rrhh_password_log` (
  `ciRRHH` int(8) unsigned NOT NULL DEFAULT '0',
  `ciEmpleado` int(8) unsigned NOT NULL DEFAULT '0',
  `timestamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`ciRRHH`,`ciEmpleado`,`timestamp`),
  KEY `ciEmpleado` (`ciEmpleado`),
  CONSTRAINT `rrhh_password_log_ibfk_1` FOREIGN KEY (`ciRRHH`) REFERENCES `personas` (`ci`),
  CONSTRAINT `rrhh_password_log_ibfk_2` FOREIGN KEY (`ciEmpleado`) REFERENCES `personas` (`ci`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rrhh_password_log`
--

LOCK TABLES `rrhh_password_log` WRITE;
/*!40000 ALTER TABLE `rrhh_password_log` DISABLE KEYS */;
/*!40000 ALTER TABLE `rrhh_password_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sintomas`
--

DROP TABLE IF EXISTS `sintomas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sintomas` (
  `id` smallint(5) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(80) NOT NULL,
  `descripcion` varchar(512) DEFAULT NULL,
  `tipo` enum('Cabeza','Torso','Extremidades') NOT NULL,
  `ENABLED` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sintomas`
--

LOCK TABLES `sintomas` WRITE;
/*!40000 ALTER TABLE `sintomas` DISABLE KEYS */;
INSERT INTO `sintomas` (`id`, `nombre`, `descripcion`, `tipo`, `ENABLED`) VALUES (1,'Dolor de Cabeza','Default','Cabeza',1),(2,'Dolor de Estomago','Default','Extremidades',1),(3,'Nauseas','Default','Cabeza',1),(4,'Ganglios Inflamados','Default','Cabeza',1),(5,'Fiebre Alta','Default','Cabeza',1),(6,'Tos Seca','Default','Cabeza',1),(7,'Flemas','Default','Cabeza',1),(8,'Sudoración','Default','Cabeza',1),(9,'Dolor en Articulaciones','Default','Extremidades',1),(10,'AAA','Default','Extremidades',1),(11,'BBB','Default','Cabeza',1),(12,'CCC','Default','Torso',1),(13,'DDD','Default','Extremidades',1),(14,'EEE','Default','Cabeza',1),(15,'FFF','Default','Torso',1),(16,'GGG','Default','Extremidades',1),(17,'HHH','Default','Cabeza',1),(18,'III','Default','Torso',1),(19,'JJJ','Default','Extremidades',1),(20,'KKK','Default','Cabeza',1);
/*!40000 ALTER TABLE `sintomas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sucursales`
--

DROP TABLE IF EXISTS `sucursales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sucursales` (
  `id` tinyint(3) unsigned NOT NULL AUTO_INCREMENT,
  `nombre` varchar(40) NOT NULL,
  `idDireccion` mediumint(8) unsigned DEFAULT NULL,
  `ENABLED` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `nombre` (`nombre`),
  KEY `idDireccion` (`idDireccion`),
  CONSTRAINT `sucursales_ibfk_1` FOREIGN KEY (`idDireccion`) REFERENCES `direcciones` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sucursales`
--

LOCK TABLES `sucursales` WRITE;
/*!40000 ALTER TABLE `sucursales` DISABLE KEYS */;
INSERT INTO `sucursales` (`id`, `nombre`, `idDireccion`, `ENABLED`) VALUES (1,'Medica Uruguaya',1,1),(2,'Asociacion Española',2,1);
/*!40000 ALTER TABLE `sucursales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefonos_sucursales`
--

DROP TABLE IF EXISTS `telefonos_sucursales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefonos_sucursales` (
  `idSucursal` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `telefono` int(9) NOT NULL DEFAULT '0',
  PRIMARY KEY (`idSucursal`,`telefono`),
  CONSTRAINT `telefonos_sucursales_ibfk_1` FOREIGN KEY (`idSucursal`) REFERENCES `sucursales` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefonos_sucursales`
--

LOCK TABLES `telefonos_sucursales` WRITE;
/*!40000 ALTER TABLE `telefonos_sucursales` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefonos_sucursales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajan_horario`
--

DROP TABLE IF EXISTS `trabajan_horario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trabajan_horario` (
  `ciMedico` int(8) unsigned NOT NULL DEFAULT '0',
  `idSucursal` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `diaGuardia` enum('Lunes','Martes','Miercoles','Jueves','Viernes','Sabado','Domingo') NOT NULL DEFAULT 'Lunes',
  `horaEntrada` time NOT NULL DEFAULT '00:00:00',
  `horaSalida` time NOT NULL DEFAULT '00:00:00',
  PRIMARY KEY (`ciMedico`,`idSucursal`,`diaGuardia`,`horaEntrada`,`horaSalida`),
  KEY `idSucursal` (`idSucursal`),
  CONSTRAINT `trabajan_horario_ibfk_1` FOREIGN KEY (`ciMedico`) REFERENCES `personas` (`ci`),
  CONSTRAINT `trabajan_horario_ibfk_2` FOREIGN KEY (`idSucursal`) REFERENCES `sucursales` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajan_horario`
--

LOCK TABLES `trabajan_horario` WRITE;
/*!40000 ALTER TABLE `trabajan_horario` DISABLE KEYS */;
INSERT INTO `trabajan_horario` (`ciMedico`, `idSucursal`, `diaGuardia`, `horaEntrada`, `horaSalida`) VALUES (8327111,2,'Lunes','16:26:55','16:26:55'),(8327111,2,'Viernes','16:26:56','16:26:56'),(12121212,1,'Lunes','16:26:55','16:26:55'),(12121212,1,'Miercoles','16:26:55','16:26:55'),(12162092,1,'Lunes','16:26:56','16:26:56'),(12162092,1,'Jueves','16:26:56','16:26:56'),(12162092,2,'Lunes','16:26:56','16:26:56'),(12162092,2,'Viernes','16:26:56','16:26:56'),(12761197,1,'Lunes','16:26:54','16:26:54'),(12761197,1,'Martes','16:26:54','16:26:54'),(13131313,2,'Lunes','16:26:55','16:26:55'),(13131313,2,'Jueves','16:26:55','16:26:55'),(15879868,1,'Martes','16:26:55','16:26:55'),(15879868,1,'Miercoles','16:26:55','16:26:55'),(18318449,1,'Martes','16:26:56','16:26:56'),(18318449,1,'Jueves','16:26:56','16:26:56'),(18988696,2,'Martes','16:26:55','16:26:55'),(18988696,2,'Jueves','16:26:55','16:26:55'),(21170323,2,'Lunes','16:26:54','16:26:54'),(21170323,2,'Miercoles','16:26:54','16:26:54'),(23295298,1,'Lunes','16:26:56','16:26:56'),(23295298,1,'Miercoles','16:26:56','16:26:56'),(23295298,2,'Lunes','16:26:56','16:26:56'),(23295298,2,'Viernes','16:26:56','16:26:56'),(23520049,1,'Lunes','16:26:55','16:26:55'),(23520049,1,'Martes','16:26:55','16:26:55'),(24659934,1,'Jueves','16:26:56','16:26:56'),(24659934,2,'Martes','16:26:56','16:26:56'),(25426526,2,'Lunes','16:26:57','16:26:57'),(25426526,2,'Jueves','16:26:57','16:26:57'),(25816822,2,'Lunes','16:26:55','16:26:55'),(25816822,2,'Jueves','16:26:55','16:26:55'),(31541142,1,'Lunes','16:26:56','16:26:56'),(31541142,2,'Miercoles','16:26:56','16:26:56'),(34477798,1,'Martes','16:26:57','16:26:57'),(34477798,1,'Viernes','16:26:56','16:26:56'),(34964248,1,'Viernes','16:26:56','16:26:56'),(34964248,2,'Miercoles','16:26:56','16:26:56'),(36213344,1,'Lunes','16:26:56','16:26:56'),(36213344,2,'Miercoles','16:26:56','16:26:56'),(39763392,1,'Lunes','16:26:54','16:26:54'),(39763392,1,'Jueves','16:26:54','16:26:54'),(40428036,1,'Lunes','16:26:54','16:26:54'),(40428036,1,'Martes','16:26:54','16:26:54'),(52539869,2,'Lunes','16:26:55','16:26:55'),(52539869,2,'Viernes','16:26:55','16:26:55'),(63841116,1,'Lunes','16:26:55','16:26:55'),(63841116,1,'Martes','16:26:55','16:26:55'),(64763288,1,'Miercoles','16:26:56','16:26:56'),(64763288,2,'Martes','16:26:56','16:26:56'),(76986763,1,'Lunes','16:26:57','16:26:57'),(76986763,1,'Martes','16:26:57','16:26:57'),(77333179,1,'Miercoles','16:26:55','16:26:55'),(77333179,1,'Viernes','16:26:55','16:26:55'),(80908935,2,'Lunes','16:26:56','16:26:56'),(80908935,2,'Jueves','16:26:56','16:26:56'),(82133479,1,'Lunes','16:26:56','16:26:56'),(82133479,1,'Martes','16:26:56','16:26:56'),(92824717,2,'Lunes','16:26:55','16:26:55'),(92824717,2,'Jueves','16:26:55','16:26:55'),(92910356,2,'Martes','16:26:56','16:26:56'),(92910356,2,'Viernes','16:26:56','16:26:56');
/*!40000 ALTER TABLE `trabajan_horario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tratamientos`
--

DROP TABLE IF EXISTS `tratamientos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tratamientos` (
  `id` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(512) DEFAULT NULL,
  `ENABLED` tinyint(1) DEFAULT '1',
  `idEnfermedad` smallint(5) unsigned DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idEnfermedad` (`idEnfermedad`),
  CONSTRAINT `tratamientos_ibfk_1` FOREIGN KEY (`idEnfermedad`) REFERENCES `enfermedades` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tratamientos`
--

LOCK TABLES `tratamientos` WRITE;
/*!40000 ALTER TABLE `tratamientos` DISABLE KEYS */;
/*!40000 ALTER TABLE `tratamientos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `Pacientes`
--

/*!50001 DROP TABLE IF EXISTS `Pacientes`*/;
/*!50001 DROP VIEW IF EXISTS `Pacientes`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`admin`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `Pacientes` AS select `P`.`ci` AS `Cedula`,concat_ws(' ',`P`.`nombre`,`P`.`apellidoP`,`P`.`apellidoM`) AS `Nombre Completo`,`P`.`fechaNacimiento` AS `Fecha de Nacimiento`,`P`.`telefono` AS `Telefono`,`P`.`email` AS `Email`,concat_ws(',',`D`.`calle`,`D`.`numero`,`D`.`localidad`,`D`.`departamento`,`D`.`detalle`) AS `Direccion`,`P`.`nucleoFlia` AS `Nucleo Familiar`,`P`.`antecedentesFlia` AS `Antecedentes Familiares`,`P`.`antecedentesLab` AS `Antecedentes Laborales` from (`personas` `P` join `direcciones` `D` on((`P`.`idDireccion` = `D`.`id`))) where ((`P`.`esPaciente` = 1) and (`P`.`ENABLED` = 1)) order by concat_ws(' ',`P`.`nombre`,`P`.`apellidoP`,`P`.`apellidoM`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-09-03 16:30:33
