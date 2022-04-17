Use LaHacks
Go

Create proc [InsertGroup]
   @userId bigint,
   @location nvarchar(500),
   @code nvarchar(500),
   @createdDate Datetime
as
begin
insert into [Group]
(
  [UserId],
  [Location],
  [Code],
  [IsValid],
  [CreatedDate]
)
Values
(
  @userId,
  @location,
  @code,
  1,
  @createdDate
)

end