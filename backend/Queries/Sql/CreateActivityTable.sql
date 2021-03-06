Use LaHacks

drop table if exists [Activity]
Create Table [Activity]
(
	[Id] bigint not null primary key Identity(1,1),
   [Name] nvarchar(500) not null  ,
   [ActivityGroupId] bigint not null foreign key references [ActivityGroup]([Id]) ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)