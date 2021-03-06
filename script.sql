CREATE DATABASE uchebniyjurnal
go
USE uchebniyjurnal

CREATE TABLE [dbo].[Group](
	[idGroup] [int] IDENTITY(1,1) NOT NULL,
	[groupName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[idGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 16.04.2021 14:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[idStudents] [int] IDENTITY(1,1) NOT NULL,
	[fName] [nvarchar](50) NOT NULL,
	[lName] [nvarchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[group] [int] NOT NULL,
	[available] [int] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[lessCheck] [int] NOT NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[idStudents] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teachers]    Script Date: 16.04.2021 14:25:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teachers](
	[idTeachers] [int] IDENTITY(1,1) NOT NULL,
	[fName] [nvarchar](50) NOT NULL,
	[lName] [nvarchar](50) NOT NULL,
	[dob] [date] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Teachers] PRIMARY KEY CLUSTERED 
(
	[idTeachers] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Group] ON 

INSERT [dbo].[Group] ([idGroup], [groupName]) VALUES (1, N'1 ИСП9-7')
SET IDENTITY_INSERT [dbo].[Group] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (5, N'Сергей', N'Сергеев', CAST(N'2001-01-01' AS Date), 1, 0, N'user', N'1234', 1)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (6, N'ва', N'вав', CAST(N'0001-01-01' AS Date), 1, 1, N'вав', N'', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (7, N'hjgjh', N'ghjjg', CAST(N'0001-01-01' AS Date), 1, 1, N'   ', N'   ', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (8, N'dfg', N'fg', CAST(N'0001-01-01' AS Date), 1, 1, N'   ', N'  ', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (9, N'  ', N'   ', CAST(N'0001-01-01' AS Date), 1, 0, N'   ', N'  ', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (10, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 0, N'ad', N'ad', 1)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (11, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 1, N'ad', N'ad', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (12, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 0, N'ad', N'ad', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (13, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 0, N'ad', N'ad', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (14, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 0, N'ad', N'ad', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (15, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 0, N'ad', N'ad', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (16, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 0, N'ad', N'ad', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (17, N'ad', N'ad', CAST(N'2021-04-01' AS Date), 1, 0, N'ad', N'ad', 0)
INSERT [dbo].[Students] ([idStudents], [fName], [lName], [dob], [group], [available], [login], [password], [lessCheck]) VALUES (18, N'Ккуу', N'Уукк', CAST(N'2021-04-04' AS Date), 1, 1, N'user', N'1234', 2)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET IDENTITY_INSERT [dbo].[Teachers] ON 

INSERT [dbo].[Teachers] ([idTeachers], [fName], [lName], [dob], [login], [password]) VALUES (1, N'Иван', N'Иванов', CAST(N'1990-02-02' AS Date), N'admin', N'1234')
SET IDENTITY_INSERT [dbo].[Teachers] OFF
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Group] FOREIGN KEY([group])
REFERENCES [dbo].[Group] ([idGroup])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Group]
GO
