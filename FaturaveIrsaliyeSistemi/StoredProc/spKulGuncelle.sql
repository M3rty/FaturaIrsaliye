CREATE PROCEDURE spKulGuncelle
(
@id int,
@adi varchar(50), 
@soyadi varchar(50),
@dogtar date,
@tc_num varchar(11),
@kan_grubu varchar(50),
@tel_num varchar(50),
@kul_adi varchar(50),
@kul_sif varchar(50)
)
WITH ENCRYPTION
AS
BEGIN
Update dbo.kullanicilar set adi=@adi ,soyadi=@soyadi, dog_tar=@dogtar, tc_no=@tc_num, kan_grub=@kan_grubu,tel_no=@tel_num, kul_adi=@kul_adi,kul_sifre=@kul_sif where kul_no=@id
END