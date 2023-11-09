CREATE VIEW VueJeux  AS
SELECT J.IdJeux, J.NomJeu, J.DateSortie, J.Age, J.IdGeneration, G.Nom
FROM Jeux J
INNER JOIN Generation G ON J.IdGeneration = G.IdGeneration;


GO

