Use LaHacks
Go

Create proc [InsertActivityUserLink]
   @userId bigint,
   @activityId bigint,
   @createdDate Datetime
as
begin
insert into [ActivityUserLink]
(
  [UserId],
  [ActivityId],
  [IsValid],
  [CreatedDate]
)
Values
(
  @userId,
  @activityId,
  1,
  @createdDate
)

end