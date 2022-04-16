Use LaHacks
Go

Create proc [InsertActivity]
   @name nvarchar(500),
   @createdDate Datetime
as
begin
insert into [Activity]
(
  [Name],
  [IsValid],
  [CreatedDate]
)
Values
(
  @name,
  1,
  @createdDate
)

end