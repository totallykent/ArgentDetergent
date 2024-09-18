/*
SQLyog Community v13.3.0 (64 bit)
MySQL - 10.4.32-MariaDB : Database - laundry
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`laundry` /*!40100 DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci */;

USE `laundry`;

/*Table structure for table `tblcustomer` */

DROP TABLE IF EXISTS `tblcustomer`;

CREATE TABLE `tblcustomer` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fullname` varchar(80) NOT NULL,
  `birthdate` date NOT NULL,
  `gender` varchar(6) NOT NULL,
  `address` varchar(150) NOT NULL,
  `contactno` varchar(11) NOT NULL,
  `emailadd` varchar(45) NOT NULL,
  `cust_photo` text DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UK_customer` (`contactno`,`emailadd`),
  KEY `idx_fullname` (`fullname`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

/*Data for the table `tblcustomer` */

/*Table structure for table `tblcustomergarments` */

DROP TABLE IF EXISTS `tblcustomergarments`;

CREATE TABLE `tblcustomergarments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `gid` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_customer` (`cid`),
  KEY `fk_garments` (`gid`),
  CONSTRAINT `fk_customer` FOREIGN KEY (`cid`) REFERENCES `tblcustomer` (`id`),
  CONSTRAINT `fk_garments` FOREIGN KEY (`gid`) REFERENCES `tblgarments` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

/*Data for the table `tblcustomergarments` */

/*Table structure for table `tblgarments` */

DROP TABLE IF EXISTS `tblgarments`;

CREATE TABLE `tblgarments` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `garment_type` varchar(45) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

/*Data for the table `tblgarments` */

/*Table structure for table `tblservices` */

DROP TABLE IF EXISTS `tblservices`;

CREATE TABLE `tblservices` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `service_type` varchar(45) NOT NULL,
  `description` varchar(100) NOT NULL,
  `price` double NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

/*Data for the table `tblservices` */

/*Table structure for table `tblstaff` */

DROP TABLE IF EXISTS `tblstaff`;

CREATE TABLE `tblstaff` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fullname` varchar(80) NOT NULL,
  `birthdate` date NOT NULL,
  `gender` varchar(6) NOT NULL,
  `address` varchar(150) NOT NULL,
  `contactno` varchar(11) DEFAULT NULL,
  `emailadd` varchar(45) DEFAULT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

/*Data for the table `tblstaff` */

/*Table structure for table `tbltransaction` */

DROP TABLE IF EXISTS `tbltransaction`;

CREATE TABLE `tbltransaction` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `cgid` int(11) NOT NULL,
  `sid` int(11) NOT NULL,
  `weight` double NOT NULL,
  `amount` double NOT NULL,
  `date_delivered` date NOT NULL,
  `date_claimed` date NOT NULL,
  `transaction_status` varchar(10) NOT NULL,
  `stffid` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_swedish_ci;

/*Data for the table `tbltransaction` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
