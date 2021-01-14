Alter TRIGGER TutarHesapla ON fatura
AFTER INSERT
AS

BEGIN
declare @tutar money
declare @miktar int
declare @kdv int
declare @toplam money
declare @g_toplam money
Select @tutar=tutar , @miktar=miktar , @kdv=kdv from fatura
Update fatura set toplam=tutar*miktar , genel_toplam=toplam+((toplam*kdv)/100)
END