USE [PerfectApp]
GO
/****** Object:  Table [dbo].[UserID]    Script Date: 6/5/2017 10:11:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserID](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[UserID] ON 

INSERT [dbo].[UserID] ([id], [username], [password]) VALUES (1, N'hien', N'123')
INSERT [dbo].[UserID] ([id], [username], [password]) VALUES (2, N'phat', N'123')
INSERT [dbo].[UserID] ([id], [username], [password]) VALUES (3, N'thang', N'123')
SET IDENTITY_INSERT [dbo].[UserID] OFF
