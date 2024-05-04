-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 28 jan. 2024 à 15:38
-- Version du serveur : 5.7.36
-- Version de PHP : 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `railway`
--

-- --------------------------------------------------------

--
-- Structure de la table `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `idCli` varchar(30) NOT NULL,
  `nameCli` varchar(30) NOT NULL,
  `contactCli` varchar(30) NOT NULL,
  PRIMARY KEY (`idCli`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `client`
--

INSERT INTO `client` (`idCli`, `nameCli`, `contactCli`) VALUES
('13216904532', 'Milanto', '0345948505'),
('11301044587', 'Tsiory', '0344567567');

-- --------------------------------------------------------

--
-- Structure de la table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
CREATE TABLE IF NOT EXISTS `reservation` (
  `idReservation` int(30) NOT NULL AUTO_INCREMENT,
  `idClient` varchar(32) NOT NULL,
  `codeVoyage` varchar(30) NOT NULL,
  `typeOfpaid` varchar(30) NOT NULL,
  `reste` int(11) NOT NULL,
  PRIMARY KEY (`idReservation`)
) ENGINE=MyISAM AUTO_INCREMENT=79 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `reservation`
--

INSERT INTO `reservation` (`idReservation`, `idClient`, `codeVoyage`, `typeOfpaid`, `reste`) VALUES
(71, '11301044587', 'T1', 'Advance', 35000),
(72, '11301044587', 'T1', 'All', 0),
(77, '11301044587', 'T9', 'All', 0),
(78, '11301044587', 'T9', 'Advance', 29000);

-- --------------------------------------------------------

--
-- Structure de la table `train`
--

DROP TABLE IF EXISTS `train`;
CREATE TABLE IF NOT EXISTS `train` (
  `numTrain` varchar(60) NOT NULL,
  `capacityTrain` varchar(60) NOT NULL,
  `statusTrain` varchar(100) NOT NULL,
  PRIMARY KEY (`numTrain`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `train`
--

INSERT INTO `train` (`numTrain`, `capacityTrain`, `statusTrain`) VALUES
('586B', '100', 'Not Available'),
('404C', '300', 'Not Available'),
('456', '300', 'Available');

-- --------------------------------------------------------

--
-- Structure de la table `travel`
--

DROP TABLE IF EXISTS `travel`;
CREATE TABLE IF NOT EXISTS `travel` (
  `codeV` varchar(10) NOT NULL,
  `dateV` date NOT NULL,
  `codeTrain` varchar(40) NOT NULL,
  `sourceV` varchar(50) NOT NULL,
  `destinationV` varchar(50) NOT NULL,
  `coastV` int(50) NOT NULL,
  PRIMARY KEY (`codeV`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `travel`
--

INSERT INTO `travel` (`codeV`, `dateV`, `codeTrain`, `sourceV`, `destinationV`, `coastV`) VALUES
('T1', '2023-08-23', '367A', 'Tanà', 'Fianara', 40000),
('T5', '2023-08-24', '367A', 'Farafangana', 'Tuléar', 30000),
('T9', '2023-08-24', '456', 'MORONDAVA', 'FIANARA', 30000);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
