Use LaHacks
Go

Create proc [InvalidateEvent_ActivityId]
   @activityId bigint
as
begin
Update [Event]
set IsValid = 0
Where ActivityId = @activityId

end