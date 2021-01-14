USE [faturaveirsaliye]
GO
/****** Object:  Trigger [dbo].[TutarHesapla]    Script Date: 19.05.2016 21:50:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[TutarHesapla] ON [dbo].[fatura]
AFTER INSERT , DELETE
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
