Use LaHacks
Go

Create proc [InvalidateActivityUserLink_UserId]
   @userId bigint
as
begin
Update [ActivityUserLink]
set IsValid = 0
Where UserId = @userId

end