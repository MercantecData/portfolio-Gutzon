-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 11, 2019 at 11:44 AM
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
-- Database: `gamestore`
--

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `id` int(11) NOT NULL,
  `NAME` text DEFAULT NULL,
  `publishing_year` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`id`, `NAME`, `publishing_year`) VALUES
(1, 'Red Dead Redemption 2', 2018),
(2, 'Marvels Spiderman', 2018),
(3, 'Portal', 2007);

-- --------------------------------------------------------

--
-- Table structure for table `opening_hours`
--

CREATE TABLE `opening_hours` (
  `id` int(11) NOT NULL,
  `locationID` int(11) NOT NULL,
  `DAY` date NOT NULL,
  `opening_time` time DEFAULT NULL,
  `closing_time` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `opening_hours`
--

INSERT INTO `opening_hours` (`id`, `locationID`, `DAY`, `opening_time`, `closing_time`) VALUES
(1, 1, '2019-12-17', '10:00:00', '18:30:00'),
(2, 2, '2019-12-17', '09:45:00', '17:00:00'),
(3, 3, '2019-12-17', '06:00:00', '22:20:00'),
(4, 1, '2019-12-20', '10:00:00', '18:30:00'),
(5, 2, '2019-12-20', '10:00:00', '18:30:00'),
(6, 3, '2019-12-21', '10:00:00', '18:30:00'),
(7, 2, '2019-12-22', '10:00:00', '18:30:00'),
(8, 1, '2019-12-25', '10:00:00', '18:30:00');

-- --------------------------------------------------------

--
-- Table structure for table `physical_items`
--

CREATE TABLE `physical_items` (
  `id` int(11) NOT NULL,
  `itemID` int(11) DEFAULT NULL,
  `locationID` int(11) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `physical_items`
--

INSERT INTO `physical_items` (`id`, `itemID`, `locationID`, `stock`) VALUES
(1, 1, 1, 100),
(2, 1, 2, 150),
(3, 1, 3, 50),
(4, 2, 2, 200),
(5, 2, 3, 20),
(6, 3, 1, 2),
(7, 1, 1, NULL),
(8, 3, 2, NULL),
(9, 1, 1, NULL),
(10, 1, 1, NULL),
(11, 1, 1, NULL),
(12, 1, 1, NULL),
(13, 2, 2, NULL),
(14, 1, 1, NULL),
(15, 3, 1, NULL),
(16, 2, 1, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `store_location`
--

CREATE TABLE `store_location` (
  `id` int(11) NOT NULL,
  `NAME` text DEFAULT NULL,
  `earnings` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `store_location`
--

INSERT INTO `store_location` (`id`, `NAME`, `earnings`) VALUES
(1, 'Aalborg', 65000),
(2, 'Viborg', 83000),
(3, 'København', 65000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `opening_hours`
--
ALTER TABLE `opening_hours`
  ADD PRIMARY KEY (`id`),
  ADD KEY `locationID` (`locationID`);

--
-- Indexes for table `physical_items`
--
ALTER TABLE `physical_items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `itemID` (`itemID`),
  ADD KEY `locationID` (`locationID`);

--
-- Indexes for table `store_location`
--
ALTER TABLE `store_location`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `opening_hours`
--
ALTER TABLE `opening_hours`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `physical_items`
--
ALTER TABLE `physical_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `store_location`
--
ALTER TABLE `store_location`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `opening_hours`
--
ALTER TABLE `opening_hours`
  ADD CONSTRAINT `opening_hours_ibfk_1` FOREIGN KEY (`locationID`) REFERENCES `store_location` (`id`);

--
-- Constraints for table `physical_items`
--
ALTER TABLE `physical_items`
  ADD CONSTRAINT `physical_items_ibfk_1` FOREIGN KEY (`itemID`) REFERENCES `items` (`id`),
  ADD CONSTRAINT `physical_items_ibfk_2` FOREIGN KEY (`locationID`) REFERENCES `store_location` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
