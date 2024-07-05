-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2024 at 02:16 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ordinanca_syve`
--

-- --------------------------------------------------------

--
-- Table structure for table `administrata`
--

CREATE TABLE `administrata` (
  `AdministratorID` int(11) NOT NULL,
  `Emri` varchar(20) NOT NULL,
  `Mbiemri` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `administrata`
--

INSERT INTO `administrata` (`AdministratorID`, `Emri`, `Mbiemri`, `Email`, `Password`) VALUES
(1, 'Admin1', 'mAdmin1', 'admin1@gmail.com', '$2a$10$6PAxgiSFIHShFMp0wwaXgu5JQ6MYITydWZjp/7zpdMhZLOlqR4Dhq');

-- --------------------------------------------------------

--
-- Table structure for table `doktori`
--

CREATE TABLE `doktori` (
  `DoktorID` int(11) NOT NULL,
  `Emri` varchar(20) NOT NULL,
  `Mbiemri` varchar(20) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Mosha` int(11) NOT NULL,
  `KlinikaID` int(11) NOT NULL,
  `Password` varchar(60) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `doktori`
--

INSERT INTO `doktori` (`DoktorID`, `Emri`, `Mbiemri`, `Email`, `Mosha`, `KlinikaID`, `Password`) VALUES
(1, 'Doktor1', 'mDoktor1', 'dok1@gmail.com', 50, 1, '$2a$10$2tKlKGCueMkrGzKaQPS.BuMv23uUNE3d1Hf3lhsYnt./7GANQrzmi');

-- --------------------------------------------------------

--
-- Table structure for table `historia`
--

CREATE TABLE `historia` (
  `HistoriaID` int(11) NOT NULL,
  `PacientID` int(11) NOT NULL,
  `DoktorID` int(11) NOT NULL,
  `KohaTerminit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `historia`
--

INSERT INTO `historia` (`HistoriaID`, `PacientID`, `DoktorID`, `KohaTerminit`) VALUES
(1, 1, 1, '2024-05-08 13:23:53'),
(2, 2, 1, '2024-05-08 13:53:53');

-- --------------------------------------------------------

--
-- Table structure for table `klinika`
--

CREATE TABLE `klinika` (
  `KlinikaID` int(11) NOT NULL,
  `Lokacioni` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `klinika`
--

INSERT INTO `klinika` (`KlinikaID`, `Lokacioni`) VALUES
(1, 'Prishtine'),
(2, 'Prizren');

-- --------------------------------------------------------

--
-- Table structure for table `pacienti`
--

CREATE TABLE `pacienti` (
  `PacientID` int(11) NOT NULL,
  `Emri` varchar(20) NOT NULL,
  `Mbiemri` varchar(20) NOT NULL,
  `NrTel` varchar(50) NOT NULL,
  `Mosha` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pacienti`
--

INSERT INTO `pacienti` (`PacientID`, `Emri`, `Mbiemri`, `NrTel`, `Mosha`) VALUES
(1, 'Pacient1', 'mPacient1', '045123123', 9),
(2, 'Pacient2', 'mPacient2', '045123124', 12);

-- --------------------------------------------------------

--
-- Table structure for table `raporti`
--

CREATE TABLE `raporti` (
  `RaportID` int(11) NOT NULL,
  `EmriDiagnozes` varchar(30) NOT NULL,
  `PershkrimiDiagnozes` text NOT NULL,
  `PacientID` int(11) NOT NULL,
  `DoktorID` int(11) NOT NULL,
  `KohaShkrimitRaportit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `raporti`
--

INSERT INTO `raporti` (`RaportID`, `EmriDiagnozes`, `PershkrimiDiagnozes`, `PacientID`, `DoktorID`, `KohaShkrimitRaportit`) VALUES
(1, 'Diagnoza 1', 'RaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportRaportv', 1, 1, '2024-05-08 13:27:16');

-- --------------------------------------------------------

--
-- Table structure for table `rradha`
--

CREATE TABLE `rradha` (
  `TakimiID` int(11) NOT NULL,
  `DoktorID` int(11) NOT NULL,
  `PacientID` int(11) NOT NULL,
  `KohaTakimit` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `administrata`
--
ALTER TABLE `administrata`
  ADD PRIMARY KEY (`AdministratorID`),
  ADD UNIQUE KEY `Email` (`Email`);

--
-- Indexes for table `doktori`
--
ALTER TABLE `doktori`
  ADD PRIMARY KEY (`DoktorID`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD KEY `doktori` (`KlinikaID`);

--
-- Indexes for table `historia`
--
ALTER TABLE `historia`
  ADD PRIMARY KEY (`HistoriaID`),
  ADD KEY `DoktorID` (`DoktorID`),
  ADD KEY `PacientID` (`PacientID`);

--
-- Indexes for table `klinika`
--
ALTER TABLE `klinika`
  ADD PRIMARY KEY (`KlinikaID`);

--
-- Indexes for table `pacienti`
--
ALTER TABLE `pacienti`
  ADD PRIMARY KEY (`PacientID`);

--
-- Indexes for table `raporti`
--
ALTER TABLE `raporti`
  ADD PRIMARY KEY (`RaportID`),
  ADD KEY `raporti` (`PacientID`),
  ADD KEY `DoktorID` (`DoktorID`);

--
-- Indexes for table `rradha`
--
ALTER TABLE `rradha`
  ADD PRIMARY KEY (`TakimiID`),
  ADD KEY `DoktorID` (`DoktorID`),
  ADD KEY `PacientID` (`PacientID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `administrata`
--
ALTER TABLE `administrata`
  MODIFY `AdministratorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `doktori`
--
ALTER TABLE `doktori`
  MODIFY `DoktorID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `historia`
--
ALTER TABLE `historia`
  MODIFY `HistoriaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `klinika`
--
ALTER TABLE `klinika`
  MODIFY `KlinikaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `pacienti`
--
ALTER TABLE `pacienti`
  MODIFY `PacientID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `raporti`
--
ALTER TABLE `raporti`
  MODIFY `RaportID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `rradha`
--
ALTER TABLE `rradha`
  MODIFY `TakimiID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `doktori`
--
ALTER TABLE `doktori`
  ADD CONSTRAINT `doktori` FOREIGN KEY (`KlinikaID`) REFERENCES `klinika` (`KlinikaID`);

--
-- Constraints for table `historia`
--
ALTER TABLE `historia`
  ADD CONSTRAINT `historia_ibfk_1` FOREIGN KEY (`DoktorID`) REFERENCES `doktori` (`DoktorID`),
  ADD CONSTRAINT `historia_ibfk_2` FOREIGN KEY (`PacientID`) REFERENCES `pacienti` (`PacientID`);

--
-- Constraints for table `raporti`
--
ALTER TABLE `raporti`
  ADD CONSTRAINT `raporti` FOREIGN KEY (`PacientID`) REFERENCES `pacienti` (`PacientID`),
  ADD CONSTRAINT `raporti_ibfk_1` FOREIGN KEY (`DoktorID`) REFERENCES `doktori` (`DoktorID`);

--
-- Constraints for table `rradha`
--
ALTER TABLE `rradha`
  ADD CONSTRAINT `rradha_ibfk_1` FOREIGN KEY (`DoktorID`) REFERENCES `doktori` (`DoktorID`),
  ADD CONSTRAINT `rradha_ibfk_2` FOREIGN KEY (`PacientID`) REFERENCES `pacienti` (`PacientID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
