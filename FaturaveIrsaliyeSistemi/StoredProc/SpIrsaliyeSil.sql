CREATE PROCEDURE spIrsaliyeSil(@irs_no int)
WITH ENCRYPTION
AS
BEGIN
Delete from irsaliye where @irs_no=irsaliye_no
END