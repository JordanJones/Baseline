USE [Baseline]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 11/14/2014 1:40:05 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Users](
	[Id] [int] NOT NULL CONSTRAINT [PK_Users] PRIMARY KEY IDENTITY(1,1),
	[FirstName] nvarchar(255),
	[LastName] nvarchar(255),
	[EmailAddress] nvarchar(255) NOT NULL

) ON [PRIMARY]

GO

CREATE TABLE [Groups](
	[Id] int NOT NULL CONSTRAINT [PK_Groups] PRIMARY KEY IDENTITY(1,1),
	[Name] nvarchar(50) NOT NULL
) ON [PRIMARY]

GO

CREATE TABLE [GroupMembership](
	[GroupId] int NOT NULL,
	[UserId] int NOT NULL,
	CONSTRAINT [PK_GroupMembership] PRIMARY KEY CLUSTERED ([GroupId], [UserId]) ON [PRIMARY],
	CONSTRAINT [FK_GroupMembership_Groups] FOREIGN KEY ([GroupId]) REFERENCES [Groups] ([Id]),
	CONSTRAINT [FK_GroupMembership_Users] FOREIGN KEY ([UserId]) REFERENCES [Users] ([Id]),
) ON [PRIMARY]

GO

CREATE INDEX [IX_GroupMembership] ON [GroupMembership]([UserId], [GroupId]) ON [PRIMARY]

GO


