Use LaHacks
Go

Create proc [GetGroup_Id]
   @id bigint
as
begin
Select [Id],
[UserId],
[Location],
[Code],
 [CreatedDate],
 [IsValid]
from [Group]
Where [Id] = @id
   and[IsValid] = 1
end