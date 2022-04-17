Use LaHacks
Go

Create proc [InsertEvent]
   @groupId bigint,
   @activityId bigint,
   @dateTime Datetime,
   @duration int,
   @eventGoogleId nvarchar(500),
   @createdDate Datetime
as
begin
insert into [Event]
(
  [GroupId],
  [ActivityId],
  [DateTime],
  [Duration],
  [EventGoogleId],
  [IsValid],
  [CreatedDate]
)
Values
(
  @groupId,
  @activityId,
  @dateTime,
  @duration,
  @eventGoogleId,
  1,
  @createdDate
)

end