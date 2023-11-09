CREATE PROCEDURE dbo.GetPokemonDetailsByGeneration
    @GenerationId INT
AS
BEGIN
    -- Votre logique pour la procédure stockée ici
    SELECT P.Nom AS PokemonNom, P.Niveau, G.Nom AS GenerationNom
    FROM Pokemon P
    INNER JOIN Generation G ON P.IdGeneration = G.IdGeneration
    WHERE P.IdGeneration = @GenerationId;
END
GO

