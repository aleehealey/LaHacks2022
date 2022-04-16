Use LaHacks
Go

Create proc [InsertUser]
   @gmail nvarchar(500),
   @firstName nvarchar(500),
   @lastName nvarchar(500),
   @location nvarchar(500),
   @createdDate Datetime
as
begin
insert into [User]
(
  [Gmail],
  [FirstName],
  [LastName],
  [Location],
  [IsValid],
  [CreatedDate]
)
Values
(
  @gmail,
  @firstName,
  @lastName,
  @location,
  1,
  @createdDate
)

end