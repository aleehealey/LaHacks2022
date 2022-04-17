Use LaHacks
Go

Create proc [GetActivityUserLink_ActivityId]
   @activityId bigint
as
begin
Select *
from [ActivityUserLink]
Where [ActivityId] = @activityId
   and[IsValid] = 1
end