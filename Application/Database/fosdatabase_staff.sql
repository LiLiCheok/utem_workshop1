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
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `Staff_ID` char(6) NOT NULL,
  `Staff_Name` varchar(45) NOT NULL,
  `Staff_Position` varchar(10) NOT NULL,
  `Password` int(11) NOT NULL,
  PRIMARY KEY (`Staff_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES ('CS0001','Melly','Cashier',3010),('CS0002','Vivien','Cashier',3011),('CS0003','Jane','Cashier',3012),('CS0004','Kalvys','Cashier',3013),('CS0005','Elise Mok','Cashier',3014),('CS0006','Angel Haw','Cashier',3015),('KC0001','John Foo','Kitchen',1010),('KC0002','Patrik Lum','Kitchen',1011),('KC0003','Eason Man','Kitchen',1012),('KC0004','Jay Choo','Kitchen',1013),('KC0005','Kenny Onn','Kitchen',1014),('KC0006','Sanji Lo','Kitchen',1015),('KC0007','Daniel','Kitchen',1016),('KC0008','Donn','Kitchen',1017),('KC0009','Jacky','Kitchen',1018),('KC0010','Jason','Kitchen',1019),('MNG001','Sir Lester','Manager',1234567890),('WT0001','Cheok Li Li','Waiter',2010),('WT0002','Chong Kit Shing','Waiter',2011),('WT0003','Yong Yeong Ching','Waiter',2012),('WT0004','Lee Xue Wen','Waiter',2013),('WT0005','Soh Yee King','Waiter',2014),('WT0006','Liew Yuin Kuan','Waiter',2015),('WT0007','Amanda Chew Yan','Waiter',2016),('WT0008','Tan Sin Yen','Waiter',2017),('WT0009','Choo Geok Li','Waiter',2018);
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
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
