/*
SQLyog Community v13.1.2 (64 bit)
MySQL - 10.1.38-MariaDB-0+deb9u1 : Database - CSFINAL
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`CSFINAL` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `CSFINAL`;

/*Table structure for table `department` */

DROP TABLE IF EXISTS `department`;

CREATE TABLE `department` (
  `dpNo` int(11) NOT NULL AUTO_INCREMENT,
  `dpName` varchar(15) DEFAULT NULL,
  `dpLocate` varchar(30) DEFAULT NULL,
  `dpPhone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`dpNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `doctor` */

DROP TABLE IF EXISTS `doctor`;

CREATE TABLE `doctor` (
  `dNo` int(11) NOT NULL AUTO_INCREMENT,
  `dName` varchar(10) DEFAULT NULL,
  `dDepart` int(11) DEFAULT NULL,
  `dReginum` varchar(15) DEFAULT NULL,
  `dAddr` varchar(50) DEFAULT NULL,
  `dPhone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`dNo`),
  KEY `dDepart` (`dDepart`),
  CONSTRAINT `doctor_ibfk_1` FOREIGN KEY (`dDepart`) REFERENCES `department` (`dpNo`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `medirecord` */

DROP TABLE IF EXISTS `medirecord`;

CREATE TABLE `medirecord` (
  `tNo` int(11) NOT NULL AUTO_INCREMENT,
  `pNo` int(11) DEFAULT NULL,
  `dNo` int(11) DEFAULT NULL,
  `dpNo` int(11) DEFAULT NULL,
  `tDate` datetime DEFAULT NULL,
  PRIMARY KEY (`tNo`),
  KEY `pNo` (`pNo`),
  KEY `dNo` (`dNo`),
  KEY `dpNo` (`dpNo`),
  CONSTRAINT `medirecord_ibfk_1` FOREIGN KEY (`pNo`) REFERENCES `patient` (`pNo`) ON DELETE CASCADE,
  CONSTRAINT `medirecord_ibfk_2` FOREIGN KEY (`dNo`) REFERENCES `doctor` (`dNo`) ON DELETE CASCADE,
  CONSTRAINT `medirecord_ibfk_3` FOREIGN KEY (`dpNo`) REFERENCES `department` (`dpNo`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Table structure for table `patient` */

DROP TABLE IF EXISTS `patient`;

CREATE TABLE `patient` (
  `pNo` int(11) NOT NULL AUTO_INCREMENT,
  `pName` varchar(10) DEFAULT NULL,
  `pReginum` varchar(15) DEFAULT NULL,
  `pAddr` varchar(50) DEFAULT NULL,
  `pPhone` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`pNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
