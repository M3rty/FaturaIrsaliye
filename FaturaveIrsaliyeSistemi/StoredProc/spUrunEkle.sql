Alter PROCEDURE spUrunEkle
(
@urun_adi varchar(150), 
@barkod int,
@kategori int,
@stok int,
@birim int,
@fiyat money,
@kdv int
)
WITH ENCRYPTION
AS
IF EXISTS(SELECT * FROM dbo.urunler WHERE  urun_barkod=@barkod)
BEGIN
PRINT 'Bu Ürün Sistemde Kayýtlýdýr !'
END
ELSE
BEGIN
INSERT INTO dbo.urunler VALUES (@urun_adi,@barkod,@kategori,@stok,@birim,@fiyat)
END