Use LaHacks

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