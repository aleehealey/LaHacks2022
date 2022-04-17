Use LaHacks
Go

Create proc [GetActivityUserLink_Id]
   @id bigint
as
begin
Select [Id],
[UserId],
[ActivityId],
 [CreatedDate],
 [IsValid]
from [ActivityUserLink]
Where [Id] = @id
   and[IsValid] = 1
end