Use LaHacks
Go

Create proc [GetGroup_UserId]
   @userId bigint
as
begin
Select *
from [Group]
Where [UserId] = @userId
   and[IsValid] = 1
end