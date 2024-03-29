USE [SBMS]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/27/2019 11:26:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 10/27/2019 11:26:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[LoyltyPoint] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 10/27/2019 11:26:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Contact] [varchar](20) NULL,
	[ContactPerson] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Code], [Name]) VALUES (1, N'4010', N'mobile')
INSERT [dbo].[Category] ([Id], [Code], [Name]) VALUES (3, N'5632', N'freze')
INSERT [dbo].[Category] ([Id], [Code], [Name]) VALUES (6, N'3210', N'Ac')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([Id], [Code], [Name], [Address], [Email], [Contact], [LoyltyPoint]) VALUES (1, N'1010', N'Saddam', N'dhaka', N'saddam@gmail.com', N'01843955825', 10)
INSERT [dbo].[Customer] ([Id], [Code], [Name], [Address], [Email], [Contact], [LoyltyPoint]) VALUES (2, N'2365', N'deljdd', N'shrghth', N'thrh', N'dsfsd', 10.3)
INSERT [dbo].[Customer] ([Id], [Code], [Name], [Address], [Email], [Contact], [LoyltyPoint]) VALUES (3, N'5632', N'asdsf', N'sdfsf', N'dfsf', N'23654', 10.23)
INSERT [dbo].[Customer] ([Id], [Code], [Name], [Address], [Email], [Contact], [LoyltyPoint]) VALUES (4, N'4564', N'ljiliolhoh', N'vvhoho', N'vcvc', N'c45454', 12.2)
INSERT [dbo].[Customer] ([Id], [Code], [Name], [Address], [Email], [Contact], [LoyltyPoint]) VALUES (5, N'2358', N'saddam', N'dhanmondi', N'dh@email.com', N'0123654789', 10)
INSERT [dbo].[Customer] ([Id], [Code], [Name], [Address], [Email], [Contact], [LoyltyPoint]) VALUES (6, N'3214', N'dfsf', N'fsf', N'sdfs', N'fsdf', 32)
INSERT [dbo].[Customer] ([Id], [Code], [Name], [Address], [Email], [Contact], [LoyltyPoint]) VALUES (12, N'6666', N'delwar', N'dhaka', N'dh@gmail.com', N'0123225412', 15)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Suppliers] ON 

INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (15, N'3265', N'kl store', N'chittagong', N'email.com', N'0123521478', N'ain')
INSERT [dbo].[Suppliers] ([Id], [Code], [Name], [Address], [Email], [Contact], [ContactPerson]) VALUES (16, N'2365', N'ks shop', N'dhaka', N'ak@email.com', N'012365214', N'antu')
SET IDENTITY_INSERT [dbo].[Suppliers] OFF
