Use LaHacks
Go

Create proc [InvalidateUserEvent_Id]
   @id bigint
as
begin
Update [UserEvent]
set IsValid = 0
Where Id = @id

end