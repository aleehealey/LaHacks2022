Use LaHacks
Go

Create proc [InvalidateEvent_GroupId]
   @groupId bigint
as
begin
Update [Event]
set IsValid = 0
Where GroupId = @groupId

end