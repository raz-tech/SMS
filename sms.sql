-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2020 at 05:28 PM
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
-- Table structure for table `examresult`
--

CREATE TABLE `examresult` (
  `id` int(11) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `academicYear` varchar(255) NOT NULL,
  `term` varchar(255) NOT NULL,
  `endTerm` varchar(255) NOT NULL,
  `midTerm` varchar(255) NOT NULL,
  `totalMark` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `examresult`
--

INSERT INTO `examresult` (`id`, `firstName`, `lastName`, `academicYear`, `term`, `endTerm`, `midTerm`, `totalMark`) VALUES
(1, '', '', '', '', '', '', ''),
(2, 'mudi', 'mudi', '2012/13', 'ONE ', '75', '25', '7525'),
(3, '', '', '', '', '50', '25', '5025'),
(4, '', '', '', '', '2', '12', '122'),
(5, '', '', '', '', '22', '12', '34'),
(6, '', '', '', '', '', '', '0'),
(7, '', '', '', '', '', '', '0'),
(8, '', '', '', '', '', '', '0'),
(9, '', '', '', '', '', '', '0'),
(10, 'v', 'h', '2012/13', 'ONE ', '70', '23', '93'),
(11, '', '', '', '', '', '', '0'),
(12, 'Manhmud', 'Suleman', '2012/13', 'ONE ', 'ooo', 'kk', '0');

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
('rash2211', 'Mudi Sheikh', 'female', '289643678', 'NORTHERN', 'Tamale,Ghana', 'French', '8/12/2019', '8/12/2019', 'FootBall'),
('abcd', 'mmmmmm', 'male', '554555', 'GREATER ACCRA', 'jjjhh', 'bhhj', '8/28/2019', '8/28/2019', 'oiuu');

-- --------------------------------------------------------

--
-- Table structure for table `studentinfor`
--

CREATE TABLE `studentinfor` (
  `StudentId` varchar(150) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `Lastname` varchar(100) NOT NULL,
  `otherName` varchar(200) NOT NULL,
  `DOB` varchar(100) NOT NULL,
  `Gender` varchar(10) DEFAULT NULL,
  `Class` varchar(20) DEFAULT NULL,
  `FatherContact` varchar(200) DEFAULT NULL,
  `FatherFirstName` varchar(100) DEFAULT NULL,
  `FatherLastName` varchar(150) DEFAULT NULL,
  `FatherAddress` varchar(200) DEFAULT NULL,
  `FatherEmail` varchar(200) NOT NULL,
  `MotherFirstName` varchar(200) NOT NULL,
  `MotherLastName` varchar(200) NOT NULL,
  `MotherContact` varchar(20) NOT NULL,
  `MotherAddress` varchar(200) NOT NULL,
  `MotherEmail` varchar(200) NOT NULL
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
('mudi1234', 'admin', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),
('Rash2211', 'teacher', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4'),
('abcd', 'teacher', '03ac674216f3e15c761ee1a5e255f067953623c8b388b4459e13f978d7c846f4');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `examresult`
--
ALTER TABLE `examresult`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `staffinfor`
--
ALTER TABLE `staffinfor`
  ADD PRIMARY KEY (`StaffId`);

--
-- Indexes for table `studentinfor`
--
ALTER TABLE `studentinfor`
  ADD PRIMARY KEY (`StudentId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `examresult`
--
ALTER TABLE `examresult`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
