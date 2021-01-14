Alter PROCEDURE spGenelToplam(@fatura_no int,@seri varchar(5))
WITH ENCRYPTION

AS

BEGIN
DECLARE @tpl money
Select @tpl=SUM(tutar) from fatura where fatura_no=@fatura_no and seri=@seri

Update fatura set toplam=@tpl, genel_toplam=@tpl+((@tpl*kdv)/100) where fatura_no=@fatura_no and seri=@seri
END