Use LaHacks
Go

Create proc [InsertGroupLinkUser]
   @groupId bigint,
   @userId bigint,
   @createdDate Datetime
as
begin
insert into [GroupLinkUser]
(
  [GroupId],
  [UserId],
  [IsValid],
  [CreatedDate]
)
Values
(
  @groupId,
  @userId,
  1,
  @createdDate
)

end