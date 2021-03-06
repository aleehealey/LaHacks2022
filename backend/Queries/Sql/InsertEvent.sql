Use LaHacks
Go

Create proc [InsertEvent]
   @groupId bigint,
   @activityId bigint,
   @startTime Datetime,
   @duration int,
   @eventGoogleId bigint,
   @createdDate Datetime
as
begin
insert into [Event]
(
  [GroupId],
  [ActivityId],
  [StartTime],
  [Duration],
  [EventGoogleId],
  [IsValid],
  [CreatedDate]
)
Values
(
  @groupId,
  @activityId,
  @startTime,
  @duration,
  @eventGoogleId,
  1,
  @createdDate
)

end