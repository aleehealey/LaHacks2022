Use LaHacks
Go

Create proc [InvalidateEvent_Id]
   @id bigint
as
begin
Update [Event]
set IsValid = 0
Where Id = @id

end