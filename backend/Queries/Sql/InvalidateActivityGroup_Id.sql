Use LaHacks
Go

Create proc [InvalidateActivityGroup_Id]
   @id bigint
as
begin
Update [ActivityGroup]
set IsValid = 0
Where Id = @id

end