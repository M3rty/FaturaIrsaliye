CREATE PROCEDURE spUrunSil(@u_no int)
WITH ENCRYPTION
AS
BEGIN
Delete from urunler where urun_id=@u_no
END