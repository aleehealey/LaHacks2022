Use LaHacks
Go

Create proc [GetEvent_GroupId]
   @groupId bigint
as
begin
Select *
from [Event]
Where [GroupId] = @groupId
   and[IsValid] = 1
end