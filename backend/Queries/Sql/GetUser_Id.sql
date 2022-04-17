Use LaHacks
Go

Create proc [GetUser_Id]
   @id bigint
as
begin
Select [Id],
[Gmail],
[FirstName],
[LastName],
[Location],
 [CreatedDate],
 [IsValid]
from [User]
Where [Id] = @id
   and[IsValid] = 1
end