Use LaHacks

drop table if exists [Group]
Create Table [Group]
(
	[Id] bigint not null primary key Identity(1,1),
   [UserId] bigint not null foreign key references [User]([Id]) ,
   [Location] nvarchar(500) not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)