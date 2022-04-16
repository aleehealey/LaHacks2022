Use LaHacks
Go

Create proc [InsertActivityGroup]
   @name nvarchar(500),
   @createdDate Datetime
as
begin
insert into [ActivityGroup]
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