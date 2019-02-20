CREATE DATABASE  IF NOT EXISTS `fosdatabase` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `fosdatabase`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: localhost    Database: fosdatabase
-- ------------------------------------------------------
-- Server version	5.6.14

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
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `Menu_ID` char(5) NOT NULL,
  `Menu_Name` varchar(45) NOT NULL,
  `Unit_Price` decimal(10,2) NOT NULL,
  `Menu_Status` varchar(15) NOT NULL,
  PRIMARY KEY (`Menu_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES ('D0001','Orange Juice (Cold)',4.00,'Available'),('D0002','Apple Juice (Cold)',4.00,'Available'),('D0003','100-Plus',2.40,'Available'),('D0004','Sprite',2.40,'Available'),('D0005','Hot Tea',3.50,'Available'),('D0006','Hot Chocalate',3.50,'Available'),('D0007','Mineral Water (600ml)',2.00,'Available'),('D0008','Blakberry Fizz',6.90,'Available'),('D0009','Asam Boi Fizz',6.90,'Available'),('F0001','Vegetarian Maggie Soup',5.50,'Available'),('F0002','Chicken Noodle Soup',4.50,'Available'),('F0003','Chicken Chop',10.90,'Available'),('F0004','Fish and Chips',11.90,'Available'),('F0005','Chicken Porrige',4.00,'Available'),('F0006','Fried Noodles',6.90,'Available'),('F0007','Fried Rice',7.90,'Available'),('F0008','Lily Laksa',6.80,'Available'),('F0009','Chicken Lemon Rice',5.50,'Available'),('F0010','Curry Mee',4.50,'Available'),('F0011','BBQ Chicken',10.00,'Available'),('S0001','WaterFurry',2.00,'Available'),('S0002','Triple Pleasure',3.50,'Available'),('S0003','Banana Split',8.90,'Available'),('S0004','Molten Cake',8.90,'Available'),('S0005','Chocalate Volcano',6.90,'Available');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-12-29  0:14:58
