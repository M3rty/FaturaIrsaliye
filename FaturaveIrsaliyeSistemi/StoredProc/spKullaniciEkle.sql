Alter PROCEDURE spFaturaKaydet
(
@seri varchar(5), 
@fatura_no int,
@musteri varchar(150),
@vergi_d varchar(50),
@vergi_no int,
@tarih date,
@irsaliye_no int,
@irsaliye_tarih date,
@barkod int	,
@urun_ad varchar(150),
@miktar int,
@birim varchar(20),
@tutar money,
@durumu int,
@toplam money,
@kdv int,
@genel_toplam money
)
WITH ENCRYPTION
AS
IF EXISTS(SELECT * FROM dbo.fatura WHERE  fatura_no=@fatura_no)
BEGIN
PRINT 'Bu Faturaya Ait Ürün Sistemde Kayýtlýdýr !'
END
ELSE
BEGIN

INSERT INTO dbo.fatura VALUES (@seri,@fatura_no,@musteri,@vergi_d,@vergi_no,@tarih,@irsaliye_no,@irsaliye_tarih,
@barkod,@urun_ad,@miktar,@birim,@tutar,@durumu,@toplam,@kdv,@genel_toplam)
END