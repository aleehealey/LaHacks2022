Use LaHacks
Go

Create proc [InvalidateGroupLinkUser_GroupId]
   @groupId bigint
as
begin
Update [GroupLinkUser]
set IsValid = 0
Where GroupId = @groupId

end