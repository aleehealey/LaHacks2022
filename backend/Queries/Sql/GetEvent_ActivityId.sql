Use LaHacks
Go

Create proc [GetEvent_ActivityId]
   @activityId bigint
as
begin
Select *
from [Event]
Where [ActivityId] = @activityId
   and[IsValid] = 1
end