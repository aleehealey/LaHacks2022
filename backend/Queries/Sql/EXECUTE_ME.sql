Create Database LaHacks

Go


Use LaHacks

Go


drop table if exists [User]
Create Table [User]
(
	[Id] bigint not null primary key Identity(1,1),
   [Gmail] nvarchar(500) not null  ,
   [FirstName] nvarchar(500) not null  ,
   [LastName] nvarchar(500) not null  ,
   [Location] nvarchar(500) not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)

Go


drop table if exists [Activity]
Create Table [Activity]
(
	[Id] bigint not null primary key Identity(1,1),
   [Name] nvarchar(500) not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)

Go


drop table if exists [ActivityUserLink]
Create Table [ActivityUserLink]
(
	[Id] bigint not null primary key Identity(1,1),
   [UserId] bigint not null foreign key references [User]([Id]) ,
   [ActivityId] bigint not null foreign key references [Activity]([Id]) ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)

Go


drop table if exists [Group]
Create Table [Group]
(
	[Id] bigint not null primary key Identity(1,1),
   [UserId] bigint not null foreign key references [User]([Id]) ,
   [Location] nvarchar(500) not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)

Go


drop table if exists [GroupLinkUser]
Create Table [GroupLinkUser]
(
	[Id] bigint not null primary key Identity(1,1),
   [GroupId] bigint not null foreign key references [Group]([Id]) ,
   [UserId] bigint not null foreign key references [User]([Id]) ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)

Go


Create proc [GetUser_Id]
   @id bigint
as
begin
Select [Id],
[Gmail],
[FirstName],
[LastName],
[Location],
 [CreatedDate],
 [IsValid]
from [User]
Where [Id] = @id
   and[IsValid] = 1
end

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

Go


Create proc [InvalidateUser_Id]
   @id bigint
as
begin
Update [User]
set IsValid = 0
Where Id = @id

end

Go


Create proc [GetActivity_Id]
   @id bigint
as
begin
Select [Id],
[Name],
 [CreatedDate],
 [IsValid]
from [Activity]
Where [Id] = @id
   and[IsValid] = 1
end

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

Go


Create proc [InvalidateActivity_Id]
   @id bigint
as
begin
Update [Activity]
set IsValid = 0
Where Id = @id

end

Go


Create proc [GetActivityUserLink_UserId]
   @userId bigint
as
begin
Select *
from [ActivityUserLink]
Where [UserId] = @userId
   and[IsValid] = 1
end

Go


Create proc [InvalidateActivityUserLink_UserId]
   @userId bigint
as
begin
Update [ActivityUserLink]
set IsValid = 0
Where UserId = @userId

end

Go


Create proc [GetActivityUserLink_ActivityId]
   @activityId bigint
as
begin
Select *
from [ActivityUserLink]
Where [ActivityId] = @activityId
   and[IsValid] = 1
end

Go


Create proc [InvalidateActivityUserLink_ActivityId]
   @activityId bigint
as
begin
Update [ActivityUserLink]
set IsValid = 0
Where ActivityId = @activityId

end

Go


Create proc [GetActivityUserLink_Id]
   @id bigint
as
begin
Select [Id],
[UserId],
[ActivityId],
 [CreatedDate],
 [IsValid]
from [ActivityUserLink]
Where [Id] = @id
   and[IsValid] = 1
end

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

Go


Create proc [InvalidateActivityUserLink_Id]
   @id bigint
as
begin
Update [ActivityUserLink]
set IsValid = 0
Where Id = @id

end

Go


Create proc [GetGroup_UserId]
   @userId bigint
as
begin
Select *
from [Group]
Where [UserId] = @userId
   and[IsValid] = 1
end

Go


Create proc [InvalidateGroup_UserId]
   @userId bigint
as
begin
Update [Group]
set IsValid = 0
Where UserId = @userId

end

Go


Create proc [GetGroup_Id]
   @id bigint
as
begin
Select [Id],
[UserId],
[Location],
 [CreatedDate],
 [IsValid]
from [Group]
Where [Id] = @id
   and[IsValid] = 1
end

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

Go


Create proc [InvalidateGroup_Id]
   @id bigint
as
begin
Update [Group]
set IsValid = 0
Where Id = @id

end

Go


Create proc [GetGroupLinkUser_GroupId]
   @groupId bigint
as
begin
Select *
from [GroupLinkUser]
Where [GroupId] = @groupId
   and[IsValid] = 1
end

Go


Create proc [InvalidateGroupLinkUser_GroupId]
   @groupId bigint
as
begin
Update [GroupLinkUser]
set IsValid = 0
Where GroupId = @groupId

end

Go


Create proc [GetGroupLinkUser_UserId]
   @userId bigint
as
begin
Select *
from [GroupLinkUser]
Where [UserId] = @userId
   and[IsValid] = 1
end

Go


Create proc [InvalidateGroupLinkUser_UserId]
   @userId bigint
as
begin
Update [GroupLinkUser]
set IsValid = 0
Where UserId = @userId

end

Go


Create proc [GetGroupLinkUser_Id]
   @id bigint
as
begin
Select [Id],
[GroupId],
[UserId],
 [CreatedDate],
 [IsValid]
from [GroupLinkUser]
Where [Id] = @id
   and[IsValid] = 1
end

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

Go


Create proc [InvalidateGroupLinkUser_Id]
   @id bigint
as
begin
Update [GroupLinkUser]
set IsValid = 0
Where Id = @id

end

Go


