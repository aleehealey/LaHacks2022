Use LaHacks

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