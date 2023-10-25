
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
INSERT INTO Jeux (nomJeu, dateSortie, age, idGeneration) VALUES 
('Pokémon Rouge', '1996-02-27', 25, 1), ('Pokémon Bleu', '1996-02-27', 25, 1), 
('Pokémon Jaune', '1998-09-12', 23, 1), ('Pokémon Or', '2000-10-15', 21, 2), 
('Pokémon Argent', '2000-10-15', 21, 2), ('Pokémon Cristal', '2001-07-29', 20, 2), 
('Pokémon Rubis', '2002-11-21', 19, 3), ('Pokémon Saphir', '2002-11-21', 19, 3), 
('Pokémon Émeraude', '2004-09-09', 17, 3), ('Pokémon Diamant', '2006-04-22', 15, 4), 
('Pokémon Perle', '2006-04-22', 15, 4), ('Pokémon Platine', '2008-09-13', 13, 4), 
('Pokémon Noir', '2010-03-06', 11, 5), ('Pokémon Blanc', '2010-03-06', 11, 5), 
('Pokémon Noir 2', '2012-06-23', 9, 5), ('Pokémon Blanc 2', '2012-06-23', 9, 5), 
('Pokémon X', '2013-10-12', 8, 6), ('Pokémon Y', '2013-10-12', 8, 6), 
('Pokémon Rubis Oméga', '2014-11-21', 7, 6), ('Pokémon Saphir Alpha', '2014-11-21', 7, 6), 
('Pokémon Soleil', '2016-11-18', 5, 7), ('Pokémon Lune', '2016-11-18', 5, 7), 
('Pokémon Ultra-Soleil', '2017-11-17', 4, 7), ('Pokémon Ultra-Lune', '2017-11-17', 4, 7), 
('Pokémon Épée', '2019-11-15', 2, 8), ('Pokémon Bouclier', '2019-11-15', 2, 8);

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

-- Ajout des enregistrements dans la table PokemonType pour les types de Pokémon
-- Vous pouvez ajouter ces enregistrements selon les types de Pokémon que vous souhaitez
INSERT INTO PokemonType (idPokemon, idType)
VALUES
	(1, 1),   -- Charizard de type Feu
	(2, 1),   -- Charmeleon de type Feu
	(3, 1),   -- Charmander de type Feu
	(4, 8),   -- Gengar de type Spectre
	(5, 8),   -- Haunter de type Spectre
	(6, 8),   -- Gastly de type Spectre
	(7, 2),   -- Gyarados de type Eau
	(8, 2),   -- Magikarp de type Eau
	(9, 11),  -- Alakazam de type Psy
	(10, 11) -- Kadabra de type Psy
	-- Continuez d'associer les types aux Pokémon correspondants ;
	-- Génération 2
INSERT INTO PokemonType (idPokemon, idType)
VALUES
	(11, 1),  -- Tyranitar (Roche)
	(12, 1),  -- Pupitar (Roche)
	(13, 1),  -- Larvitar (Roche)
	(14, 8),  -- Lugia (Spectre)
	(15, 8),  -- Ho-Oh (Spectre)
	(16, 11), -- Espeon (Psy)
	(17, 11), -- Eevee (Psy)
	(18, 8),  -- Umbreon (Spectre)
	(19, 6),  -- Steelix (Acier)
	(20, 9);  -- Scizor (Insecte)

-- Génération 3
INSERT INTO PokemonType (idPokemon, idType)
VALUES
	(21, 3),  -- Salamence (Feu)
	(22, 3),  -- Shelgon (Feu)
	(23, 3),  -- Bagon (Feu)
	(24, 6),  -- Metagross (Acier)
	(25, 6),  -- Metang (Acier)
	(26, 6),  -- Beldum (Acier)
	(27, 11), -- Gardevoir (Psy)
	(28, 11), -- Kirlia (Psy)
	(29, 11), -- Ralts (Psy)
	(30, 9);  -- Aggron (Insecte)

-- Génération 4
INSERT INTO PokemonType (idPokemon, idType)
VALUES
	(31, 3),  -- Infernape (Feu)
	(32, 3),  -- Monferno (Feu)
	(33, 3),  -- Chimchar (Feu)
	(34, 6),  -- Empoleon (Acier)
	(35, 6),  -- Prinplup (Acier)
	(36, 6),  -- Piplup (Acier)
	(37, 4),  -- Lucario (Combat)
	(38, 4),  -- Riolu (Combat)
	(39, 6),  -- Magnezone (Acier)
	(40, 6);  -- Magneton (Acier)

-- Génération 5
INSERT INTO PokemonType (idPokemon, idType)
VALUES
	(41, 15), -- Zoroark (Ténèbres)
	(42, 15), -- Zorua (Ténèbres)
	(43, 15), -- Hydreigon (Ténèbres)
	(44, 10), -- Deino (Combat)
	(45, 9),  -- Volcarona (Insecte)
	(46, 9),  -- Larvesta (Insecte)
	(47, 4),  -- Haxorus (Combat)
	(48, 4),  -- Fraxure (Combat)
	(49, 4),  -- Axew (Combat)
	(50, 14); -- Golurk (Psy)

-- Génération 6
INSERT INTO PokemonType (idPokemon, idType)
VALUES
	(51, 16), -- Greninja (Dragon)
	(52, 16), -- Frogadier (Dragon)
	(53, 16), -- Froakie (Dragon)
	(54, 3),  -- Talonflame (Feu)
	(55, 3),  -- Fletchinder (Feu)
	(56, 3),  -- Fletchling (Feu)
	(57, 6),  -- Aegislash (Acier)
	(58, 6),  -- Doublade (Acier)
	(59, 6),  -- Honedge (Acier)
	(60, 15); -- Dragapult (Ténèbres)

-- Génération 7
INSERT INTO PokemonType (idPokemon, idType)
VALUES
	(61, 3),  -- Incineroar (Feu)
	(62, 3),  -- Torracat (Feu)
	(63, 3),  -- Litten (Feu)
	(64, 5),  -- Decidueye (Plante)
	(65, 5),  -- Dartrix (Plante)
	(66, 5),  -- Rowlet (Plante)
	(67, 2),  -- Primarina (Eau)
	(68, 2),  -- Brionne (Eau)
	(69, 2),  -- Popplio (Eau)
	(70, 4);  -- Kommo-o (Combat);
