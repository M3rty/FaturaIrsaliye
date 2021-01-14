Alter PROCEDURE spIrsaliyeKayit
(
@seri varchar(5), 
@irs_no int,
@musteri varchar(150),
@vergi_d varchar(50),
@vergi_no int,
@duz_saat varchar(7),
@duz_tar varchar(12),
@sevk_tar varchar(50),
@barkod int	,
@urun_ad varchar(150),
@miktar int,
@birim varchar(20),
@tutar money,
@teslim_eden varchar(50),
@teslim_alan varchar(50),
@durumu int,
@toplam money,
@kdv int,
@genel_toplam money
)
WITH ENCRYPTION
AS

BEGIN

INSERT INTO dbo.irsaliye VALUES (@seri,@irs_no,@musteri,@vergi_d,@vergi_no,
@duz_saat,@duz_tar,@sevk_tar,@barkod,@urun_ad,@miktar,@birim,@tutar,@teslim_eden,@teslim_alan,@durumu,@toplam,@kdv,@genel_toplam)
END