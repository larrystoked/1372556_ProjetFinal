CREATE PROCEDURE ChiffrerDechiffrerBadgeCount
    @IdDresseur INT,
    @Action NVARCHAR(10) -- 'Chiffrer' ou 'Dechiffrer'
AS
BEGIN
    IF @Action = 'Chiffrer'
    BEGIN
        UPDATE Dresseur
        SET BadgeCount = EncryptByKey(Key_GUID('MaSuperCle'), CONVERT(VARCHAR(50), BadgeCount))
        WHERE IdDresseur = @IdDresseur;
    END
    ELSE IF @Action = 'Dechiffrer'
    BEGIN
        UPDATE Dresseur
        SET BadgeCount = TRY_CAST(DecryptByKey(TRY_CAST(BadgeCount AS VARBINARY(MAX))) AS INT)
        WHERE IdDresseur = @IdDresseur AND DecryptByKey(TRY_CAST(BadgeCount AS VARBINARY(MAX))) IS NOT NULL;
    END
END
GO
