Use LaHacks
Go

Create proc [InvalidateActivity_Id]
   @id bigint
as
begin
Update [Activity]
set IsValid = 0
Where Id = @id

end