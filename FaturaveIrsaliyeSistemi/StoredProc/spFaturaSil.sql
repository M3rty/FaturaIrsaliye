CREATE PROCEDURE spFaturaSil(@fat_no int)
WITH ENCRYPTION
AS
BEGIN
Delete from fatura where @fat_no=fatura_no
END