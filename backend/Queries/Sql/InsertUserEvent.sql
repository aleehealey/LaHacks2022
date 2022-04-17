Use LaHacks
Go

Create proc [InsertUserEvent]
   @userId bigint,
   @startTime Datetime,
   @duration int,
   @createdDate Datetime
as
begin
insert into [UserEvent]
(
  [UserId],
  [StartTime],
  [Duration],
  [IsValid],
  [CreatedDate]
)
Values
(
  @userId,
  @startTime,
  @duration,
  1,
  @createdDate
)

end