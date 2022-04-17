Use LaHacks
Go

Create proc [InvalidateGroup_UserId]
   @userId bigint
as
begin
Update [Group]
set IsValid = 0
Where UserId = @userId

end