Use LaHacks
Go

Create proc [InvalidateGroup_Id]
   @id bigint
as
begin
Update [Group]
set IsValid = 0
Where Id = @id

end