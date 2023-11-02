USE TP1_Pokemon;
GO

CREATE PROCEDURE ChiffrerPrixJeux
    @IdJeux INT
AS
BEGIN
    DECLARE @CleDeChiffrement NVARCHAR(128) = 'Dechiffrer' 

    
    UPDATE Jeux
    SET Prix = ENCRYPTBYPASSPHRASE(@CleDeChiffrement, CAST(Prix AS NVARCHAR(255)))
    WHERE IdJeux = @IdJeux
END
