-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 13, 2019 at 01:51 AM
-- Server version: 10.1.37-MariaDB
-- PHP Version: 7.3.1

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

CREATE TABLE `staffinfor` (
  `StaffId` varchar(30) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Gender` varchar(15) DEFAULT NULL,
  `TelNumber` varchar(100) DEFAULT NULL,
  `Region` varchar(100) DEFAULT NULL,
  `City` varchar(100) DEFAULT NULL,
  `SubjectTeaching` varchar(100) NOT NULL,
  `DOB` varchar(16) DEFAULT NULL,
  `DateAdmitted` varchar(15) DEFAULT NULL,
  `Hobby` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staffinfor`
--

INSERT INTO `staffinfor` (`StaffId`, `FullName`, `Gender`, `TelNumber`, `Region`, `City`, `SubjectTeaching`, `DOB`, `DateAdmitted`, `Hobby`) VALUES
('mudi1234', 'Mudi Sheikh', 'female', '289643678', 'NORTHERN', 'Joli', 'French', '8/12/2019', '8/12/2019', 'eating');

-- --------------------------------------------------------

--
-- Table structure for table `studentinfor`
--

CREATE TABLE `studentinfor` (
  `FirstName` varchar(100) NOT NULL,
  `Lastname` varchar(100) NOT NULL,
  `DOB` varchar(100) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `City` varchar(30) DEFAULT NULL,
  `District` varchar(100) DEFAULT NULL,
  `Class` varchar(20) DEFAULT NULL,
  `ParentFullName` varchar(200) DEFAULT NULL,
  `Occupation` varchar(100) DEFAULT NULL,
  `ParentNumber` int(15) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `UserId` varchar(20) DEFAULT NULL,
  `UserType` varchar(100) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`UserId`, `UserType`, `Password`) VALUES
('mudi1234', 'admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `staffinfor`
--
ALTER TABLE `staffinfor`
  ADD PRIMARY KEY (`StaffId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
