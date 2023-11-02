
USE TP1_Pokemon;
GO

-- Ajout des enregistrements dans la table Type
INSERT INTO Type (nomType) VALUES 
('Feu'), ('Eau'), ('Plante'), ('Électrique'), ('Ténèbres'), ('Acier'), ('Spectre'), 
('Vol'), ('Dragon'), ('Combat'), ('Psy'), ('Poison'), ('Fée');

-- Ajout des enregistrements dans la table Generation (Ajout de générations et jeux)
INSERT INTO Generation (numero, nom, nombreJeux) VALUES 
(1, 'Kanto', 7), (2, 'Johto', 4), (3, 'Hoenn', 6), (4, 'Sinnoh', 5), 
(5, 'Unova', 5), (6, 'Kalos', 3), (7, 'Alola', 3), (8, 'Galar', 3);

-- Ajout des enregistrements dans la table Dresseur (20 enregistrements fictifs répartis dans les générations)
INSERT INTO Dresseur (nom, prenom, badgeCount) VALUES 
('Red', 'Ketchum', 8), ('Misty', 'Waterflower', 4), ('Brock', 'Harrison', 4), 
('Ethan', 'Gold', 16), ('Lyra', 'Kotone', 12), ('Silver', 'Hibiki', 8), 
('Brendan', 'Birch', 8), ('May', 'Maple', 6), ('Wally', 'Green', 4), 
('Lucas', 'Diamond', 8), ('Dawn', 'Pearl', 6), ('Barry', 'Platinum', 6), 
('Hilbert', 'Black', 8), ('Hilda', 'White', 6), ('Nate', 'Kyouhei', 6), 
('Xavier', 'Calem', 8), ('Serena', 'Yvonne', 6), ('Shauna', 'Kali', 4), 
('Elio', 'Sun', 8), ('Selene', 'Moon', 6);

-- Ajout des enregistrements dans la table Jeux (Ajout de jeux)
INSERT INTO Jeux (nomJeu, dateSortie, age, idGeneration, Prix) VALUES 
('Pokémon Rouge', '1996-02-27', 25, 1, 60), ('Pokémon Bleu', '1996-02-27', 25, 1, 70), 
('Pokémon Jaune', '1998-09-12', 23, 1, 60), ('Pokémon Or', '2000-10-15', 21, 2, 70), 
('Pokémon Argent', '2000-10-15', 21, 2, 60), ('Pokémon Cristal', '2001-07-29', 20, 2, 70), 
('Pokémon Rubis', '2002-11-21', 19, 3, 60), ('Pokémon Saphir', '2002-11-21', 19, 3, 70), 
('Pokémon Émeraude', '2004-09-09', 17, 3, 60), ('Pokémon Diamant', '2006-04-22', 15, 4, 70), 
('Pokémon Perle', '2006-04-22', 15, 4, 60), ('Pokémon Platine', '2008-09-13', 13, 4, 70), 
('Pokémon Noir', '2010-03-06', 11, 5, 60), ('Pokémon Blanc', '2010-03-06', 11, 5, 70), 
('Pokémon Noir 2', '2012-06-23', 9, 5, 60), ('Pokémon Blanc 2', '2012-06-23', 9, 5, 70), 
('Pokémon X', '2013-10-12', 8, 6, 60), ('Pokémon Y', '2013-10-12', 8, 6, 70), 
('Pokémon Rubis Oméga', '2014-11-21', 7, 6, 60), ('Pokémon Saphir Alpha', '2014-11-21', 7, 6, 70), 
('Pokémon Soleil', '2016-11-18', 5, 7, 60), ('Pokémon Lune', '2016-11-18', 5, 7, 60), 
('Pokémon Ultra-Soleil', '2017-11-17', 4, 7, 60), ('Pokémon Ultra-Lune', '2017-11-17', 4, 7, 60), 
('Pokémon Épée', '2019-11-15', 2, 8, 60), ('Pokémon Bouclier', '2019-11-15', 2, 8, 60);

-- Ajout des enregistrements dans la table Pokemon
-- Génération 1
INSERT INTO Pokemon (nom, niveau, idGeneration) VALUES
	('Charizard', 36, 1),
	('Charmeleon', 18, 1),
	('Charmander', 5, 1),
	('Gengar', 40, 1),
	('Haunter', 25, 1),
	('Gastly', 5, 1),
	('Gyarados', 30, 1),
	('Magikarp', 5, 1),
	('Alakazam', 40, 1),
	('Kadabra', 18, 1);

-- Génération 2
INSERT INTO Pokemon (nom, niveau, idGeneration) VALUES
	('Tyranitar', 55, 2),
	('Pupitar', 30, 2),
	('Larvitar', 10, 2),
	('Lugia', 60, 2),
	('Ho-Oh', 60, 2),
	('Espeon', 40, 2),
	('Eevee', 5, 2),
	('Umbreon', 40, 2),
	('Steelix', 45, 2),
	('Scizor', 25, 2);

-- Génération 3
INSERT INTO Pokemon (nom, niveau, idGeneration) VALUES
	('Salamence', 50, 3),
	('Shelgon', 30, 3),
	('Bagon', 5, 3),
	('Metagross', 45, 3),
	('Metang', 20, 3),
	('Beldum', 5, 3),
	('Gardevoir', 30, 3),
	('Kirlia', 20, 3),
	('Ralts', 5, 3),
	('Aggron', 45, 3);

-- Génération 4
INSERT INTO Pokemon (nom, niveau, idGeneration) VALUES
	('Infernape', 36, 4),
	('Monferno', 14, 4),
	('Chimchar', 5, 4),
	('Empoleon', 36, 4),
	('Prinplup', 16, 4),
	('Piplup', 5, 4),
	('Lucario', 40, 4),
	('Riolu', 15, 4),
	('Magnezone', 45, 4),
	('Magneton', 30, 4);

-- Génération 5
INSERT INTO Pokemon (nom, niveau, idGeneration) VALUES
	('Zoroark', 40, 5),
	('Zorua', 16, 5),
	('Hydreigon', 50, 5),
	('Deino', 16, 5),
	('Volcarona', 45, 5),
	('Larvesta', 59, 5),
	('Haxorus', 48, 5),
	('Fraxure', 38, 5),
	('Axew', 16, 5),
	('Golurk', 43, 5);

-- Génération 6
INSERT INTO Pokemon (nom, niveau, idGeneration) VALUES
	('Greninja', 36, 6),
	('Frogadier', 16, 6),
	('Froakie', 5, 6),
	('Talonflame', 35, 6),
	('Fletchinder', 17, 6),
	('Fletchling', 5, 6),
	('Aegislash', 50, 6),
	('Doublade', 35, 6),
	('Honedge', 1, 6),
	('Dragapult', 55, 6);

-- Génération 7
INSERT INTO Pokemon (nom, niveau, idGeneration) VALUES
	('Incineroar', 34, 7),
	('Torracat', 17, 7),
	('Litten', 5, 7),
	('Decidueye', 34, 7),
	('Dartrix', 17, 7),
	('Rowlet', 5, 7),
	('Primarina', 34, 7),
	('Brionne', 17, 7),
	('Popplio', 5, 7),
	('Kommo-o', 55, 7);
