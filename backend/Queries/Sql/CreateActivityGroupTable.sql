Use LaHacks

drop table if exists [ActivityGroup]
Create Table [ActivityGroup]
(
	[Id] bigint not null primary key Identity(1,1),
   [Name] nvarchar(500) not null  ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)