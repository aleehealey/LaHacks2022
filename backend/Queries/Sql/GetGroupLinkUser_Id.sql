Use LaHacks
Go

Create proc [GetGroupLinkUser_Id]
   @id bigint
as
begin
Select [Id],
[GroupId],
[UserId],
 [CreatedDate],
 [IsValid]
from [GroupLinkUser]
Where [Id] = @id
   and[IsValid] = 1
end