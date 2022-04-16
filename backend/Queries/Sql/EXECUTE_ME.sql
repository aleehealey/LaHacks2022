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


drop table if exists [ActivityGroup]
Create Table [ActivityGroup]
(
	[Id] bigint not null primary key Identity(1,1),
   [Name] nvarchar(500) not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)

Go


drop table if exists [Activity]
Create Table [Activity]
(
	[Id] bigint not null primary key Identity(1,1),
   [Name] nvarchar(500) not null  ,
   [ActivityGroupId] bigint not null foreign key references [ActivityGroup]([Id]) ,
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


drop table if exists [Event]
Create Table [Event]
(
	[Id] bigint not null primary key Identity(1,1),
   [GroupId] bigint not null foreign key references [Group]([Id]) ,
   [ActivityId] bigint not null foreign key references [Activity]([Id]) ,
   [DateTime] Datetime not null  ,
   [Duration] int not null  ,
   [EventGoogleId] nvarchar(500) not null  ,
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


Create proc [GetActivityGroup_Id]
   @id bigint
as
begin
Select [Id],
[Name],
 [CreatedDate],
 [IsValid]
from [ActivityGroup]
Where [Id] = @id
   and[IsValid] = 1
end

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

Go


Create proc [InvalidateActivityGroup_Id]
   @id bigint
as
begin
Update [ActivityGroup]
set IsValid = 0
Where Id = @id

end

Go


Create proc [GetActivity_ActivityGroupId]
   @activityGroupId bigint
as
begin
Select *
from [Activity]
Where [ActivityGroupId] = @activityGroupId
   and[IsValid] = 1
end

Go


Create proc [InvalidateActivity_ActivityGroupId]
   @activityGroupId bigint
as
begin
Update [Activity]
set IsValid = 0
Where ActivityGroupId = @activityGroupId

end

Go


Create proc [GetActivity_Id]
   @id bigint
as
begin
Select [Id],
[Name],
[ActivityGroupId],
 [CreatedDate],
 [IsValid]
from [Activity]
Where [Id] = @id
   and[IsValid] = 1
end

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


Create proc [GetEvent_GroupId]
   @groupId bigint
as
begin
Select *
from [Event]
Where [GroupId] = @groupId
   and[IsValid] = 1
end

Go


Create proc [InvalidateEvent_GroupId]
   @groupId bigint
as
begin
Update [Event]
set IsValid = 0
Where GroupId = @groupId

end

Go


Create proc [GetEvent_ActivityId]
   @activityId bigint
as
begin
Select *
from [Event]
Where [ActivityId] = @activityId
   and[IsValid] = 1
end

Go


Create proc [InvalidateEvent_ActivityId]
   @activityId bigint
as
begin
Update [Event]
set IsValid = 0
Where ActivityId = @activityId

end

Go


Create proc [GetEvent_Id]
   @id bigint
as
begin
Select [Id],
[GroupId],
[ActivityId],
[DateTime],
[Duration],
[EventGoogleId],
 [CreatedDate],
 [IsValid]
from [Event]
Where [Id] = @id
   and[IsValid] = 1
end

Go


Create proc [InsertEvent]
   @groupId bigint,
   @activityId bigint,
   @dateTime Datetime,
   @duration int,
   @eventGoogleId nvarchar(500),
   @createdDate Datetime
as
begin
insert into [Event]
(
  [GroupId],
  [ActivityId],
  [DateTime],
  [Duration],
  [EventGoogleId],
  [IsValid],
  [CreatedDate]
)
Values
(
  @groupId,
  @activityId,
  @dateTime,
  @duration,
  @eventGoogleId,
  1,
  @createdDate
)

end

Go


Create proc [InvalidateEvent_Id]
   @id bigint
as
begin
Update [Event]
set IsValid = 0
Where Id = @id

end

Go


