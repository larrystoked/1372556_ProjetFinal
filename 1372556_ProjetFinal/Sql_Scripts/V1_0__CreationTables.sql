-- Utilisation de la base de données nouvellement créée
USE TP1_Pokemon;
GO

-- Création de la table 
CREATE TABLE Typee (
    idTypes INT IDENTITY(1,1) PRIMARY KEY,
    nomTypes VARCHAR(255) NOT NULL UNIQUE
);

-- Création de la table Generation
CREATE TABLE Generation (
    idGeneration INT IDENTITY(1,1) PRIMARY KEY,
    numero INT NOT NULL,
    nom VARCHAR(255) NOT NULL,
    nombreJeux INT NOT NULL CHECK (nombreJeux >= 0)
);

-- Création de la table Pokemon
CREATE TABLE Pokemon (
    idPokemon INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    niveau INT CHECK (niveau >= 0),
    idGeneration INT,
    CONSTRAINT fk_Generation FOREIGN KEY (idGeneration) REFERENCES Generation(idGeneration),
    idTypes INT,
    CONSTRAINT fk_Types FOREIGN KEY (idTypes) REFERENCES Typee(idTypes)
);

-- Création de la table Dresseur
CREATE TABLE Dresseur (
    idDresseur INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    prenom VARCHAR(255) NOT NULL,
    badgeCount INT CHECK (badgeCount >= 0)
);

-- Création de la table Jeux
CREATE TABLE Jeux (
    idJeux INT IDENTITY(1,1) PRIMARY KEY,
    nomJeu VARCHAR(255) NOT NULL,
    dateSortie DATE,
    age INT,
    idGeneration INT,
    Prix INT,
    CONSTRAINT fk_Generation_jeux FOREIGN KEY (idGeneration) REFERENCES Generation(idGeneration)
);