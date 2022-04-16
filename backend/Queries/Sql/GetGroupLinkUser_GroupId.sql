Use LaHacks
Go

Create proc [GetGroupLinkUser_GroupId]
   @groupId bigint
as
begin
Select *
from [GroupLinkUser]
Where [GroupId] = @groupId
   and[IsValid] = 1
end