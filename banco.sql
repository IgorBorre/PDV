CREATE DATABASE  IF NOT EXISTS `pdv` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `pdv`;
-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pdv
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cancelamentoentradalog`
--

DROP TABLE IF EXISTS `cancelamentoentradalog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cancelamentoentradalog` (
  `documento` int DEFAULT NULL,
  `motivo` varchar(200) DEFAULT NULL,
  `dataCancelamento` date DEFAULT NULL,
  KEY `documento` (`documento`),
  CONSTRAINT `cancelamentoentradalog_ibfk_1` FOREIGN KEY (`documento`) REFERENCES `entrada` (`documento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cancelamentoentradalog`
--

LOCK TABLES `cancelamentoentradalog` WRITE;
/*!40000 ALTER TABLE `cancelamentoentradalog` DISABLE KEYS */;
INSERT INTO `cancelamentoentradalog` VALUES (9,'teste de cancelamento','2025-10-29'),(6,'teste de cancelamento','2026-02-04'),(10,'teste de cancelamento','2026-02-04');
/*!40000 ALTER TABLE `cancelamentoentradalog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cancelamentolog`
--

DROP TABLE IF EXISTS `cancelamentolog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cancelamentolog` (
  `documento` int DEFAULT NULL,
  `motivo` varchar(200) DEFAULT NULL,
  `dataCancelamento` date DEFAULT NULL,
  KEY `documento` (`documento`),
  CONSTRAINT `cancelamentolog_ibfk_1` FOREIGN KEY (`documento`) REFERENCES `saida` (`documento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cancelamentolog`
--

LOCK TABLES `cancelamentolog` WRITE;
/*!40000 ALTER TABLE `cancelamentolog` DISABLE KEYS */;
INSERT INTO `cancelamentolog` VALUES (20,'venda feita com valor errado','2025-10-16'),(1,'venda feita com produtos errados','2025-10-16'),(27,'venda feita com produto errado','2025-10-16');
/*!40000 ALTER TABLE `cancelamentolog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `identificacao` varchar(14) NOT NULL DEFAULT '00000000000',
  `telefone` varchar(15) DEFAULT NULL,
  `nascimento` date DEFAULT NULL,
  `situacao` enum('normal','bloqueado') DEFAULT 'normal',
  `logradouro` varchar(100) DEFAULT NULL,
  `rua` varchar(100) DEFAULT NULL,
  `numero` varchar(10) DEFAULT NULL,
  `complemento` varchar(50) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `estado` char(2) DEFAULT NULL,
  `cep` varchar(8) DEFAULT NULL,
  `referencia` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'Cliente Teste','00000000000',NULL,NULL,'normal',NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,'Igor','17436774727','(24)9928-4148','2002-07-04','normal','Rua','casemiro de abreu','79','terceiro portao de madeira','centro','petropolis','AC','25615002','teste'),(3,'teste','17436774727',NULL,'2002-07-04','normal','Rua','','','','','','AC','',''),(4,'teste','17436774727','(  )    -','2002-07-04','normal','Rua','','','','','','AC','',''),(5,'teste','17436774727','(  )    -','2005-05-04','normal','Rua','','','','','','AC','',''),(6,'teste2','17436774727','(  )    -','2002-07-04','normal','Rua','','','','','','AC','',''),(7,'teste de cadastro','01606661710',NULL,NULL,'normal','Rua','','','','','','AC','',''),(8,'teste 2','17436774727','24992841484',NULL,'normal','Rua','','','','','','AC','',''),(9,'teste 1212','14564656','24992841484','2003-01-26','normal','Rua','casemiro de abreu','79','3° portao de madeira','centro','petropolis','AC','25615002','teste'),(10,'cadastro','17436774727','',NULL,'normal','Rua','','','','','','AC','',''),(11,'cadastro34','01606661710',NULL,NULL,'normal','Rua','','','','','','AC','',''),(12,'teste de cadastro','00379976706','',NULL,'normal','Rua','','','','','','AC','',''),(13,'Igor','17436774727','',NULL,'normal','Rua','','','','','','AC','','');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `devolucao`
--

DROP TABLE IF EXISTS `devolucao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `devolucao` (
  `documento` int NOT NULL AUTO_INCREMENT,
  `idCliente` int DEFAULT NULL,
  `nomeCliente` varchar(50) DEFAULT NULL,
  `dataDevolucao` date DEFAULT NULL,
  `cancelada` char(1) DEFAULT 'N',
  PRIMARY KEY (`documento`),
  KEY `idCliente` (`idCliente`),
  CONSTRAINT `devolucao_ibfk_1` FOREIGN KEY (`idCliente`) REFERENCES `clientes` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `devolucao`
--

LOCK TABLES `devolucao` WRITE;
/*!40000 ALTER TABLE `devolucao` DISABLE KEYS */;
/*!40000 ALTER TABLE `devolucao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entrada`
--

DROP TABLE IF EXISTS `entrada`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entrada` (
  `documento` int NOT NULL AUTO_INCREMENT,
  `dataentrada` date DEFAULT NULL,
  `idfornecedor` int DEFAULT NULL,
  `nomefornecedor` varchar(50) DEFAULT NULL,
  `cancelada` char(1) DEFAULT 'N',
  `doc_original` int DEFAULT NULL,
  `tipo` char(1) DEFAULT 'N',
  PRIMARY KEY (`documento`),
  KEY `idfornecedor` (`idfornecedor`),
  KEY `doc_original` (`doc_original`),
  CONSTRAINT `entrada_ibfk_1` FOREIGN KEY (`idfornecedor`) REFERENCES `clientes` (`codigo`),
  CONSTRAINT `entrada_ibfk_2` FOREIGN KEY (`doc_original`) REFERENCES `devolucao` (`documento`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entrada`
--

LOCK TABLES `entrada` WRITE;
/*!40000 ALTER TABLE `entrada` DISABLE KEYS */;
INSERT INTO `entrada` VALUES (1,'2025-09-17',NULL,NULL,'N',NULL,'N'),(2,'2025-09-17',2,'IGOR','N',NULL,'N'),(3,'2025-09-17',NULL,NULL,'N',NULL,'N'),(4,'2025-09-17',NULL,NULL,'N',NULL,'N'),(5,'2025-10-14',NULL,NULL,'N',NULL,'N'),(6,'2025-10-16',NULL,NULL,'S',NULL,'N'),(7,'2025-10-29',1,'CLIENTE TESTE','S',NULL,'N'),(8,'2025-10-29',NULL,NULL,'S',NULL,'N'),(9,'2025-10-29',2,'IGOR','S',NULL,'N'),(10,'2026-02-04',NULL,NULL,'S',NULL,'N');
/*!40000 ALTER TABLE `entrada` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entradadados`
--

DROP TABLE IF EXISTS `entradadados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `entradadados` (
  `docentrada` int DEFAULT NULL,
  `idproduto` int DEFAULT NULL,
  `descproduto` varchar(50) DEFAULT NULL,
  `quantidade` double DEFAULT NULL,
  KEY `docentrada` (`docentrada`),
  KEY `idproduto` (`idproduto`),
  CONSTRAINT `entradadados_ibfk_1` FOREIGN KEY (`docentrada`) REFERENCES `entrada` (`documento`),
  CONSTRAINT `entradadados_ibfk_2` FOREIGN KEY (`idproduto`) REFERENCES `produtos` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradadados`
--

LOCK TABLES `entradadados` WRITE;
/*!40000 ALTER TABLE `entradadados` DISABLE KEYS */;
INSERT INTO `entradadados` VALUES (1,1,'CASACO DE COURO',3),(1,2,'CALÇA DE MOLETOM',2),(2,2,'CALÇA DE MOLETOM',9),(3,1,'CASACO DE COURO',10),(4,1,'CASACO DE COURO',-1),(5,1,'CASACO DE COURO',6),(6,1,'CASACO DE COURO',8),(7,1,'CASACO DE COURO',11),(8,1,'CASACO DE COURO',11),(9,1,'CASACO DE COURO',11),(10,1,'CASACO DE COURO',9);
/*!40000 ALTER TABLE `entradadados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formas_pagamento`
--

DROP TABLE IF EXISTS `formas_pagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `formas_pagamento` (
  `id` int NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) DEFAULT NULL,
  `ativa` varchar(3) DEFAULT NULL,
  `avista` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formas_pagamento`
--

LOCK TABLES `formas_pagamento` WRITE;
/*!40000 ALTER TABLE `formas_pagamento` DISABLE KEYS */;
INSERT INTO `formas_pagamento` VALUES (1,'DINHEIRO','Sim','Sim'),(2,'CARTAO','Sim','Não'),(3,'DÉBITO','Sim','Sim'),(4,'CREDITO','Sim','Não');
/*!40000 ALTER TABLE `formas_pagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grupos`
--

DROP TABLE IF EXISTS `grupos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `grupos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grupos`
--

LOCK TABLES `grupos` WRITE;
/*!40000 ALTER TABLE `grupos` DISABLE KEYS */;
INSERT INTO `grupos` VALUES (1,'camisa'),(2,'calça'),(3,'tenis'),(4,'teste'),(5,'teste2'),(6,'teset3'),(7,'teste4'),(8,'tete3'),(9,'teste5'),(10,'testee'),(11,'testeeee'),(12,'testee22'),(13,'testeee1'),(14,'testeee4');
/*!40000 ALTER TABLE `grupos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagsaida`
--

DROP TABLE IF EXISTS `pagsaida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pagsaida` (
  `documento` int NOT NULL,
  `idpagamento` int NOT NULL,
  `descpagamento` varchar(50) DEFAULT NULL,
  `parcelas` int DEFAULT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  KEY `documento` (`documento`),
  KEY `idpagamento` (`idpagamento`),
  CONSTRAINT `pagsaida_ibfk_1` FOREIGN KEY (`documento`) REFERENCES `saida` (`documento`),
  CONSTRAINT `pagsaida_ibfk_2` FOREIGN KEY (`idpagamento`) REFERENCES `formas_pagamento` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagsaida`
--

LOCK TABLES `pagsaida` WRITE;
/*!40000 ALTER TABLE `pagsaida` DISABLE KEYS */;
INSERT INTO `pagsaida` VALUES (11,1,'DINHEIRO',1,20.00),(12,1,'DINHEIRO',1,25.00),(12,2,'CARTAO',1,25.00),(13,1,'DINHEIRO',1,20.00),(14,1,'DINHEIRO',1,50.00),(14,2,'CARTAO',1,50.00),(15,2,'CARTAO',4,100.00),(16,1,'DINHEIRO',1,17.00),(17,1,'DINHEIRO',1,50.00),(17,3,'DÉBITO',1,35.00),(18,1,'DINHEIRO',1,50.00),(18,3,'DÉBITO',1,25.00),(19,1,'DINHEIRO',1,115.00),(20,1,'DINHEIRO',1,100.00),(21,1,'DINHEIRO',1,50.00),(21,2,'CARTAO',1,40.00),(22,1,'DINHEIRO',1,40.00),(23,2,'CARTAO',1,40.00),(24,1,'DINHEIRO',1,40.00),(25,1,'DINHEIRO',1,160.00),(26,1,'DINHEIRO',1,100.00),(27,1,'DINHEIRO',1,200.00),(28,2,'CARTAO',1,25.00),(29,1,'DINHEIRO',1,45.00);
/*!40000 ALTER TABLE `pagsaida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `referencia` varchar(50) DEFAULT NULL,
  `descricao` varchar(50) DEFAULT NULL,
  `estoque` double DEFAULT NULL,
  `preco` double DEFAULT NULL,
  `idGrupo` int DEFAULT NULL,
  `grupo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`codigo`),
  KEY `idGrupo` (`idGrupo`),
  CONSTRAINT `produtos_ibfk_1` FOREIGN KEY (`idGrupo`) REFERENCES `grupos` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,'teste','casaco de couro',21,20,NULL,NULL),(2,'teste2','calça de moletom',56,115,NULL,NULL),(4,'teste','calça de moletom',50,28,2,'calça'),(5,'asdjjkjqwkjdakjsdj','tenis vermelho',50,60,3,'tenis'),(6,'','camisa polo',50,25,1,'camisa');
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saida`
--

DROP TABLE IF EXISTS `saida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `saida` (
  `documento` int NOT NULL AUTO_INCREMENT,
  `clienteId` int DEFAULT NULL,
  `clienteNome` varchar(50) DEFAULT NULL,
  `dataSaida` date DEFAULT NULL,
  `valortotal` decimal(10,2) DEFAULT NULL,
  `desconto` decimal(10,2) DEFAULT NULL,
  `acrescimo` decimal(10,2) DEFAULT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  `cancelada` char(1) DEFAULT 'N',
  `tipo` char(1) DEFAULT 'N',
  `doc_original` int DEFAULT NULL,
  PRIMARY KEY (`documento`),
  KEY `clienteId` (`clienteId`),
  KEY `doc_original` (`doc_original`),
  CONSTRAINT `saida_ibfk_1` FOREIGN KEY (`clienteId`) REFERENCES `clientes` (`codigo`),
  CONSTRAINT `saida_ibfk_2` FOREIGN KEY (`doc_original`) REFERENCES `devolucao` (`documento`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saida`
--

LOCK TABLES `saida` WRITE;
/*!40000 ALTER TABLE `saida` DISABLE KEYS */;
INSERT INTO `saida` VALUES (1,NULL,NULL,'2025-06-09',NULL,NULL,NULL,NULL,'S','N',NULL),(2,NULL,NULL,'2025-06-09',NULL,NULL,NULL,NULL,'N','N',NULL),(3,NULL,NULL,'2025-06-09',NULL,NULL,NULL,NULL,'N','N',NULL),(4,NULL,NULL,'2025-06-20',NULL,NULL,NULL,NULL,'N','N',NULL),(5,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(6,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(7,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(8,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(9,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(10,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(11,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(12,NULL,NULL,'2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(13,2,'IGOR','2025-09-08',NULL,NULL,NULL,NULL,'N','N',NULL),(14,NULL,NULL,'2025-09-08',100.00,NULL,NULL,NULL,'N','N',NULL),(15,NULL,NULL,'2025-09-08',100.00,NULL,NULL,NULL,'N','N',NULL),(16,NULL,NULL,'2025-09-09',17.00,3.00,0.00,NULL,'N','N',NULL),(17,NULL,NULL,'2025-09-09',85.00,15.00,0.00,NULL,'N','N',NULL),(18,NULL,NULL,'2025-09-09',75.00,25.00,0.00,100.00,'N','N',NULL),(19,2,'IGOR','2025-09-09',115.00,0.00,15.00,100.00,'N','N',NULL),(20,1,'CLIENTE TESTE','2025-10-02',100.00,0.00,0.00,100.00,'S','N',NULL),(21,NULL,NULL,'2025-10-08',90.00,10.00,0.00,100.00,'S','N',NULL),(22,NULL,NULL,'2025-10-14',40.00,0.00,0.00,40.00,'S','N',NULL),(23,NULL,NULL,'2025-10-14',40.00,0.00,0.00,40.00,'S','N',NULL),(24,NULL,NULL,'2025-10-14',40.00,0.00,0.00,40.00,'S','N',NULL),(25,NULL,NULL,'2025-10-14',160.00,0.00,0.00,490.00,'S','N',NULL),(26,NULL,NULL,'2025-10-14',100.00,0.00,0.00,100.00,'S','N',NULL),(27,NULL,NULL,'2025-10-16',200.00,0.00,0.00,200.00,'S','N',NULL),(28,NULL,NULL,'2025-10-16',20.00,0.00,0.00,20.00,'N','N',NULL),(29,2,'IGOR','2025-10-16',45.00,5.00,0.00,50.00,'N','N',NULL);
/*!40000 ALTER TABLE `saida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `saidadados`
--

DROP TABLE IF EXISTS `saidadados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `saidadados` (
  `documento` int DEFAULT NULL,
  `produto` int DEFAULT NULL,
  `produtoNome` varchar(50) DEFAULT NULL,
  `quantidade` float DEFAULT NULL,
  KEY `documento` (`documento`),
  KEY `produto` (`produto`),
  CONSTRAINT `saidadados_ibfk_1` FOREIGN KEY (`documento`) REFERENCES `saida` (`documento`),
  CONSTRAINT `saidadados_ibfk_2` FOREIGN KEY (`produto`) REFERENCES `produtos` (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `saidadados`
--

LOCK TABLES `saidadados` WRITE;
/*!40000 ALTER TABLE `saidadados` DISABLE KEYS */;
INSERT INTO `saidadados` VALUES (1,1,'CASACO DE COURO',10),(1,2,'CALÇA DE MOLETOM',2),(2,1,'CASACO DE COURO',1),(3,1,'CASACO DE COURO',20),(3,2,'CALÇA DE MOLETOM',2),(4,1,'CASACO DE COURO',1),(5,1,'CASACO DE COURO',1),(6,1,'CASACO DE COURO',1),(7,1,'CASACO DE COURO',1),(8,1,'CASACO DE COURO',1),(9,1,'CASACO DE COURO',1),(10,1,'CASACO DE COURO',1),(11,1,'CASACO DE COURO',1),(12,1,'CASACO DE COURO',1),(12,2,'CALÇA DE MOLETOM',1),(13,1,'CASACO DE COURO',1),(14,1,'CASACO DE COURO',5),(15,1,'CASACO DE COURO',5),(16,1,'CASACO DE COURO',1),(17,2,'CALÇA DE MOLETOM',2),(18,2,'CALÇA DE MOLETOM',2),(19,2,'CALÇA DE MOLETOM',2),(20,1,'CASACO DE COURO',2),(20,2,'CALÇA DE MOLETOM',3),(21,2,'CALÇA DE MOLETOM',5),(22,1,'CASACO DE COURO',2),(23,1,'CASACO DE COURO',2),(24,1,'CASACO DE COURO',2),(25,1,'CASACO DE COURO',5),(25,2,'CALÇA DE MOLETOM',2),(26,1,'CASACO DE COURO',5),(27,1,'CASACO DE COURO',10),(28,1,'CASACO DE COURO',1),(29,2,'CALÇA DE MOLETOM',1);
/*!40000 ALTER TABLE `saidadados` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-02-24 15:36:28
