Alter PROCEDURE spUrunGunc
(
@id int,
@urun_adi varchar(150), 
@urun_barkod int,
@kategori int,
@stok int,
@birim int,
@fiyat money
)
WITH ENCRYPTION
AS
BEGIN
Update dbo.urunler set urun_adi=@urun_adi ,urun_barkod=@urun_barkod,urun_kategori=@kategori,stok=@stok,birim=@birim, fiyat=@fiyat where urun_id=@id
END