-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 29, 2019 at 08:47 AM
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
-- Database: `job`
--

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `department_ID` int(11) NOT NULL,
  `dep_Manager_ID` int(11) DEFAULT NULL,
  `department_Name` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `department`
--

INSERT INTO `department` (`department_ID`, `dep_Manager_ID`, `department_Name`) VALUES
(5, 1, 'København'),
(6, 2, 'Aarhus'),
(7, 3, 'Aalborg'),
(8, 4, 'Bonnet');

-- --------------------------------------------------------

--
-- Table structure for table `dep_employee`
--

CREATE TABLE `dep_employee` (
  `dep_Employ_ID` int(11) NOT NULL,
  `department_ID` int(11) DEFAULT NULL,
  `employ_ID` int(11) DEFAULT NULL,
  `title_ID` int(11) DEFAULT NULL,
  `salary_Bonus` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dep_employee`
--

INSERT INTO `dep_employee` (`dep_Employ_ID`, `department_ID`, `employ_ID`, `title_ID`, `salary_Bonus`) VALUES
(1, 5, 2, 9, '5'),
(2, 6, 4, 9, '2'),
(3, 7, 6, 9, '6'),
(4, 8, 6, 9, '3'),
(5, 5, 1, 3, '0'),
(6, 6, 1, 3, '0'),
(7, 7, 3, 4, '1'),
(8, 8, 5, 1, '0'),
(9, 5, 7, 2, '3'),
(10, 6, 8, 10, '1'),
(11, 7, 9, 5, '2'),
(12, 8, 10, 8, '3');

-- --------------------------------------------------------

--
-- Table structure for table `dep_manager`
--

CREATE TABLE `dep_manager` (
  `dep_Manager_ID` int(11) NOT NULL,
  `department_ID` int(11) DEFAULT NULL,
  `employ_ID` int(11) DEFAULT NULL,
  `salary_Bonus` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `dep_manager`
--

INSERT INTO `dep_manager` (`dep_Manager_ID`, `department_ID`, `employ_ID`, `salary_Bonus`) VALUES
(1, 5, 2, '14'),
(2, 6, 4, '12'),
(3, 7, 6, '10'),
(4, 8, 6, '13');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `employ_ID` int(11) NOT NULL,
  `first_Name` varchar(256) DEFAULT NULL,
  `last_Name` varchar(256) DEFAULT NULL,
  `username` varchar(256) DEFAULT NULL,
  `address` varchar(256) DEFAULT NULL,
  `zip_Code` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`employ_ID`, `first_Name`, `last_Name`, `username`, `address`, `zip_Code`) VALUES
(1, 'John', 'Johnsen', 'Star-Lord', 'Bisgården 1', 7500),
(2, 'Oliver', 'Johnsen', 'Groot', 'Bisgården 2', 7500),
(3, 'James', 'Johnsen', 'Rocket', 'Bisgården 3', 7500),
(4, 'Kevin', 'Johnsen', 'Gamora', 'Bisgården 4', 7500),
(5, 'William', 'Johnsen', 'Drax', 'Bisgården 5', 7500),
(6, 'Adam', 'Adamsen', 'Yondu', 'H. C. Andersens Vej 1', 8800),
(7, 'Kevin', 'Adamsen', 'Ronan', 'H. C. Andersens Vej 2', 8800),
(8, 'William', 'Adamsen', 'Nebula', 'H. C. Andersens Vej 3', 8800),
(9, 'Oliver', 'Adamsen', 'Korath', 'H. C. Andersens Vej 4', 8800),
(10, 'James', 'Adamsen', 'Collector', 'H. C. Andersens Vej 5', 8800);

-- --------------------------------------------------------

--
-- Table structure for table `salaries`
--

CREATE TABLE `salaries` (
  `salary_ID` int(11) NOT NULL,
  `salary_Value` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `salaries`
--

INSERT INTO `salaries` (`salary_ID`, `salary_Value`) VALUES
(1, '0'),
(2, '60'),
(3, '90'),
(4, '130'),
(5, '140'),
(6, '200'),
(7, '250');

-- --------------------------------------------------------

--
-- Stand-in structure for view `showemployees`
-- (See below for the actual view)
--
CREATE TABLE `showemployees` (
`first_Name` varchar(256)
,`last_Name` varchar(256)
,`address` varchar(256)
,`zip_Code` int(20)
,`title_Name` varchar(256)
,`department_Name` varchar(256)
,`salary_Value` decimal(10,0)
,`salary_Bonus` decimal(10,0)
,`manager_Salary_Bonus` decimal(10,0)
);

-- --------------------------------------------------------

--
-- Table structure for table `titles`
--

CREATE TABLE `titles` (
  `title_ID` int(11) NOT NULL,
  `salary_ID` int(11) DEFAULT NULL,
  `title_Name` varchar(256) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `titles`
--

INSERT INTO `titles` (`title_ID`, `salary_ID`, `title_Name`) VALUES
(1, 1, 'Unpaid Intern'),
(2, 2, 'Paid Intern'),
(3, 3, 'Janitor'),
(4, 3, 'lunchlady'),
(5, 4, 'Secretary'),
(6, 5, 'Technician'),
(7, 4, 'Supporter'),
(8, 5, 'consultant'),
(9, 6, 'Manager'),
(10, 7, 'Owner');

-- --------------------------------------------------------

--
-- Structure for view `showemployees`
--
DROP TABLE IF EXISTS `showemployees`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `showemployees`  AS  select `employee`.`first_Name` AS `first_Name`,`employee`.`last_Name` AS `last_Name`,`employee`.`address` AS `address`,`employee`.`zip_Code` AS `zip_Code`,`titles`.`title_Name` AS `title_Name`,`department`.`department_Name` AS `department_Name`,`salaries`.`salary_Value` AS `salary_Value`,`dep_employee`.`salary_Bonus` AS `salary_Bonus`,`dep_manager`.`salary_Bonus` AS `manager_Salary_Bonus` from (((((`employee` join `dep_employee` on(`employee`.`employ_ID` = `dep_employee`.`employ_ID`)) left join `department` on(`department`.`department_ID` = `dep_employee`.`department_ID`)) left join `titles` on(`dep_employee`.`title_ID` = `titles`.`title_ID`)) left join `salaries` on(`titles`.`salary_ID` = `salaries`.`salary_ID`)) left join `dep_manager` on(`employee`.`employ_ID` = `dep_manager`.`employ_ID` and `dep_manager`.`department_ID` = `department`.`department_ID`)) ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`department_ID`),
  ADD KEY `dep_Manager_ID` (`dep_Manager_ID`);

--
-- Indexes for table `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD PRIMARY KEY (`dep_Employ_ID`),
  ADD KEY `department_ID` (`department_ID`),
  ADD KEY `employ_ID` (`employ_ID`),
  ADD KEY `title_ID` (`title_ID`);

--
-- Indexes for table `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD PRIMARY KEY (`dep_Manager_ID`),
  ADD KEY `department_ID` (`department_ID`),
  ADD KEY `employ_ID` (`employ_ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`employ_ID`);

--
-- Indexes for table `salaries`
--
ALTER TABLE `salaries`
  ADD PRIMARY KEY (`salary_ID`);

--
-- Indexes for table `titles`
--
ALTER TABLE `titles`
  ADD PRIMARY KEY (`title_ID`),
  ADD KEY `salary_ID` (`salary_ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `department_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `dep_employee`
--
ALTER TABLE `dep_employee`
  MODIFY `dep_Employ_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `dep_manager`
--
ALTER TABLE `dep_manager`
  MODIFY `dep_Manager_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `employ_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `salaries`
--
ALTER TABLE `salaries`
  MODIFY `salary_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `titles`
--
ALTER TABLE `titles`
  MODIFY `title_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `department`
--
ALTER TABLE `department`
  ADD CONSTRAINT `department_ibfk_1` FOREIGN KEY (`dep_Manager_ID`) REFERENCES `dep_manager` (`dep_Manager_ID`);

--
-- Constraints for table `dep_employee`
--
ALTER TABLE `dep_employee`
  ADD CONSTRAINT `dep_employee_ibfk_1` FOREIGN KEY (`department_ID`) REFERENCES `department` (`department_ID`),
  ADD CONSTRAINT `dep_employee_ibfk_2` FOREIGN KEY (`employ_ID`) REFERENCES `employee` (`employ_ID`),
  ADD CONSTRAINT `dep_employee_ibfk_3` FOREIGN KEY (`title_ID`) REFERENCES `titles` (`title_ID`);

--
-- Constraints for table `dep_manager`
--
ALTER TABLE `dep_manager`
  ADD CONSTRAINT `dep_manager_ibfk_1` FOREIGN KEY (`department_ID`) REFERENCES `department` (`department_ID`),
  ADD CONSTRAINT `dep_manager_ibfk_2` FOREIGN KEY (`employ_ID`) REFERENCES `employee` (`employ_ID`);

--
-- Constraints for table `titles`
--
ALTER TABLE `titles`
  ADD CONSTRAINT `titles_ibfk_1` FOREIGN KEY (`salary_ID`) REFERENCES `salaries` (`salary_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
