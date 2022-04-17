Use LaHacks

drop table if exists [ActivityUserLink]
Create Table [ActivityUserLink]
(
	[Id] bigint not null primary key Identity(1,1),
   [UserId] bigint not null foreign key references [User]([Id]) ,
   [ActivityId] bigint not null foreign key references [Activity]([Id]) ,
   [IsValid] bit not null  ,
   [CreatedDate] DateTime not null  ,
)