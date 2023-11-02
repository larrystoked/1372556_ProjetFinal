CREATE VIEW JeuxComplex AS
SELECT J.IdJeux, J.NomJeu, J.DateSortie, J.Age, J.IdGeneration, G.Nom
FROM Jeux J
JOIN Generation G ON J.IdGeneration = G.IdGeneration;


