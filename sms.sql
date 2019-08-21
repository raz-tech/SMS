-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Aug 14, 2019 at 10:50 PM
-- Server version: 5.7.23
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sms`
--

-- --------------------------------------------------------

--
-- Table structure for table `staffinfor`
--

DROP TABLE IF EXISTS `staffinfor`;
CREATE TABLE IF NOT EXISTS `staffinfor` (
  `StaffId` varchar(30) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Gender` varchar(15) DEFAULT NULL,
  `TelNumber` varchar(100) DEFAULT NULL,
  `Region` varchar(100) DEFAULT NULL,
  `City` varchar(100) DEFAULT NULL,
  `SubjectTeaching` varchar(100) NOT NULL,
  `DOB` varchar(16) DEFAULT NULL,
  `DateAdmitted` varchar(15) DEFAULT NULL,
  `Hobby` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`StaffId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staffinfor`
--

INSERT INTO `staffinfor` (`StaffId`, `FullName`, `Gender`, `TelNumber`, `Region`, `City`, `SubjectTeaching`, `DOB`, `DateAdmitted`, `Hobby`) VALUES
('mudi1234', 'Mudi Sheikh', 'female', '289643678', 'NORTHERN', 'Joli', 'French', '8/12/2019', '8/12/2019', 'eating'),
('Rash2211', 'Zakaria Rashida', 'FEMALE', '05533432', 'NORTHERN', 'Tamale', 'Biochem', '8/12/2019', '8/12/2019', 'Reading');

-- --------------------------------------------------------

--
-- Table structure for table `studentinfor`
--

DROP TABLE IF EXISTS `studentinfor`;
CREATE TABLE IF NOT EXISTS `studentinfor` (
  `FirstName` varchar(100) NOT NULL,
  `Lastname` varchar(100) NOT NULL,
  `DOB` varchar(100) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `City` varchar(30) DEFAULT NULL,
  `District` varchar(100) DEFAULT NULL,
  `Class` varchar(20) DEFAULT NULL,
  `ParentContact` varchar(200) DEFAULT NULL,
  `ParentFullName` varchar(100) DEFAULT NULL,
  `Occupation` varchar(150) DEFAULT NULL,
  `MOMONumber` varchar(16) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `studentinfor`
--

INSERT INTO `studentinfor` (`FirstName`, `Lastname`, `DOB`, `Address`, `Gender`, `City`, `District`, `Class`, `ParentContact`, `ParentFullName`, `Occupation`, `MOMONumber`) VALUES
('Zak', 'Kamal', '8/13/2019', '', 'FEMALE', 'Tamale', 'Tamale Sourth', 'Three', '054930932', 'Zakaria Kamal', '', ''),
('Fataw', 'jalil', '8/13/2019', 'lah 44', 'male', 'tam', 'gum', 'TWO', '0549041452', 'jalil fat', 'teacher', '0549041452');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `UserId` varchar(20) DEFAULT NULL,
  `UserType` varchar(100) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserId`, `UserType`, `Password`) VALUES
('mudi1234', 'admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),
('Rash2211', 'teacher', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
