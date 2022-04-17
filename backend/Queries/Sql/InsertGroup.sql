Use LaHacks
Go

Create proc [InsertGroup]
   @userId bigint,
   @location nvarchar(500),
   @createdDate Datetime
as
begin
insert into [Group]
(
  [UserId],
  [Location],
  [IsValid],
  [CreatedDate]
)
Values
(
  @userId,
  @location,
  1,
  @createdDate
)

end