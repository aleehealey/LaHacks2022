Use LaHacks
Go

Create proc [GetActivity_ActivityGroupId]
   @activityGroupId bigint
as
begin
Select *
from [Activity]
Where [ActivityGroupId] = @activityGroupId
   and[IsValid] = 1
end