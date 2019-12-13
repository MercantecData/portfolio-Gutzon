-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 13, 2019 at 05:32 AM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `triggers`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `add_name_to_foo` (IN `name` TEXT)  BEGIN
	INSERT INTO foo (name) VALUES (name);
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

CREATE TABLE `cars` (
  `id` int(11) NOT NULL,
  `owner_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cars`
--

INSERT INTO `cars` (`id`, `owner_id`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4);

--
-- Triggers `cars`
--
DELIMITER $$
CREATE TRIGGER `delete_person` BEFORE DELETE ON `cars` FOR EACH ROW BEGIN
DELETE FROM foo WHERE foo.name = (SELECT name FROM persons WHERE persons.id = OLD.owner_id);
DELETE FROM persons WHERE persons.id = OLD.owner_id;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `foo`
--

CREATE TABLE `foo` (
  `id` int(11) NOT NULL,
  `name` text DEFAULT NULL,
  `modified` datetime DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `foo`
--

INSERT INTO `foo` (`id`, `name`, `modified`) VALUES
(1, 'Jack', '2019-12-13 04:45:04');

-- --------------------------------------------------------

--
-- Table structure for table `persons`
--

CREATE TABLE `persons` (
  `id` int(11) NOT NULL,
  `name` text DEFAULT NULL,
  `modified` datetime DEFAULT NULL ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `persons`
--

INSERT INTO `persons` (`id`, `name`, `modified`) VALUES
(1, 'Jack', NULL),
(2, 'Jack', NULL),
(3, 'Jill', NULL),
(4, 'Paul', NULL);

--
-- Triggers `persons`
--
DELIMITER $$
CREATE TRIGGER `add_to_foo` AFTER INSERT ON `persons` FOR EACH ROW call add_name_to_foo(NEW.name)
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `delete_cars` BEFORE DELETE ON `persons` FOR EACH ROW BEGIN
DELETE FROM cars WHERE cars.owner_id = OLD.id;
END
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `new_car` AFTER INSERT ON `persons` FOR EACH ROW INSERT INTO cars (owner_id) VALUES (NEW.id)
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`id`),
  ADD KEY `owner_id` (`owner_id`);

--
-- Indexes for table `foo`
--
ALTER TABLE `foo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `persons`
--
ALTER TABLE `persons`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cars`
--
ALTER TABLE `cars`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `foo`
--
ALTER TABLE `foo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `persons`
--
ALTER TABLE `persons`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cars`
--
ALTER TABLE `cars`
  ADD CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`owner_id`) REFERENCES `persons` (`id`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
