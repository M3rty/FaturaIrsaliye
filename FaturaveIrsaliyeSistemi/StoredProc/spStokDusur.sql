CREATE PROCEDURE spStokDusur
(
@barkod int,
@satilan int


)
WITH ENCRYPTION
AS

BEGIN
Update urunler set stok=stok-@satilan where urun_barkod=@barkod
END