USE TP1_Pokemon;
GO

CREATE PROCEDURE DechiffrerPrixJeux
    @IdJeux INT
AS
BEGIN
    DECLARE @CleDeChiffrement NVARCHAR(128) = 'Dechiffrer' 

    
    UPDATE Jeux
    SET Prix = CAST(DECRYPTBYPASSPHRASE(@CleDeChiffrement, CAST(Prix AS VARBINARY)) AS INT)
    FROM Jeux
    WHERE IdJeux = @IdJeux
END
