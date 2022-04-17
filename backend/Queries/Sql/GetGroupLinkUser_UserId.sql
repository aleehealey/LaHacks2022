Use LaHacks
Go

Create proc [GetGroupLinkUser_UserId]
   @userId bigint
as
begin
Select *
from [GroupLinkUser]
Where [UserId] = @userId
   and[IsValid] = 1
end