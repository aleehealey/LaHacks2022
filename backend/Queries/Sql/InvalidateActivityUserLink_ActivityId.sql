Use LaHacks
Go

Create proc [InvalidateActivityUserLink_ActivityId]
   @activityId bigint
as
begin
Update [ActivityUserLink]
set IsValid = 0
Where ActivityId = @activityId

end