Use LaHacks
Go

Create proc [GetActivity_Id]
   @id bigint
as
begin
Select [Id],
[Name],
[ActivityGroupId],
 [CreatedDate],
 [IsValid]
from [Activity]
Where [Id] = @id
   and[IsValid] = 1
end