-- MySQL dump 10.13  Distrib 8.0.22, for Win64 (x86_64)
--
-- Host: localhost    Database: tap
-- ------------------------------------------------------
-- Server version	8.0.22

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
-- Table structure for table `carts`
--

DROP TABLE IF EXISTS `carts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ProductId` int NOT NULL,
  `Quantity` int NOT NULL,
  `SessionId` int NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carts`
--

LOCK TABLES `carts` WRITE;
/*!40000 ALTER TABLE `carts` DISABLE KEYS */;
INSERT INTO `carts` VALUES (12,56,67,8786);
/*!40000 ALTER TABLE `carts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `credentials`
--

DROP TABLE IF EXISTS `credentials`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `credentials` (
  `Id` int NOT NULL,
  `Email` text NOT NULL,
  `Password` text NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `credentials`
--

LOCK TABLES `credentials` WRITE;
/*!40000 ALTER TABLE `credentials` DISABLE KEYS */;
INSERT INTO `credentials` VALUES (1,'ravi','seed','',''),(2,'sachin','transflower','',''),(76,'rajan','tap','',''),(87,'shiv','kumar','',''),(87,'jai','veeru','',''),(98,'manisha','pant','',''),(55,'rutuja','tfl123','',''),(94,'neha','nikita','',''),(92,'ajinkya','coep','','');
/*!40000 ALTER TABLE `credentials` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customers` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `Location` text NOT NULL,
  `Age` int NOT NULL,
  `ContactNumber` varchar(10) NOT NULL,
  `Email` varchar(100) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM AUTO_INCREMENT=114 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (49,'Ravi Tambade','Pune',31,'9881735801','ravi.tambade@transflower.in'),(111,'Shubham Shinde','Pune',25,'7088123421','shubhamshinde@gmail.com'),(101,'Pratik Takawale','Pune',30,'9920037983','pr8555@gmail.com'),(105,'Kiran Muluk','Pune',26,'9933038083','kn99@gmail.com'),(112,'Vishal Kakade','Pune',25,'9988123421','vishalshirke@gmail.com'),(113,'Vishwambhar Kapare','Pune',25,'7188123421','vish10kapare@gmail.com');
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `flowers`
--

DROP TABLE IF EXISTS `flowers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `flowers` (
  `Id` int NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `UnitPrice` double NOT NULL,
  `Quantity` int NOT NULL,
  `ImageUrl` varchar(500) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `flowers`
--

LOCK TABLES `flowers` WRITE;
/*!40000 ALTER TABLE `flowers` DISABLE KEYS */;
INSERT INTO `flowers` VALUES (76,'Gleaming Bunch','Best Automobile',70,10000,'/images/flowers/Gerbera/gleamingbunch.jpg'),(67,'Pink Wrap','Best Automobile',200,50000,'/images/flowers/Gerbera/pinkwrap.jpg'),(198,'Pink Breeze','Best Automobile',575,8000,'/images/flowers/Gerbera/pinkbreeze.jpg'),(153,'Orange Happy Gerberas','Best Automobile',50,15000,'/images/flowers/Gerbera/orangehappygerberas.jpg'),(2600,'Deep-set Red Carnations','Red Carnations signify admiration, love and affection. If these are the things that you feel towards someone, then, go for this beautiful Bunch that has 12 Red Carnations in Red paper packing.',586,14,'/images/flowers/Carnation/Deepsetredcarnations.jpg'),(192,'Hello Beautiful','Every relationship needs magic and a pinch of insanity to keep the drive going. This gorgeous bunch of 10 Red Carnations is the right start for your share of Love, Magic and Insanity. It all begins here.',695,16,'/images/flowers/Carnation/hellobeutifull.jpg'),(100,'Beautiful mogra','Arabic tea jasmine flower',5,10000,'/images/mogra.jpg');
/*!40000 ALTER TABLE `flowers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderitems`
--

DROP TABLE IF EXISTS `orderitems`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderitems` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ProductId` int NOT NULL,
  `Quantity` int NOT NULL,
  `OrderId` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderitems`
--

LOCK TABLES `orderitems` WRITE;
/*!40000 ALTER TABLE `orderitems` DISABLE KEYS */;
INSERT INTO `orderitems` VALUES (1,19,5,1),(2,19,5,2),(3,1,2,2),(4,1,1,3),(5,20,10,3),(6,18,1,4),(7,21,1,4),(8,2,1,5),(9,19,10,5);
/*!40000 ALTER TABLE `orderitems` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `CustomerId` int NOT NULL,
  `TotalAmount` varchar(255) NOT NULL,
  `Status` varchar(255) NOT NULL,
  `OrderDate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,2,'80','Order Placed','2020-10-28 12:22:36'),(4,4,'9999','Order Placed','2020-11-06 19:40:34'),(6,2,'21980','Cancelled','2020-10-28 14:25:23'),(7,6,'12965','Order Placed','2020-10-28 14:28:29'),(8,3,'7750','Order Placed','2020-11-06 19:40:34'),(9,5,'21980','Cancelled','2020-10-28 14:25:23'),(10,6,'12965','Order Placed','2020-10-28 14:28:29'),(11,4,'7750','Order Placed','2020-11-06 19:40:34');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payments` (
  `Id` int NOT NULL,
  `OrderId` int NOT NULL,
  `PaymentDate` date NOT NULL,
  `Amount` float NOT NULL,
  `PaymentMode` varchar(10) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
INSERT INTO `payments` VALUES (231,34,'2021-04-01',5000,'UPI'),(232,34,'2021-04-07',6000,'UPI'),(234,34,'2021-04-01',2800,'UPI'),(235,31,'2021-04-11',5700,'DB'),(236,34,'2021-04-12',5000,'UPI'),(237,36,'2021-04-16',5900,'UPI'),(238,34,'2021-04-17',5000,'DBC'),(239,36,'2021-04-18',5000,'UPI'),(240,39,'2021-04-18',5000,'UPI'),(241,35,'2021-04-01',7600,'DBC'),(242,34,'2021-04-01',4800,'CRC'),(243,35,'2021-04-01',1200,'DBC'),(244,34,'2021-04-19',760,'UPI'),(246,34,'2021-04-19',5000,'UPI'),(247,35,'2021-04-20',5000,'CRC'),(248,34,'2021-04-21',5000,'UPI'),(249,354,'2021-04-21',4900,'UPI'),(250,31,'2021-04-21',8700,'CRC'),(251,34,'2021-04-22',5600,'UPI'),(252,32,'2021-04-23',9800,'UPI'),(253,31,'2021-04-24',8000,'CRC'),(254,34,'2021-04-25',5000,'UPI'),(255,32,'2021-04-25',8000,'UPI');
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products` (
  `Id` int NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Quantity` double DEFAULT NULL,
  `Title` varchar(255) DEFAULT NULL,
  `UnitPrice` double DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Best Garden Flower',20000,'Tulip',12),(3,'Diwali Celebration Flower',4500,'Marigold',12),(8,'Enterprise Server',2000,'IBM',15000),(22,'Festival Flower',20000,'Gerbera',10),(23,'Valentine Flower',5000,'Jasmine',15),(78,'Smart Phone',3,'Apple',65000),(344,'Galaxy note 10',89,'Samsung',5600);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reviews`
--

DROP TABLE IF EXISTS `reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reviews` (
  `id` int NOT NULL AUTO_INCREMENT,
  `productid` int NOT NULL,
  `userid` int NOT NULL,
  `review` text NOT NULL,
  `timestamp` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (1,1,6,'It&#39;s an awesome Product...','2017-10-30 15:18:42');
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'tap'
--
/*!50003 DROP PROCEDURE IF EXISTS `getTotalAmount` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `getTotalAmount`()
BEGIN
	SELECT SUM(TotalAmount) FROM tap.orders;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_highest_product_quantity` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_highest_product_quantity`(OUT highestQuantity INT)
BEGIN
    SELECT MAX(Quantity) INTO highestQuantity FROM tap.products;   
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-02 23:50:00
