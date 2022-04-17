Use LaHacks

drop table if exists [GroupLinkUser]
Create Table [GroupLinkUser]
(
	[Id] bigint not null primary key Identity(1,1),
   [GroupId] bigint not null foreign key references [Group]([Id]) ,
   [UserId] bigint not null foreign key references [User]([Id]) ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)