Use LaHacks
Go

Create proc [InvalidateGroupLinkUser_UserId]
   @userId bigint
as
begin
Update [GroupLinkUser]
set IsValid = 0
Where UserId = @userId

end