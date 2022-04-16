Use LaHacks
Go

Create proc [InvalidateActivityUserLink_Id]
   @id bigint
as
begin
Update [ActivityUserLink]
set IsValid = 0
Where Id = @id

end