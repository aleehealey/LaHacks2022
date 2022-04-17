Use LaHacks
Go

Create proc [InvalidateUserEvent_UserId]
   @userId bigint
as
begin
Update [UserEvent]
set IsValid = 0
Where UserId = @userId

end