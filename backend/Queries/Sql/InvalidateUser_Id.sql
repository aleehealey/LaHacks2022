Use LaHacks
Go

Create proc [InvalidateUser_Id]
   @id bigint
as
begin
Update [User]
set IsValid = 0
Where Id = @id

end