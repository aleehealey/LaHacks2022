Use LaHacks
Go

Create proc [GetActivityGroup_Id]
   @id bigint
as
begin
Select [Id],
[Name],
 [CreatedDate],
 [IsValid]
from [ActivityGroup]
Where [Id] = @id
   and[IsValid] = 1
end