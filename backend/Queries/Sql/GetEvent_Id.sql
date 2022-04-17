Use LaHacks
Go

Create proc [GetEvent_Id]
   @id bigint
as
begin
Select [Id],
[GroupId],
[ActivityId],
[DateTime],
[Duration],
[EventGoogleId],
 [CreatedDate],
 [IsValid]
from [Event]
Where [Id] = @id
   and[IsValid] = 1
end