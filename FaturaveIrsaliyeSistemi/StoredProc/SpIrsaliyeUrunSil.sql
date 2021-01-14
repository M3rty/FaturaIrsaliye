Alter PROCEDURE spIrsaliyeUrunSil(@irsa_no int,@urun_bark int,@urun_miktar int)
WITH ENCRYPTION
AS
BEGIN
Delete from irsaliye where irsaliye_no=@irsa_no and barkod=@urun_bark
Update urunler set stok=stok+@urun_miktar where urun_barkod=@urun_bark
END