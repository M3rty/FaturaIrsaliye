CREATE PROCEDURE spKullaniciSil(@k_no int)
WITH ENCRYPTION
AS
BEGIN
Delete from kullanicilar where kul_no=@k_no
END