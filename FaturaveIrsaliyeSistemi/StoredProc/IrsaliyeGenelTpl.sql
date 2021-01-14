Create PROCEDURE spIrsaliyeGToplam(@irsaliye_no int,@seri varchar(5))
WITH ENCRYPTION

AS

BEGIN
DECLARE @tpl money
Select @tpl=SUM(tutar) from irsaliye where irsaliye_no=@irsaliye_no and seri=@seri

Update irsaliye set toplam=@tpl, genel_toplam=@tpl+((@tpl*kdv)/100) where irsaliye_no=@irsaliye_no and seri=@seri
END