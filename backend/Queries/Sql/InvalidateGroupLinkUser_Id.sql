Use LaHacks
Go

Create proc [InvalidateGroupLinkUser_Id]
   @id bigint
as
begin
Update [GroupLinkUser]
set IsValid = 0
Where Id = @id

end