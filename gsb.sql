-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : ven. 19 jan. 2024 à 09:51
-- Version du serveur : 8.0.31
-- Version de PHP : 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `gsb`
--

-- --------------------------------------------------------

create database if not exists `gsb`;
use gsb;

CREATE USER 'gsb'@'localhost' IDENTIFIED BY 'gsbUser';
GRANT ALL PRIVILEGES ON gsb.* TO 'gsb'@'localhost';
FLUSH PRIVILEGES;
--
-- Structure de la table `allergie`
--
  

DROP TABLE IF EXISTS `allergie`;
CREATE TABLE IF NOT EXISTS `allergie` (
  `id_al` int NOT NULL AUTO_INCREMENT,
  `libelle_al` varchar(50) NOT NULL,
  PRIMARY KEY (`id_al`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `allergie`
--

INSERT INTO `allergie` (`id_al`, `libelle_al`) VALUES
(1, 'Allergie à l\'aspirine'),
(2, 'Allergie au paracétamol'),
(3, 'Réaction allergique aux pénicillines'),
(4, ''),
(5, 'allergie au soleil');

-- --------------------------------------------------------

--
-- Structure de la table `antecedent`
--

DROP TABLE IF EXISTS `antecedent`;
CREATE TABLE IF NOT EXISTS `antecedent` (
  `id_a` int NOT NULL AUTO_INCREMENT,
  `libelle_a` varchar(50) NOT NULL,
  PRIMARY KEY (`id_a`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `antecedent`
--

INSERT INTO `antecedent` (`id_a`, `libelle_a`) VALUES
(1, 'Ulcères gastriques actifs'),
(2, 'Tendinite'),
(3, 'Insuffisance rénale'),
(4, 'Grossesse'),
(5, 'Hyperkaliémie'),
(6, 'Hypotension sévère'),
(7, 'Syndrome sérotoninergique'),
(8, 'Maladie du foie active'),
(9, 'Dépendance aux substances'),
(10, 'Infections fongiques systémiques'),
(11, 'Angioedème'),
(12, 'Tachycardie'),
(13, 'Dépendance'),
(14, 'Porphyrie aiguë'),
(15, 'Saignement actif'),
(16, '');

-- --------------------------------------------------------

--
-- Structure de la table `a_eu`
--

DROP TABLE IF EXISTS `a_eu`;
CREATE TABLE IF NOT EXISTS `a_eu` (
  `id_a` int NOT NULL,
  `id_p` int NOT NULL,
  PRIMARY KEY (`id_a`,`id_p`),
  KEY `a_eu_Patient0_FK` (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `a_eu`
--

INSERT INTO `a_eu` (`id_a`, `id_p`) VALUES
(5, 1),
(6, 1),
(7, 1),
(13, 9),
(4, 10),
(16, 11),
(9, 12);

-- --------------------------------------------------------

--
-- Structure de la table `est`
--

DROP TABLE IF EXISTS `est`;
CREATE TABLE IF NOT EXISTS `est` (
  `id_al` int NOT NULL,
  `id_p` int NOT NULL,
  PRIMARY KEY (`id_al`,`id_p`),
  KEY `est_Patient0_FK` (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `est`
--

INSERT INTO `est` (`id_al`, `id_p`) VALUES
(2, 1),
(4, 1),
(5, 1),
(5, 9),
(3, 10),
(4, 11),
(4, 12);

-- --------------------------------------------------------

--
-- Structure de la table `incompatible`
--

DROP TABLE IF EXISTS `incompatible`;
CREATE TABLE IF NOT EXISTS `incompatible` (
  `id_a` int DEFAULT NULL,
  `id_med` int NOT NULL,
  `id_al` int DEFAULT NULL,
  `id_med_Medicament` int DEFAULT NULL,
  UNIQUE KEY `incompatible_PK` (`id_a`,`id_med`,`id_al`,`id_med_Medicament`),
  KEY `incompatible_Medicament0_FK` (`id_med`),
  KEY `incompatible_Allergie1_FK` (`id_al`),
  KEY `incompatible_Medicament2_FK` (`id_med_Medicament`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `incompatible`
--

INSERT INTO `incompatible` (`id_a`, `id_med`, `id_al`, `id_med_Medicament`) VALUES
(1, 3, 1, 2),
(1, 4, 4, 5);

-- --------------------------------------------------------

--
-- Structure de la table `medecin`
--

DROP TABLE IF EXISTS `medecin`;
CREATE TABLE IF NOT EXISTS `medecin` (
  `id_m` int NOT NULL AUTO_INCREMENT,
  `nom_m` varchar(50) NOT NULL,
  `prenom_m` varchar(50) NOT NULL,
  `login_m` varchar(50) NOT NULL,
  `email_m` varchar(100) NOT NULL,
  `password_m` varchar(255) NOT NULL,
  `role` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `modificationMotDePasse` varchar(7) NOT NULL,
  PRIMARY KEY (`id_m`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `medecin`
--

INSERT INTO `medecin` (`id_m`, `nom_m`, `prenom_m`, `login_m`, `email_m`, `password_m`, `role`, `modificationMotDePasse`) VALUES
(2, 'richer', 'marine', 'marine', 'marine.richergmailcom', 'password', 'Admin', 'Yes'),
(5, 'Veiniel', 'Arthur', 'medecinVeiniel', 'arthur.veiniel@gmail.com', '123456', 'Utilisateur', ''),
(6, 'Panneau', 'Sylvie', 'informatiqueSupport', 'Sylvie.Panneau@gmail.com', 'gr7mopA7', 'Admin', 'Yes'),
(7, 'Lopez', 'Marianne', 'medecinLopez', 'marianne.lopez@gmail.com', 'motdepasse', 'Utilisateur', ''),
(13, 'admin', 'admin', 'admin', 'admin', 'admin', 'admin', '');

-- --------------------------------------------------------

--
-- Structure de la table `medicament`
--

DROP TABLE IF EXISTS `medicament`;
CREATE TABLE IF NOT EXISTS `medicament` (
  `id_med` int NOT NULL AUTO_INCREMENT,
  `libelle_med` varchar(50) NOT NULL,
  `contre_indication` varchar(50) NOT NULL,
  `description` varchar(50) NOT NULL,
  `quantity` int NOT NULL,
  PRIMARY KEY (`id_med`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `medicament`
--

INSERT INTO `medicament` (`id_med`, `libelle_med`, `contre_indication`, `description`, `quantity`) VALUES
(1, 'Aspirine', 'Allergie à l\'aspirine', 'maux de tête', 6),
(2, 'Paracétamol', 'Allergie au paracétamol', 'maux de tête', 6),
(3, 'Ibuprofène', 'Ulcères gastriques actifs', 'maux de tête', 6),
(4, 'Amoxicilline', 'Réaction allergique aux pénicillines', 'maux de tête', 4),
(5, 'Ciprofloxacine', 'Tendinite', 'maux de tête', 6),
(6, 'Metformine', 'Insuffisance rénale', 'maux de tête', 6),
(7, 'Omeprazole', 'Grossesse', 'maux de tête', 6),
(8, 'Losartan', 'Hyperkaliémie', 'maux de tête', 6),
(9, 'Simvastatine', 'Maladie du foie active', 'maux de tête', 6),
(10, 'Amlodipine', 'Hypotension sévère', 'maux de tête', 6),
(11, 'Atorvastatine', 'Maladie du foie active', 'maux de tête', 6),
(12, 'Sertraline', 'Syndrome sérotoninergique', 'maux de tête', 6),
(13, 'Fluoxetine', 'Syndrome sérotoninergique', 'maux de tête', 6),
(14, 'Diazepam', 'Dépendance aux substances', 'maux de tête', 6),
(15, 'Prednisone', 'Infections fongiques systémiques', 'maux de tête', 6),
(16, 'Lisinopril', 'Angioedème', 'maux de tête', 6),
(17, 'Albuterol', 'Tachycardie', 'maux de tête', 6),
(18, 'Gabapentine', 'Dépendance', 'maux de tête', 6),
(19, 'Ranitidine', 'Porphyrie aiguë', 'maux de tête', 6),
(20, 'Warfarine', 'Saignement actif', 'maux de tête', 6);

-- --------------------------------------------------------

--
-- Structure de la table `ordonnance`
--

DROP TABLE IF EXISTS `ordonnance`;
CREATE TABLE IF NOT EXISTS `ordonnance` (
  `id_o` int NOT NULL AUTO_INCREMENT,
  `posologie` varchar(50) NOT NULL,
  `duree_traitement` int NOT NULL,
  `instruction_specifique` varchar(50) NOT NULL,
  `id_m` int NOT NULL,
  `id_p` int NOT NULL,
  `id_med` int NOT NULL,
  `date_o` date NOT NULL,
  PRIMARY KEY (`id_o`),
  KEY `ordonnance_Medecin_FK` (`id_m`),
  KEY `ordonnance_Patient0_FK` (`id_p`),
  KEY `ordonnance_Medicament1_FK` (`id_med`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `ordonnance`
--

INSERT INTO `ordonnance` (`id_o`, `posologie`, `duree_traitement`, `instruction_specifique`, `id_m`, `id_p`, `id_med`, `date_o`) VALUES
(2, 'Maux de tete', 2, 'Toutes les 4 heures', 2, 1, 1, '2024-01-16');

-- --------------------------------------------------------

--
-- Structure de la table `patient`
--

DROP TABLE IF EXISTS `patient`;
CREATE TABLE IF NOT EXISTS `patient` (
  `id_p` int NOT NULL AUTO_INCREMENT,
  `nom_p` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `prenom_p` varchar(50) NOT NULL,
  `sexe` char(5) NOT NULL,
  `birth` date NOT NULL,
  `id_m` int DEFAULT NULL,
  PRIMARY KEY (`id_p`),
  KEY `patient_Medecin_FK` (`id_m`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Déchargement des données de la table `patient`
--

INSERT INTO `patient` (`id_p`, `nom_p`, `prenom_p`, `sexe`, `birth`, `id_m`) VALUES
(1, 'Dupont', 'Jean', 'H', '2024-01-10', 2),
(9, 'Berlin', 'Mathis', 'H', '2024-01-16', 5),
(10, 'Poli', 'Laure', 'F', '2024-01-16', 5),
(11, 'Arras', 'Paul', 'H', '2024-01-16', 5),
(12, 'GAILLETON', 'David', 'H', '2024-01-01', 2);

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `a_eu`
--
ALTER TABLE `a_eu`
  ADD CONSTRAINT `a_eu_Antecedent_FK` FOREIGN KEY (`id_a`) REFERENCES `antecedent` (`id_a`),
  ADD CONSTRAINT `a_eu_Patient0_FK` FOREIGN KEY (`id_p`) REFERENCES `patient` (`id_p`);

--
-- Contraintes pour la table `est`
--
ALTER TABLE `est`
  ADD CONSTRAINT `est_Allergie_FK` FOREIGN KEY (`id_al`) REFERENCES `allergie` (`id_al`),
  ADD CONSTRAINT `est_Patient0_FK` FOREIGN KEY (`id_p`) REFERENCES `patient` (`id_p`);

--
-- Contraintes pour la table `incompatible`
--
ALTER TABLE `incompatible`
  ADD CONSTRAINT `incompatible_Allergie1_FK` FOREIGN KEY (`id_al`) REFERENCES `allergie` (`id_al`),
  ADD CONSTRAINT `incompatible_Antecedent_FK` FOREIGN KEY (`id_a`) REFERENCES `antecedent` (`id_a`),
  ADD CONSTRAINT `incompatible_Medicament0_FK` FOREIGN KEY (`id_med`) REFERENCES `medicament` (`id_med`),
  ADD CONSTRAINT `incompatible_Medicament2_FK` FOREIGN KEY (`id_med_Medicament`) REFERENCES `medicament` (`id_med`);

--
-- Contraintes pour la table `ordonnance`
--
ALTER TABLE `ordonnance`
  ADD CONSTRAINT `ordonnance_Medecin_FK` FOREIGN KEY (`id_m`) REFERENCES `medecin` (`id_m`),
  ADD CONSTRAINT `ordonnance_Medicament1_FK` FOREIGN KEY (`id_med`) REFERENCES `medicament` (`id_med`),
  ADD CONSTRAINT `ordonnance_Patient0_FK` FOREIGN KEY (`id_p`) REFERENCES `patient` (`id_p`);

--
-- Contraintes pour la table `patient`
--
ALTER TABLE `patient`
  ADD CONSTRAINT `patient_Medecin_FK` FOREIGN KEY (`id_m`) REFERENCES `medecin` (`id_m`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
