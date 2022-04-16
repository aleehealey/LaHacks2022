Use LaHacks
Go

Create proc [GetActivityUserLink_UserId]
   @userId bigint
as
begin
Select *
from [ActivityUserLink]
Where [UserId] = @userId
   and[IsValid] = 1
end