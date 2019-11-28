-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2019 at 12:49 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `shop`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteOrder` (IN `number` INT(20))  BEGIN
    DELETE FROM `orderss`
    WHERE `orderNumber` = number ;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `addresses`
--

CREATE TABLE `addresses` (
  `addr_ID` int(11) NOT NULL,
  `customer_ID` int(11) DEFAULT NULL,
  `address` varchar(256) DEFAULT NULL,
  `city` varchar(256) DEFAULT NULL,
  `zip_Code` varchar(256) DEFAULT NULL,
  `country` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `addresses`
--

INSERT INTO `addresses` (`addr_ID`, `customer_ID`, `address`, `city`, `zip_Code`, `country`) VALUES
(1, 1, 'Bisgården 1', 'Holstebro', '7500', 'Danmark'),
(2, 2, 'Bisgården 2', 'Holstebro', '7500', 'Danmark'),
(3, 3, 'Bisgården 3', 'Holstebro', '7500', 'Danmark'),
(4, 4, 'Bisgården 4', 'Holstebro', '7500', 'Danmark'),
(5, 5, 'Bisgården 5', 'Holstebro', '7500', 'Danmark'),
(6, 6, 'H. C. Andersens Vej 1', 'Viborg', '8800', 'Danmark'),
(7, 7, 'H. C. Andersens Vej 2', 'Viborg', '8800', 'Danmark'),
(8, 8, 'H. C. Andersens Vej 3', 'Viborg', '8800', 'Danmark'),
(9, 9, 'H. C. Andersens Vej 4', 'Viborg', '8800', 'Danmark'),
(10, 10, 'H. C. Andersens Vej 5', 'Viborg', '8800', 'Danmark');

-- --------------------------------------------------------

--
-- Stand-in structure for view `completeorderview`
-- (See below for the actual view)
--
CREATE TABLE `completeorderview` (
`orderNumber` int(20)
,`prod_Name` varchar(256)
,`prod_Description` varchar(256)
,`prod_Price` decimal(24,0)
,`first_Name` varchar(256)
,`last_Name` varchar(256)
,`email` varchar(256)
,`username` varchar(256)
,`address` varchar(256)
,`zip_Code` varchar(256)
,`city` varchar(256)
,`country` varchar(256)
);

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customerID` int(11) NOT NULL,
  `first_Name` varchar(256) DEFAULT NULL,
  `email` varchar(256) DEFAULT NULL,
  `last_Name` varchar(256) DEFAULT NULL,
  `username` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customerID`, `first_Name`, `email`, `last_Name`, `username`) VALUES
(1, 'John', 'sample@sample.net', 'Johnsen', 'Starlord'),
(2, 'Adam', 'sample2@sample.net', 'Adamsen', 'Groot'),
(3, 'Kevin', 'sample3@sample.net', 'Adamsen', 'Rocket'),
(4, 'William', 'sample4@sample.net', 'Adamsen', 'Gamora'),
(5, 'Oliver', 'sample5@sample.net', 'Johnsen', 'Drax'),
(6, 'Oliver', 'sample6@sample.net', 'Adamsen', 'Yondu'),
(7, 'James', 'sample7@sample.net', 'Johnsen', 'Ronan'),
(8, 'Kevin', 'sample8@sample.net', 'Johnsen', 'Nebula'),
(9, 'James', 'sample9@sample.net', 'Adamsen', 'Korath'),
(10, 'William', 'sample1@sample.net', 'Johnsen', 'Collector');

-- --------------------------------------------------------

--
-- Stand-in structure for view `orderaddr`
-- (See below for the actual view)
--
CREATE TABLE `orderaddr` (
`order_ID` int(11)
,`orderNumber` int(20)
,`address` varchar(256)
,`zip_Code` varchar(256)
,`city` varchar(256)
,`country` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `ordercustomer`
-- (See below for the actual view)
--
CREATE TABLE `ordercustomer` (
`order_ID` int(11)
,`orderNumber` int(20)
,`first_Name` varchar(256)
,`last_Name` varchar(256)
,`email` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `orderprodcustomer`
-- (See below for the actual view)
--
CREATE TABLE `orderprodcustomer` (
`orderNumber` int(20)
,`prod_Name` varchar(256)
,`prod_Description` varchar(256)
,`prod_Price` decimal(24,0)
,`first_Name` varchar(256)
,`last_Name` varchar(256)
,`email` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Table structure for table `orderss`
--

CREATE TABLE `orderss` (
  `order_ID` int(11) NOT NULL,
  `prod_ID` int(11) NOT NULL,
  `customer_ID` int(11) DEFAULT NULL,
  `addr_ID` int(11) DEFAULT NULL,
  `orderNumber` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `orderss`
--

INSERT INTO `orderss` (`order_ID`, `prod_ID`, `customer_ID`, `addr_ID`, `orderNumber`) VALUES
(2, 5, 1, NULL, 101),
(3, 5, 5, NULL, 102),
(4, 6, 1, NULL, 101),
(5, 9, 4, NULL, 103),
(6, 2, 1, NULL, 101),
(7, 10, 1, NULL, 101),
(10, 3, 2, NULL, 106),
(11, 4, 2, NULL, 106);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `prod_ID` int(11) NOT NULL,
  `prod_Name` varchar(256) DEFAULT NULL,
  `prod_Description` varchar(256) DEFAULT NULL,
  `prod_Price` decimal(24,0) DEFAULT NULL,
  `prod_Stock` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`prod_ID`, `prod_Name`, `prod_Description`, `prod_Price`, `prod_Stock`) VALUES
(1, 'Mac Candle No. 2', 'Features strong notes of armoise and bergamot, with hints of lemon, tarragon, amber and musk to help clear the mind of cutter and stimulate creativity\r\nApple-inspired ceramic vessel\r\n95 ounce candle with a burn time of 60-70 hours\r\nLimited edition, only av', '204', 100),
(2, 'Comfycup', 'THE ORIGINAL COMFYCUP! (Beware of cheap copycats) TAKE YOUR MORNING COFFEE CUP WITH YOU! and ENJOY a Comfy & Productive Commute with your new Colorful Cup Holder! Comfycup is a No tools cup holder, simply clamp and go!', '115', 10),
(3, 'Wilton Edible Glitter', 'Gold stars add a dazzling touch to cakes, cookies, cupcakes and candies', '40', 500),
(4, 'Guacamole Bowl', 'PERFECT GUACAMOLE BOWL: Make your next party a Fieasta! The Prepworks by Progressive Guacamole Bowl is great for serving your home made Guacamole and more!', '70', 25),
(5, 'The Official \'A Game of Thrones\' Coloring Book', 'NEW YORK TIMES BESTSELLER • Perfect for fans of George R. R. Martin’s A Song of Ice and Fire and HBO’s Game of Thrones, this one-of-a-kind adult coloring book features forty-five exclusive illustrations!', '85', 200),
(6, 'Chia Pet Gremlin', 'Chia Pet Gremlin Decorative Pottery Planter, Gizmo', '140', 1000),
(7, 'Lifelike Elephant Inflatable', 'Specialty free standing realistic elephant inch tall hoopla game features!', '1450', 5),
(8, 'Meat Shredder Claws', 'Heavy-duty stainless Steel meat claws are designed for handling larger pieces of meat', '120', 42),
(9, 'Lizard Glow Bowling Ball', 'Coverstock: Plastic Featuring: Lizard Eye Glows in blacklight Finish: Rubbing and Finishing Compound Single Buff Recommended Lane Condition: Any', '680', 33),
(10, 'Inflatable Sloth Float', 'PHOTO FRIENDLY: This photogenic sloth pool float is adorably cute and irresistible to all ages - perfect for Instagram-worthy photos!', '80', 95);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showadam`
-- (See below for the actual view)
--
CREATE TABLE `showadam` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showadamsen`
-- (See below for the actual view)
--
CREATE TABLE `showadamsen` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showaddrindenmark`
-- (See below for the actual view)
--
CREATE TABLE `showaddrindenmark` (
`address` varchar(256)
,`zip_Code` varchar(256)
,`city` varchar(256)
,`country` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showaddrinholstebro`
-- (See below for the actual view)
--
CREATE TABLE `showaddrinholstebro` (
`address` varchar(256)
,`zip_Code` varchar(256)
,`city` varchar(256)
,`country` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showjames`
-- (See below for the actual view)
--
CREATE TABLE `showjames` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showjohn`
-- (See below for the actual view)
--
CREATE TABLE `showjohn` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showjohnsen`
-- (See below for the actual view)
--
CREATE TABLE `showjohnsen` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showkevin`
-- (See below for the actual view)
--
CREATE TABLE `showkevin` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showoliver`
-- (See below for the actual view)
--
CREATE TABLE `showoliver` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `showwilliam`
-- (See below for the actual view)
--
CREATE TABLE `showwilliam` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`username` varchar(256)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `usernameaddr`
-- (See below for the actual view)
--
CREATE TABLE `usernameaddr` (
`username` varchar(256)
,`address` varchar(256)
);

-- --------------------------------------------------------

--
-- Structure for view `completeorderview`
--
DROP TABLE IF EXISTS `completeorderview`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `completeorderview`  AS  select `orderss`.`orderNumber` AS `orderNumber`,`products`.`prod_Name` AS `prod_Name`,`products`.`prod_Description` AS `prod_Description`,`products`.`prod_Price` AS `prod_Price`,`customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`email` AS `email`,`customers`.`username` AS `username`,`addresses`.`address` AS `address`,`addresses`.`zip_Code` AS `zip_Code`,`addresses`.`city` AS `city`,`addresses`.`country` AS `country` from (((`orderss` left join `products` on(`orderss`.`prod_ID` = `products`.`prod_ID`)) left join `customers` on(`customers`.`customerID` = `orderss`.`customer_ID`)) left join `addresses` on(`customers`.`customerID` = `addresses`.`customer_ID`)) ;

-- --------------------------------------------------------

--
-- Structure for view `orderaddr`
--
DROP TABLE IF EXISTS `orderaddr`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `orderaddr`  AS  select `orderss`.`order_ID` AS `order_ID`,`orderss`.`orderNumber` AS `orderNumber`,`addresses`.`address` AS `address`,`addresses`.`zip_Code` AS `zip_Code`,`addresses`.`city` AS `city`,`addresses`.`country` AS `country` from (`orderss` left join `addresses` on(`orderss`.`customer_ID` = `addresses`.`customer_ID`)) ;

-- --------------------------------------------------------

--
-- Structure for view `ordercustomer`
--
DROP TABLE IF EXISTS `ordercustomer`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ordercustomer`  AS  select `orderss`.`order_ID` AS `order_ID`,`orderss`.`orderNumber` AS `orderNumber`,`customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`email` AS `email`,`customers`.`username` AS `username` from (`orderss` left join `customers` on(`orderss`.`customer_ID` = `customers`.`customerID`)) ;

-- --------------------------------------------------------

--
-- Structure for view `orderprodcustomer`
--
DROP TABLE IF EXISTS `orderprodcustomer`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `orderprodcustomer`  AS  select `orderss`.`orderNumber` AS `orderNumber`,`products`.`prod_Name` AS `prod_Name`,`products`.`prod_Description` AS `prod_Description`,`products`.`prod_Price` AS `prod_Price`,`customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`email` AS `email`,`customers`.`username` AS `username` from ((`orderss` left join `products` on(`orderss`.`prod_ID` = `products`.`prod_ID`)) left join `customers` on(`customers`.`customerID` = `orderss`.`customer_ID`)) ;

-- --------------------------------------------------------

--
-- Structure for view `showadam`
--
DROP TABLE IF EXISTS `showadam`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showadam`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`first_Name` = 'Adam' ;

-- --------------------------------------------------------

--
-- Structure for view `showadamsen`
--
DROP TABLE IF EXISTS `showadamsen`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showadamsen`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`last_Name` = 'Adamsen' ;

-- --------------------------------------------------------

--
-- Structure for view `showaddrindenmark`
--
DROP TABLE IF EXISTS `showaddrindenmark`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showaddrindenmark`  AS  select `addresses`.`address` AS `address`,`addresses`.`zip_Code` AS `zip_Code`,`addresses`.`city` AS `city`,`addresses`.`country` AS `country` from `addresses` where `addresses`.`country` = 'Danmark' ;

-- --------------------------------------------------------

--
-- Structure for view `showaddrinholstebro`
--
DROP TABLE IF EXISTS `showaddrinholstebro`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showaddrinholstebro`  AS  select `addresses`.`address` AS `address`,`addresses`.`zip_Code` AS `zip_Code`,`addresses`.`city` AS `city`,`addresses`.`country` AS `country` from `addresses` where `addresses`.`zip_Code` = 7500 ;

-- --------------------------------------------------------

--
-- Structure for view `showjames`
--
DROP TABLE IF EXISTS `showjames`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showjames`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`first_Name` = 'James' ;

-- --------------------------------------------------------

--
-- Structure for view `showjohn`
--
DROP TABLE IF EXISTS `showjohn`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showjohn`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`first_Name` = 'John' ;

-- --------------------------------------------------------

--
-- Structure for view `showjohnsen`
--
DROP TABLE IF EXISTS `showjohnsen`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showjohnsen`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`last_Name` = 'Johnsen' ;

-- --------------------------------------------------------

--
-- Structure for view `showkevin`
--
DROP TABLE IF EXISTS `showkevin`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showkevin`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`first_Name` = 'Kevin' ;

-- --------------------------------------------------------

--
-- Structure for view `showoliver`
--
DROP TABLE IF EXISTS `showoliver`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showoliver`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`first_Name` = 'Oliver' ;

-- --------------------------------------------------------

--
-- Structure for view `showwilliam`
--
DROP TABLE IF EXISTS `showwilliam`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showwilliam`  AS  select `customers`.`first_Name` AS `first_Name`,`customers`.`last_Name` AS `last_Name`,`customers`.`username` AS `username` from `customers` where `customers`.`first_Name` = 'William' ;

-- --------------------------------------------------------

--
-- Structure for view `usernameaddr`
--
DROP TABLE IF EXISTS `usernameaddr`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `usernameaddr`  AS  select `customers`.`username` AS `username`,`addresses`.`address` AS `address` from (`customers` left join `addresses` on(`addresses`.`customer_ID` = `customers`.`customerID`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addresses`
--
ALTER TABLE `addresses`
  ADD PRIMARY KEY (`addr_ID`),
  ADD KEY `customer_ID` (`customer_ID`) USING BTREE;

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customerID`);

--
-- Indexes for table `orderss`
--
ALTER TABLE `orderss`
  ADD PRIMARY KEY (`order_ID`),
  ADD KEY `customer_ID` (`customer_ID`),
  ADD KEY `addr_ID` (`addr_ID`),
  ADD KEY `prod_ID` (`prod_ID`) USING BTREE;

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`prod_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addresses`
--
ALTER TABLE `addresses`
  MODIFY `addr_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customerID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `orderss`
--
ALTER TABLE `orderss`
  MODIFY `order_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `addresses`
--
ALTER TABLE `addresses`
  ADD CONSTRAINT `addresses_ibfk_1` FOREIGN KEY (`customer_ID`) REFERENCES `customers` (`customerID`);

--
-- Constraints for table `orderss`
--
ALTER TABLE `orderss`
  ADD CONSTRAINT `orderss_ibfk_1` FOREIGN KEY (`prod_ID`) REFERENCES `products` (`prod_ID`),
  ADD CONSTRAINT `orderss_ibfk_2` FOREIGN KEY (`customer_ID`) REFERENCES `customers` (`customerID`),
  ADD CONSTRAINT `orderss_ibfk_3` FOREIGN KEY (`addr_ID`) REFERENCES `addresses` (`addr_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
