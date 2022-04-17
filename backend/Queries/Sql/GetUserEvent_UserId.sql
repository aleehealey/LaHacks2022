Use LaHacks
Go

Create proc [GetUserEvent_UserId]
   @userId bigint
as
begin
Select *
from [UserEvent]
Where [UserId] = @userId
   and[IsValid] = 1
end