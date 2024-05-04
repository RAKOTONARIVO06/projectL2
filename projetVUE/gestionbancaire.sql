-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : dim. 28 jan. 2024 à 15:48
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
-- Base de données : `gestionbancaire`
--

-- --------------------------------------------------------

--
-- Structure de la table `pret`
--

DROP TABLE IF EXISTS `pret`;
CREATE TABLE IF NOT EXISTS `pret` (
  `numCompte` int(10) NOT NULL,
  `nomClient` varchar(50) NOT NULL,
  `nomBanque` varchar(50) NOT NULL,
  `montant` int(10) NOT NULL,
  `datePret` date NOT NULL,
  `tauxDePret` double NOT NULL,
  PRIMARY KEY (`numCompte`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `pret`
--

INSERT INTO `pret` (`numCompte`, `nomClient`, `nomBanque`, `montant`, `datePret`, `tauxDePret`) VALUES
(1, 'RAKOTONARIVO', 'BFV', 20000, '2023-10-03', 0),
(2, 'RAKOTONARIVO Anjary Diary', 'BFV', 1000000, '2023-10-03', 0.5);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
