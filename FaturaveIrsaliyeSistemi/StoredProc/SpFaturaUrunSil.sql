Alter PROCEDURE spFaturaurunSil(@fat_no int,@urun_bark int,@miktar int)
WITH ENCRYPTION
AS
BEGIN
Delete from fatura where fatura_no=@fat_no and barkod=@urun_bark
Update urunler set stok=stok+@miktar where urun_barkod=@urun_bark
END