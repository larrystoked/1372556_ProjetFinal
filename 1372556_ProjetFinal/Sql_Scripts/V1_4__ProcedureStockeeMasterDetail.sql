USE TP1_Pokemon;
GO

CREATE PROCEDURE GetGameDetails
    @IdJeux INT
AS
BEGIN
    SELECT *
    FROM Jeux
    WHERE IdJeux = @IdJeux;
END
