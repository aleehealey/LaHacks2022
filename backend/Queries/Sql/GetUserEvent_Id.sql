Use LaHacks
Go

Create proc [GetUserEvent_Id]
   @id bigint
as
begin
Select [Id],
[UserId],
[StartTime],
[Duration],
 [CreatedDate],
 [IsValid]
from [UserEvent]
Where [Id] = @id
   and[IsValid] = 1
end