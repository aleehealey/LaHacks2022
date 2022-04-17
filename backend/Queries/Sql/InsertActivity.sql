Use LaHacks
Go

Create proc [InsertActivity]
   @name nvarchar(500),
   @activityGroupId bigint,
   @createdDate Datetime
as
begin
insert into [Activity]
(
  [Name],
  [ActivityGroupId],
  [IsValid],
  [CreatedDate]
)
Values
(
  @name,
  @activityGroupId,
  1,
  @createdDate
)

end