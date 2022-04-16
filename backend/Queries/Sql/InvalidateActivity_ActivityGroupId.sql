Use LaHacks
Go

Create proc [InvalidateActivity_ActivityGroupId]
   @activityGroupId bigint
as
begin
Update [Activity]
set IsValid = 0
Where ActivityGroupId = @activityGroupId

end