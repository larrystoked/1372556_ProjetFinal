-- Utilisation de la base de donn�es nouvellement cr��e
USE TP1_Pokemon;
GO

-- Cr�ation de la table 
CREATE TABLE Typee (
    idTypes INT IDENTITY(1,1) PRIMARY KEY,
    nomTypes VARCHAR(255) NOT NULL UNIQUE
);

-- Cr�ation de la table Generation
CREATE TABLE Generation (
    idGeneration INT IDENTITY(1,1) PRIMARY KEY,
    numero INT NOT NULL,
    nom VARCHAR(255) NOT NULL,
    nombreJeux INT NOT NULL CHECK (nombreJeux >= 0)
);

-- Cr�ation de la table Pokemon
CREATE TABLE Pokemon (
    idPokemon INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    niveau INT CHECK (niveau >= 0),
    idGeneration INT,
    CONSTRAINT fk_Generation FOREIGN KEY (idGeneration) REFERENCES Generation(idGeneration),
    idTypes INT,
    CONSTRAINT fk_Types FOREIGN KEY (idTypes) REFERENCES Typee(idTypes)
);

-- Cr�ation de la table Dresseur
CREATE TABLE Dresseur (
    idDresseur INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(255) NOT NULL,
    prenom VARCHAR(255) NOT NULL,
    badgeCount INT CHECK (badgeCount >= 0)
);

-- Cr�ation de la table Jeux
CREATE TABLE Jeux (
    idJeux INT IDENTITY(1,1) PRIMARY KEY,
    nomJeu VARCHAR(255) NOT NULL,
    dateSortie DATE,
    age INT,
    idGeneration INT,
    Prix INT,
    CONSTRAINT fk_Generation_jeux FOREIGN KEY (idGeneration) REFERENCES Generation(idGeneration)
);