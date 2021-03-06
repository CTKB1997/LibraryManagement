USE [LibraryDatabase]
GO
/****** Object:  Table [dbo].[Author_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author_Tbl](
	[AuthorID] [nvarchar](50) NOT NULL,
	[AuthorName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Author_Tbl] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Book_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book_Tbl](
	[BookID] [nvarchar](50) NOT NULL,
	[BookTitleID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Book_Tbl] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BookStatus_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookStatus_Tbl](
	[Status] [int] NOT NULL,
	[StatusInfo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BookStatus_Tbl] PRIMARY KEY CLUSTERED 
(
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BookTitle_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookTitle_Tbl](
	[BookTitleID] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[AuthorID] [nvarchar](50) NOT NULL,
	[CategoryID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BookTitle_Tbl] PRIMARY KEY CLUSTERED 
(
	[BookTitleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category_Tbl](
	[CategoryID] [nvarchar](50) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category_Tbl] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Tbl](
	[InventoryID] [nvarchar](50) NOT NULL,
	[BookID] [nvarchar](50) NOT NULL,
	[Index] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Inventory_Tbl] PRIMARY KEY CLUSTERED 
(
	[InventoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InventoryStatus_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InventoryStatus_Tbl](
	[Status] [int] NOT NULL,
	[StatusInfo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_InventoryStatus_Tbl] PRIMARY KEY CLUSTERED 
(
	[Status] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Loan_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan_Tbl](
	[LoanID] [nvarchar](50) NOT NULL,
	[ReqID] [nvarchar](50) NOT NULL,
	[BookID] [nvarchar](50) NOT NULL,
	[ExpiredDate] [date] NOT NULL,
	[BorrowedDate] [date] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Loan_Tbl] PRIMARY KEY CLUSTERED 
(
	[LoanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ReqStatus_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReqStatus_Tbl](
	[ReqStatus] [int] NOT NULL,
	[ReqStatusInfo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ReqStatus_Tbl] PRIMARY KEY CLUSTERED 
(
	[ReqStatus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Request_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request_Tbl](
	[ReqID] [nvarchar](50) NOT NULL,
	[UserID] [nvarchar](50) NOT NULL,
	[BookTitleID] [nvarchar](50) NOT NULL,
	[ReqDate] [date] NOT NULL,
	[ReqStatus] [int] NOT NULL,
 CONSTRAINT [PK_Request_Tbl] PRIMARY KEY CLUSTERED 
(
	[ReqID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role_Tbl](
	[RoleID] [nvarchar](50) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role_Tbl] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User_Tbl]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Tbl](
	[UserID] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Phone] [int] NULL,
	[Email] [nvarchar](50) NULL,
	[RoleID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User_Tbl] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'1', N'Ernest Hermingway')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'10', N'Sylivia Path')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'11', N'Duong Thuy')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'12', N'AAA')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'2', N'Mark Twain')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'3', N'Stephen King')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'4', N'William Faulker')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'5', N'J.K.Rowling')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'6', N'Charles Dickens')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'7', N'Dr.Seuss')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'8', N'F.Scott Fitzgerald')
INSERT [dbo].[Author_Tbl] ([AuthorID], [AuthorName]) VALUES (N'9', N'Kurt Vennegut')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0001', N'JP101')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0002', N'JP101')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0003', N'JP101')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0004', N'JP101')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0005', N'JP102')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0006', N'JP102')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0007', N'JP102')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'JP0008', N'JP102')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'PRN0001', N'PRN292')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'PRN0002', N'PRN292')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'PRN0003', N'PRN292')
INSERT [dbo].[Book_Tbl] ([BookID], [BookTitleID]) VALUES (N'PRN0004', N'PRN292')
INSERT [dbo].[BookStatus_Tbl] ([Status], [StatusInfo]) VALUES (0, N'Borrowing')
INSERT [dbo].[BookStatus_Tbl] ([Status], [StatusInfo]) VALUES (1, N'Returned')
INSERT [dbo].[BookStatus_Tbl] ([Status], [StatusInfo]) VALUES (2, N'Lost')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'JP101', N'Mina Nihon Go 1', N'1', N'5')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'JP102', N'Mina Nihon Go 2', N'2', N'5')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'JP103', N'Mina Nihon Go 3', N'3', N'5')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'JPD111', N'Kotoba', N'8', N'4')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'JPD121', N'Kotoba 2', N'9', N'4')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'MAD101', N'Math', N'10', N'1')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'OSG202', N'Operating System', N'3', N'2')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'PRF192', N'C', N'6', N'2')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'PRJ311', N'Desktop JAVA', N'5', N'3')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'PRN292', N'C# && .Net', N'4', N'1')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'PRO192', N'Java OOP', N'5', N'1')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'SWQ391', N'Testing', N'2', N'3')
INSERT [dbo].[BookTitle_Tbl] ([BookTitleID], [Title], [AuthorID], [CategoryID]) VALUES (N'SWR391', N'Introduction to Software Engineer', N'7', N'3')
INSERT [dbo].[Category_Tbl] ([CategoryID], [CategoryName]) VALUES (N'1', N'Software Engineering')
INSERT [dbo].[Category_Tbl] ([CategoryID], [CategoryName]) VALUES (N'2', N'Information System')
INSERT [dbo].[Category_Tbl] ([CategoryID], [CategoryName]) VALUES (N'3', N'Embedded System')
INSERT [dbo].[Category_Tbl] ([CategoryID], [CategoryName]) VALUES (N'4', N'Japanese Brigde')
INSERT [dbo].[Category_Tbl] ([CategoryID], [CategoryName]) VALUES (N'5', N'Japanese')
INSERT [dbo].[Category_Tbl] ([CategoryID], [CategoryName]) VALUES (N'6', N'English')
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'1', N'JP0001', N'A0B0', 1)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'10', N'PRN0001', N'A1B0', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'11', N'PRN0002', N'A1B1', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'111', N'JP0001', N'A112', 1)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'12', N'PRN0003', N'A1B2', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'13', N'PRN0004', N'A1B3', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'2', N'JP0002', N'A0B4', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'3', N'JP0003', N'A0B2', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'4', N'JP0004', N'A0B3', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'5', N'JP0005', N'A0B4', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'6', N'JP0005', N'A0B6', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'7', N'JP0006', N'A0B7', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'8', N'JP0007', N'A0B8', 0)
INSERT [dbo].[Inventory_Tbl] ([InventoryID], [BookID], [Index], [Status]) VALUES (N'9', N'JP0008', N'A0B9', 0)
INSERT [dbo].[InventoryStatus_Tbl] ([Status], [StatusInfo]) VALUES (0, N'Free')
INSERT [dbo].[InventoryStatus_Tbl] ([Status], [StatusInfo]) VALUES (1, N'Busy')
INSERT [dbo].[Loan_Tbl] ([LoanID], [ReqID], [BookID], [ExpiredDate], [BorrowedDate], [Status]) VALUES (N'loan1', N'req1', N'JP0004', CAST(N'2018-04-09' AS Date), CAST(N'2018-03-09' AS Date), 1)
INSERT [dbo].[Loan_Tbl] ([LoanID], [ReqID], [BookID], [ExpiredDate], [BorrowedDate], [Status]) VALUES (N'loan2', N'req2', N'JP0001', CAST(N'2018-04-09' AS Date), CAST(N'2019-03-09' AS Date), 1)
INSERT [dbo].[Loan_Tbl] ([LoanID], [ReqID], [BookID], [ExpiredDate], [BorrowedDate], [Status]) VALUES (N'loan3', N'req7', N'JP0002', CAST(N'2018-03-26' AS Date), CAST(N'2018-03-11' AS Date), 1)
INSERT [dbo].[Loan_Tbl] ([LoanID], [ReqID], [BookID], [ExpiredDate], [BorrowedDate], [Status]) VALUES (N'loan4', N'req12', N'JP0003', CAST(N'2018-03-26' AS Date), CAST(N'2018-03-11' AS Date), 1)
INSERT [dbo].[Loan_Tbl] ([LoanID], [ReqID], [BookID], [ExpiredDate], [BorrowedDate], [Status]) VALUES (N'loan5', N'req13', N'JP0001', CAST(N'2018-03-26' AS Date), CAST(N'2018-03-11' AS Date), 1)
INSERT [dbo].[Loan_Tbl] ([LoanID], [ReqID], [BookID], [ExpiredDate], [BorrowedDate], [Status]) VALUES (N'loan6', N'req15', N'JP0001', CAST(N'2018-03-29' AS Date), CAST(N'2018-03-14' AS Date), 2)
INSERT [dbo].[Loan_Tbl] ([LoanID], [ReqID], [BookID], [ExpiredDate], [BorrowedDate], [Status]) VALUES (N'loan7', N'req17', N'JP0002', CAST(N'2018-03-30' AS Date), CAST(N'2018-03-15' AS Date), 1)
INSERT [dbo].[ReqStatus_Tbl] ([ReqStatus], [ReqStatusInfo]) VALUES (0, N'Still waiting')
INSERT [dbo].[ReqStatus_Tbl] ([ReqStatus], [ReqStatusInfo]) VALUES (1, N'User cancel')
INSERT [dbo].[ReqStatus_Tbl] ([ReqStatus], [ReqStatusInfo]) VALUES (2, N'Staff accepted')
INSERT [dbo].[ReqStatus_Tbl] ([ReqStatus], [ReqStatusInfo]) VALUES (3, N'Staff declined')
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req1', N'SE62597', N'JP101', CAST(N'2018-03-09' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req10', N'SE62192', N'PRJ311', CAST(N'2018-03-11' AS Date), 3)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req11', N'SE62192', N'SWQ391', CAST(N'2018-03-11' AS Date), 3)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req12', N'SE62192', N'JP101', CAST(N'2018-03-11' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req13', N'SE62192', N'JP101', CAST(N'2018-03-11' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req14', N'SE62597', N'JP101', CAST(N'2018-03-14' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req15', N'SE62597', N'JP101', CAST(N'2018-03-14' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req16', N'SE62597', N'JP101', CAST(N'2018-03-15' AS Date), 1)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req17', N'SE62597', N'JP101', CAST(N'2018-03-15' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req2', N'SE62592', N'JP101', CAST(N'2018-03-09' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req3', N'SE62192', N'JP101', CAST(N'2018-03-09' AS Date), 1)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req4', N'SE62192', N'JP101', CAST(N'2018-03-11' AS Date), 1)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req5', N'SE62192', N'SWQ391', CAST(N'2018-03-11' AS Date), 1)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req6', N'SE62192', N'JP101', CAST(N'2018-03-11' AS Date), 1)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req7', N'SE62192', N'JP101', CAST(N'2018-03-11' AS Date), 2)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req8', N'SE62192', N'JPD121', CAST(N'2018-03-11' AS Date), 3)
INSERT [dbo].[Request_Tbl] ([ReqID], [UserID], [BookTitleID], [ReqDate], [ReqStatus]) VALUES (N'req9', N'SE62192', N'OSG202', CAST(N'2018-03-11' AS Date), 3)
INSERT [dbo].[Role_Tbl] ([RoleID], [RoleName]) VALUES (N'1', N'User')
INSERT [dbo].[Role_Tbl] ([RoleID], [RoleName]) VALUES (N'2', N'Staff')
INSERT [dbo].[Role_Tbl] ([RoleID], [RoleName]) VALUES (N'3', N'Admin')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE00001', N'admin', N'123', NULL, NULL, N'3')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE00002', N'staff2', N'123', 837182947, NULL, N'2')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE00100', N'staff', N'123', 39458383, NULL, N'2')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE34535', N'khoa', N'123', 293845878, NULL, N'1')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE62192', N'thanh', N'123', 12399483, N'thanhvt', N'1')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE62592', N'khoi', N'123', 392943759, N'khoidtv', N'1')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE62597', N'anh', N'123', 981874764, N'anhnhse62597@fpt.edu.vn', N'1')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE63233', N'do', N'123', 34395892, NULL, N'1')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE63535', N'huong', N'123', 65342893, NULL, N'1')
INSERT [dbo].[User_Tbl] ([UserID], [UserName], [Password], [Phone], [Email], [RoleID]) VALUES (N'SE66254', N'duy', N'123', 939456884, NULL, N'1')
ALTER TABLE [dbo].[Book_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Book_Tbl_BookTitle_Tbl] FOREIGN KEY([BookTitleID])
REFERENCES [dbo].[BookTitle_Tbl] ([BookTitleID])
GO
ALTER TABLE [dbo].[Book_Tbl] CHECK CONSTRAINT [FK_Book_Tbl_BookTitle_Tbl]
GO
ALTER TABLE [dbo].[BookTitle_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_BookTitle_Tbl_Author_Tbl] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author_Tbl] ([AuthorID])
GO
ALTER TABLE [dbo].[BookTitle_Tbl] CHECK CONSTRAINT [FK_BookTitle_Tbl_Author_Tbl]
GO
ALTER TABLE [dbo].[BookTitle_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_BookTitle_Tbl_Category_Tbl] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category_Tbl] ([CategoryID])
GO
ALTER TABLE [dbo].[BookTitle_Tbl] CHECK CONSTRAINT [FK_BookTitle_Tbl_Category_Tbl]
GO
ALTER TABLE [dbo].[Inventory_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Tbl_Book_Tbl] FOREIGN KEY([BookID])
REFERENCES [dbo].[Book_Tbl] ([BookID])
GO
ALTER TABLE [dbo].[Inventory_Tbl] CHECK CONSTRAINT [FK_Inventory_Tbl_Book_Tbl]
GO
ALTER TABLE [dbo].[Inventory_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Tbl_InventoryStatus_Tbl] FOREIGN KEY([Status])
REFERENCES [dbo].[InventoryStatus_Tbl] ([Status])
GO
ALTER TABLE [dbo].[Inventory_Tbl] CHECK CONSTRAINT [FK_Inventory_Tbl_InventoryStatus_Tbl]
GO
ALTER TABLE [dbo].[Loan_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Tbl_Book_Tbl] FOREIGN KEY([BookID])
REFERENCES [dbo].[Book_Tbl] ([BookID])
GO
ALTER TABLE [dbo].[Loan_Tbl] CHECK CONSTRAINT [FK_Loan_Tbl_Book_Tbl]
GO
ALTER TABLE [dbo].[Loan_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Tbl_BookStatus_Tbl] FOREIGN KEY([Status])
REFERENCES [dbo].[BookStatus_Tbl] ([Status])
GO
ALTER TABLE [dbo].[Loan_Tbl] CHECK CONSTRAINT [FK_Loan_Tbl_BookStatus_Tbl]
GO
ALTER TABLE [dbo].[Loan_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Tbl_Request_Tbl] FOREIGN KEY([ReqID])
REFERENCES [dbo].[Request_Tbl] ([ReqID])
GO
ALTER TABLE [dbo].[Loan_Tbl] CHECK CONSTRAINT [FK_Loan_Tbl_Request_Tbl]
GO
ALTER TABLE [dbo].[Request_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Request_Tbl_BookTitle_Tbl] FOREIGN KEY([BookTitleID])
REFERENCES [dbo].[BookTitle_Tbl] ([BookTitleID])
GO
ALTER TABLE [dbo].[Request_Tbl] CHECK CONSTRAINT [FK_Request_Tbl_BookTitle_Tbl]
GO
ALTER TABLE [dbo].[Request_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Request_Tbl_ReqStatus_Tbl] FOREIGN KEY([ReqStatus])
REFERENCES [dbo].[ReqStatus_Tbl] ([ReqStatus])
GO
ALTER TABLE [dbo].[Request_Tbl] CHECK CONSTRAINT [FK_Request_Tbl_ReqStatus_Tbl]
GO
ALTER TABLE [dbo].[Request_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_Request_Tbl_User_Tbl] FOREIGN KEY([UserID])
REFERENCES [dbo].[User_Tbl] ([UserID])
GO
ALTER TABLE [dbo].[Request_Tbl] CHECK CONSTRAINT [FK_Request_Tbl_User_Tbl]
GO
ALTER TABLE [dbo].[User_Tbl]  WITH CHECK ADD  CONSTRAINT [FK_User_Tbl_Role_Tbl] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role_Tbl] ([RoleID])
GO
ALTER TABLE [dbo].[User_Tbl] CHECK CONSTRAINT [FK_User_Tbl_Role_Tbl]
GO
/****** Object:  StoredProcedure [dbo].[add_author]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_author]
@AuthorID nvarchar(50),
@AuthorName nvarchar(50)
AS
BEGIN
	Insert into Author_Tbl (AuthorID, AuthorName)
	Values (@AuthorID, @AuthorName)
END


GO
/****** Object:  StoredProcedure [dbo].[add_book]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_book]
@BookID nvarchar(50),
@BookTitleID nvarchar(50)
AS
BEGIN
	Insert into Book_Tbl (BookID, BookTitleID) 
	Values (@BookID, @BookTitleID)
END


GO
/****** Object:  StoredProcedure [dbo].[add_book_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_book_status]
@Status int,
@StatusInfo nvarchar(50)
AS
BEGIN
	Insert into BookStatus_Tbl( Status, StatusInfo)
	Values (@Status, @StatusInfo)
END


GO
/****** Object:  StoredProcedure [dbo].[add_book_title]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_book_title]
@BookTitleID nvarchar(50),
@Title nvarchar(50),
@AuthorID nvarchar(50),
@CategoryID nvarchar(50)
AS
BEGIN
	Insert into BookTitle_Tbl(BookTitleID, Title, AuthorID, CategoryID)
	Values (@BookTitleID, @Title, @AuthorID, @CategoryID)
	
END


GO
/****** Object:  StoredProcedure [dbo].[add_category]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_category]
@CategoryID nvarchar(50),
@CategoryName nvarchar(50)
AS
BEGIN
	Insert into Category_Tbl(CategoryID, CateGoryName)
	Values (@CategoryID, @CategoryName)
END


GO
/****** Object:  StoredProcedure [dbo].[add_inventory]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[add_inventory]
@InventoryID nvarchar(50),
@BookID nvarchar(50),
@Index nvarchar(50),
@Status int
AS
BEGIN
	Insert into Inventory_Tbl (InventoryID, BookID, [Index], Status)
	Values (@InventoryID, @BookID, @Index, @Status)
END


GO
/****** Object:  StoredProcedure [dbo].[add_loan]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_loan]
@LoanID nvarchar(50),
@ReqID nvarchar(50),
@BookID nvarchar(50),
@ExpiredDate date,
@BorrowedDate date,
@Status int
AS
BEGIN
	Insert into Loan_Tbl( LoanID, ReqID, BookID, ExpiredDate, BorrowedDate, Status)
	Values (@LoanID, @ReqID, @BookID, @ExpiredDate, @BorrowedDate, @Status)
END


GO
/****** Object:  StoredProcedure [dbo].[add_request]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_request]
@ReqID nvarchar(50),
@UserID nvarchar(50),
@BookTitleID nvarchar(50),
@ReqDate date,
@ReqStatus int
AS
BEGIN
	Insert into Request_Tbl( ReqID, UserID, BookTitleID, ReqDate, ReqStatus)
	Values (@ReqID, @UserID, @BookTitleID, @ReqDate, @ReqStatus)
END


GO
/****** Object:  StoredProcedure [dbo].[add_request_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_request_status]
@ReqStatusInfo nvarchar(50),
@ReqStatus int
AS
BEGIN
	Insert into ReqStatus_Tbl( ReqStatus, ReqStatusInfo)
	Values (@ReqStatus, @ReqStatusInfo)
END


GO
/****** Object:  StoredProcedure [dbo].[add_role]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_role]
@RoleID nvarchar(50),
@RoleName nvarchar(50)
AS
BEGIN
	Insert into Role_Tbl(RoleID, RoleName)
	Values (@RoleID, @RoleName)
END


GO
/****** Object:  StoredProcedure [dbo].[add_user]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_user]
	@UserID nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Phone int,
	@Email nvarchar(50),
	@RoleID nvarchar(50)
AS
BEGIN
	Insert into User_Tbl (UserID, UserName, Password, Phone, Email, RoleID)
	Values (@UserID, @UserName, @Password, @Phone, @Email, @RoleID)
END


GO
/****** Object:  StoredProcedure [dbo].[check_login]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[check_login]
@UserID nvarchar(50),
@Password nvarchar(50)
AS
BEGIN
	Select au.RoleID
	From User_Tbl as au
	Where au.Password = @Password and au.UserID = @UserID
END


GO
/****** Object:  StoredProcedure [dbo].[delete_author]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_author]
@AuthorID nvarchar(50)
AS
BEGIN
	Delete Author_Tbl
	Where AuthorID = @AuthorID
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_book]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_book]
@BookID nvarchar(50)
AS
BEGIN
	Delete Book_Tbl
	Where BookID = @BookID
END


GO
/****** Object:  StoredProcedure [dbo].[delete_book_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_book_status]
@Status int
AS
BEGIN
	Delete BookStatus_Tbl
	Where Status = @Status
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_book_title]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_book_title]
	@BookTitleID nvarchar(50)
AS
BEGIN
	Delete BookTitle_Tbl
	Where BookTitleID = @BookTitleID
END


GO
/****** Object:  StoredProcedure [dbo].[delete_category]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_category]
@CategoryID nvarchar(50)
AS
BEGIN
	Delete Category_Tbl
	Where CategoryID = @CategoryID
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_inventory]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_inventory]
@InventoryID nvarchar(50)
AS
BEGIN
	Delete Inventory_Tbl
	Where InventoryID = @InventoryID
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_loan]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_loan]
@LoanID nvarchar(50)
AS
BEGIN
	Delete Loan_Tbl
	Where LoanID = @LoanID
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_request]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_request]
@ReqID nvarchar(50)
AS
BEGIN
	Delete Request_Tbl
	Where ReqID = @ReqID
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_request_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_request_status]
@ReqStatus int
AS
BEGIN
	Delete Request_Tbl
	Where ReqStatus = @ReqStatus
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_role]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_role]
@RoleID nvarchar(50)
AS
BEGIN
	Delete Role_Tbl
	Where RoleID = @RoleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[delete_user]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_user]
	@UserID nvarchar(50)
AS
BEGIN
	Delete User_Tbl
	Where UserID = @UserID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_author_by_author_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_author_by_author_id]
@AuthorID nvarchar(50)
AS
BEGIN
	Select * 
	From Author_Tbl as bt
	Where bt.AuthorID = @AuthorID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_book_by_book_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_book_by_book_id]
@BookID nvarchar(50)
AS
BEGIN
	Select * 
	From Book_Tbl as bt
	Where bt.BookID = @BookID
	
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_book_title_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_book_title_by_book_title_id]
@BookTitleID nvarchar(50)
AS
BEGIN
	Select * 
	From BookTitle_Tbl as bt
	Where bt.BookTitleID = @BookTitleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_book_title_with_title_and_author_name_and_category_name]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_book_title_with_title_and_author_name_and_category_name]
@Title nvarchar(50),
@AuthorName nvarchar(50),
@CategoryName nvarchar(50)
AS
BEGIN
	Select distinct bt.BookTitleID, bt.Title, bt.AuthorID, bt.CategoryID, au.AuthorName, ca.CategoryName
	From BookTitle_Tbl as bt 
	join Category_Tbl as ca on bt.CategoryID = ca.CategoryID
	join Author_Tbl as au on bt.AuthorID = au.AuthorID
	where bt.Title LIKE '%' + @Title + '%' and ca.CategoryName LIKE '%' + @CategoryName + '%' and au.AuthorName LIKE '%' + @AuthorName + '%'
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_book_title_with_title_or_author_name_or_category_name]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_book_title_with_title_or_author_name_or_category_name]
@Title nvarchar(50),
@AuthorName nvarchar(50),
@CategoryName nvarchar(50)
AS
BEGIN
	Select distinct bt.BookTitleID, bt.Title, bt.AuthorID, bt.CategoryID, au.AuthorName, ca.CategoryName
	From BookTitle_Tbl as bt 
	join Category_Tbl as ca on bt.CategoryID = ca.CategoryID
	join Author_Tbl as au on bt.AuthorID = au.AuthorID
	where bt.Title LIKE '%' + @Title + '%' or ca.CategoryName LIKE '%' + @CategoryName + '%' or au.AuthorName LIKE '%' + @AuthorName + '%'
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_category_by_category_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_category_by_category_id]
@CategoryID nvarchar(50)
AS
BEGIN
	Select * 
	From Category_Tbl as bt
	Where bt.CategoryID = @CategoryID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_inventory_by_inventory_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_inventory_by_inventory_id]
@InventoryID nvarchar(50)
AS
BEGIN
	Select * 
	From Inventory_Tbl as bt
	Where bt.InventoryID = @InventoryID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_loan_by_loan_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_loan_by_loan_id]
@LoanID nvarchar(50)
AS
BEGIN
	Select * 
	From Loan_Tbl as bt
	Where bt.LoanID = @LoanID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_loan_by_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[e_select_loan_by_status]
@Status int
AS
BEGIN
	Select *
	From Loan_Tbl as lo
	Where lo.Status = @Status
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_request_by_req_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_request_by_req_id]
@ReqID nvarchar(50)
AS
BEGIN
	Select * 
	From Request_Tbl as bt
	Where bt.ReqID = @ReqID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_request_by_user_id_and_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_request_by_user_id_and_status]
@UserID nvarchar(50),
@Status nvarchar(50)
AS
BEGIN
	Select req.ReqID, bk.Title, req.ReqDate, req.ReqStatus
	From Request_Tbl as req, User_Tbl as us, BookTitle_Tbl as bk
	Where req.UserID = us.UserID and us.UserID = @UserID and req.ReqStatus = @Status and bk.BookTitleID = req.BookTitleID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_role_by_role_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_role_by_role_id]
@RoleID nvarchar(50)
AS
BEGIN
	Select * 
	From Role_Tbl as bt
	Where bt.RoleID = @RoleID
END


GO
/****** Object:  StoredProcedure [dbo].[e_select_user_by_user_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[e_select_user_by_user_id]
@UserID nvarchar(50)
AS
BEGIN
	Select * 
	From User_Tbl as bt
	Where bt.UserID = @UserID
END


GO
/****** Object:  StoredProcedure [dbo].[e_update_inventory_status_by_book_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[e_update_inventory_status_by_book_id]
@BookID nvarchar(50),
@Status int
AS
BEGIN
	Update Inventory_Tbl
	Set Status = @Status
	Where BookID = @BookID
END


GO
/****** Object:  StoredProcedure [dbo].[e_update_loan_status_by_loan_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[e_update_loan_status_by_loan_id]
@LoanID nvarchar(50),
@Status int
AS
BEGIN
	Update Loan_Tbl
	Set Status = @Status
	Where LoanID = @LoanID
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_author]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_author]

AS
BEGIN
	Select *
	From Author_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_book]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_book]
AS
BEGIN
	Select *
	From Book_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_book_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_book_status]

AS
BEGIN
	Select *
	From BookStatus_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_book_title]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_book_title]
AS
BEGIN
	Select * 
	From BookTitle_Tbl

END


GO
/****** Object:  StoredProcedure [dbo].[select_all_category]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_category]

AS
BEGIN
	Select *
	From Category_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_inventory]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_inventory]

AS
BEGIN
	Select *
	From Inventory_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_loan]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_loan]

AS
BEGIN
	Select distinct lo.LoanID, us.UserID, lo.ReqID, lo.ExpiredDate, lo.BorrowedDate, lo.Status
	From Loan_Tbl as lo
	join Request_Tbl as req on lo.ReqID = req.ReqID
	join User_Tbl as us on us.UserID = req.UserID
	order by lo.LoanID ASC
END
GO
/****** Object:  StoredProcedure [dbo].[select_all_request]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_request]

AS
BEGIN
	Select *
	From Request_Tbl as req
	join User_Tbl as us on req.UserID = us.UserID
	order by req.ReqID ASC
END

GO
/****** Object:  StoredProcedure [dbo].[select_all_request_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_request_status]

AS
BEGIN
	Select *
	From ReqStatus_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_role]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_role]

AS
BEGIN
	Select *
	From Role_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_all_user]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_all_user]
AS
BEGIN
	Select *
	From User_Tbl
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_book_by_book_title_id]
@BookTitleID nvarchar(50)
AS
BEGIN
	Select b.BookID,b.BookTitleID
	From Book_Tbl as b, BookTitle_Tbl as bt
	Where b.BookTitleID = bt.BookTitleID and bt.BookTitleID = @BookTitleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_id_inventory_id_title_author_name_category_name_when_inventory_status_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_book_id_inventory_id_title_author_name_category_name_when_inventory_status_by_book_title_id]
@BookTitleID nvarchar(50),
@Status int
AS
BEGIN
	Select distinct bo.BookID, inv.InventoryID, bt.Title, au.AuthorName, ca.CateGoryName
	From BookTitle_Tbl as bt 
	join Category_Tbl as ca on bt.CategoryID = ca.CategoryID
	join Book_Tbl as bo on bo.BookTitleID = bt.BookTitleID
	join Author_Tbl as au on bt.AuthorID = au.AuthorID
	join Inventory_Tbl as inv on inv.Status = @Status and inv.BookID = bo.BookID
	where bt.BookTitleID = @BookTitleID
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_id_title_author_name_category_name_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_book_id_title_author_name_category_name_by_book_title_id]
@BookTitleID nvarchar(50)
AS
BEGIN
	Select bo.BookID, bt.Title, au.AuthorName, ca.CateGoryName
	From BookTitle_Tbl as bt
	join Category_Tbl as ca on ca.CategoryID = bt.CategoryID
	join Author_Tbl as au on au.AuthorID = bt.AuthorID
	join Book_Tbl as bo on bo.BookTitleID = bt.BookTitleID
	where bt.BookTitleID = @BookTitleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_id_title_author_name_category_name_by_title]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_book_id_title_author_name_category_name_by_title]
@Title nvarchar(50)
AS
BEGIN
	Select bo.BookID, bt.Title, au.AuthorName, ca.CateGoryName
	From BookTitle_Tbl as bt
	join Category_Tbl as ca on ca.CategoryID = bt.CategoryID
	join Author_Tbl as au on au.AuthorID = bt.AuthorID
	join Book_Tbl as bo on bo.BookTitleID = bt.BookTitleID
	where bt.Title = @Title
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_id_title_author_name_category_name_when_inventory_status_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_book_id_title_author_name_category_name_when_inventory_status_by_book_title_id]
@BookTitleID nvarchar(50),
@Status int
AS
BEGIN
	Select distinct bo.BookID, bt.Title, au.AuthorName, ca.CateGoryName
	From BookTitle_Tbl as bt 
	join Category_Tbl as ca on bt.CategoryID = ca.CategoryID
	join Book_Tbl as bo on bo.BookTitleID = bt.BookTitleID
	join Author_Tbl as au on bt.AuthorID = au.AuthorID
	join Inventory_Tbl as inv on inv.Status = @Status and inv.BookID = bo.BookID
	where bt.BookTitleID = @BookTitleID
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_id_title_author_name_category_name_when_inventory_status_by_title]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_book_id_title_author_name_category_name_when_inventory_status_by_title]
@Title nvarchar(50),
@Status int
AS
BEGIN
	Select distinct bo.BookID, bt.Title, au.AuthorName, ca.CateGoryName
	From BookTitle_Tbl as bt 
	join Category_Tbl as ca on bt.CategoryID = ca.CategoryID
	join Book_Tbl as bo on bo.BookTitleID = bt.BookTitleID
	join Author_Tbl as au on bt.AuthorID = au.AuthorID
	join Inventory_Tbl as inv on inv.Status = @Status and inv.BookID = bo.BookID
	where bt.Title = @Title
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_title_by_author_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_book_title_by_author_id]
@authorID nvarchar(50)
AS
BEGIN
	Select bo.BookTitleID,bo.Title,bo.AuthorID,bo.CategoryID
	From Author_Tbl as au, BookTitle_Tbl as bo
	Where bo.AuthorID = au.AuthorID and bo.AuthorID = @authorID
END


GO
/****** Object:  StoredProcedure [dbo].[select_book_title_by_category_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[select_book_title_by_category_id]
@CategoryID nvarchar(50)
AS
BEGIN
	Select bo.BookTitleID,bo.Title,bo.AuthorID,bo.CategoryID
	From Category_Tbl as ca, BookTitle_Tbl as bo
	Where ca.CategoryID = bo.CategoryID and ca.CategoryID = @CategoryID
	
END


GO
/****** Object:  StoredProcedure [dbo].[select_history_of_book_by_book_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_history_of_book_by_book_id]
@BookID nvarchar(50)
AS
BEGIN
	Select distinct us.UserName, req.ReqID, lo.BorrowedDate, lo.ExpiredDate, lo.Status
	From Request_Tbl as req
	join User_Tbl as us on us.UserID = req.UserID
	join Loan_Tbl as lo on lo.ReqID = req.ReqID
	join Book_Tbl as bo on bo.BookID = lo.BookID
	where bo.BookID = @BookID
END


GO
/****** Object:  StoredProcedure [dbo].[select_history_of_title_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_history_of_title_by_book_title_id]
@BookTitleID nvarchar(50)
AS
BEGIN
	Select distinct us.UserName, req.ReqID,req.ReqDate,reqS.ReqStatusInfo
	From Request_Tbl as req
	join User_Tbl as us on us.UserID = req.UserID
	join ReqStatus_Tbl as reqS on reqS.ReqStatus = req.ReqStatus
	join BookTitle_Tbl as bt on bt.BookTitleID = req.BookTitleID	
	where bt.BookTitleID = @BookTitleID
END


GO
/****** Object:  StoredProcedure [dbo].[select_history_of_user_by_user_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_history_of_user_by_user_id]
@UserID nvarchar(50),
@Status int
AS
BEGIN
	Select distinct bo.BookID, lo.BorrowedDate, lo.ExpiredDate, bt.Title
	From Request_Tbl as req
	join User_Tbl as us on us.UserID = req.UserID and us.UserID = @UserID
	join Loan_Tbl as lo on lo.ReqID = req.ReqID
	join BookTitle_Tbl as bt on req.BookTitleID = bt.BookTitleID
	join Book_Tbl as bo on bo.BookTitleID = bt.BookTitleID and bo.BookID = lo.BookID
	where lo.Status = @Status

END


GO
/****** Object:  StoredProcedure [dbo].[select_inventory_by_book_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_inventory_by_book_id]
@BookID nvarchar(50)
AS
BEGIN
	Select inv.InventoryID, inv.BookID, inv.[Index], inv.Status
	From Book_Tbl as b, Inventory_Tbl as inv
	Where b.BookID = inv.BookID and b.BookID = @BookID
	
END


GO
/****** Object:  StoredProcedure [dbo].[select_loan_by_request_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[select_loan_by_request_id]
@reqID nvarchar(50)
AS
BEGIN
	Select lo.LoanID,lo.BookID,lo.ReqID,lo.ExpiredDate,lo.BorrowedDate,lo.Status
	From Loan_Tbl as lo, Request_Tbl as req
	Where lo.ReqID = req.ReqID and req.ReqID = @reqID
	
END


GO
/****** Object:  StoredProcedure [dbo].[select_loan_by_user_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_loan_by_user_id]
@UserID nvarchar(50)
AS
BEGIN
	Select lo.LoanID, us.UserID, lo.BookID,lo.ReqID,lo.BorrowedDate,lo.ExpiredDate,lo.Status
	From Loan_Tbl as lo
	join Request_Tbl as req on lo.ReqID = req.ReqID
	join User_Tbl as us on us.UserID = req.UserID
	where us.UserID = @UserID
	order by lo.LoanID ASC
	
END
GO
/****** Object:  StoredProcedure [dbo].[select_loan_when_request_status_by_user_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_loan_when_request_status_by_user_id]
@ReqStatus int,
@UserID nvarchar(50)
AS
BEGIN
	Select lo.LoanID,lo.BookID,lo.ReqID,lo.BorrowedDate,lo.ExpiredDate,lo.Status
	From Loan_Tbl as lo
	join Request_Tbl as req on lo.ReqID = req.ReqID and req.ReqStatus = @ReqStatus
	join User_Tbl as us on us.UserID = req.UserID
	where us.UserID = @UserID
END


GO
/****** Object:  StoredProcedure [dbo].[select_request_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[select_request_by_book_title_id]
@BookTitleID nvarchar(50)
AS
BEGIN
	Select req.BookTitleID,req.ReqDate,req.ReqID,req.ReqStatus,req.UserID
	From Request_Tbl as req, BookTitle_Tbl as bo
	Where req.BookTitleID = bo.BookTitleID and bo.BookTitleID = @BookTitleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[select_request_by_request_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_request_by_request_status]
@Status int

AS
BEGIN
	Select *
	From Request_Tbl as bt
	where bt.ReqStatus = @Status
END


GO
/****** Object:  StoredProcedure [dbo].[select_request_by_user_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_request_by_user_id]
@UserID nvarchar(50)
AS
BEGIN
	Select req.ReqID,req.BookTitleID,req.ReqDate,req.ReqStatus,req.UserID
	From Request_Tbl as req, User_Tbl as us
	Where req.UserID = us.UserID and us.UserID = @UserID
	order by req.ReqID ASC
	
END
GO
/****** Object:  StoredProcedure [dbo].[select_role_name_by_role_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[select_role_name_by_role_id]
@roleID nvarchar(50)
AS
BEGIN
	Select ro.RoleName
	From Role_Tbl as ro
	Where ro.RoleID = @roleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[select_title_authorname_categoryname_by_book_title_id]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_title_authorname_categoryname_by_book_title_id]
@BookTitleID nvarchar(50)
AS
BEGIN
	Select bt.Title, au.AuthorName, ca.CateGoryName
	From BookTitle_Tbl as bt 
	join Category_Tbl as ca on bt.CategoryID = ca.CategoryID
	join Author_Tbl as au on au.AuthorID = bt.AuthorID
	where bt.BookTitleID = @BookTitleID
END


GO
/****** Object:  StoredProcedure [dbo].[select_title_authorname_categoryname_by_title]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[select_title_authorname_categoryname_by_title]
@Title nvarchar(50)
AS
BEGIN
	--Select bt.Title, au.AuthorName, ca.CateGoryName
	--From BookTitle_Tbl as bt, Category_Tbl ca, Author_Tbl as au
	--Where bt.Title = @Title and bt.CategoryID = ca.CateGoryName and bt.AuthorID = au.AuthorID
	Select bt.Title, au.AuthorName, ca.CateGoryName
	From BookTitle_Tbl as bt 
	join Category_Tbl as ca on bt.CategoryID = ca.CategoryID
	join Author_Tbl as au on au.AuthorID = bt.AuthorID
	where bt.Title = @Title 
END


GO
/****** Object:  StoredProcedure [dbo].[update_author]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_author]
@AuthorID nvarchar(50),
@AuthorName nvarchar(50)
AS
BEGIN
	Update Author_Tbl
	Set AuthorName = @AuthorName
	Where AuthorID = @AuthorID
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_book]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_book]
@BookID nvarchar(50),
@BookTitleID nvarchar(50)
AS
BEGIN
	Update Book_Tbl
	Set BookTitleID = @BookTitleID
	Where BookID = @BookID
END


GO
/****** Object:  StoredProcedure [dbo].[update_book_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_book_status]
@Status int,
@StatusInfo nvarchar(50)
AS
BEGIN
	Update BookStatus_Tbl
	Set StatusInfo = @StatusInfo
	Where Status = @Status
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_book_title]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_book_title]
@BookTitleID nvarchar(50),
@Title nvarchar(50),
@AuthorID nvarchar(50),
@CategoryID nvarchar(50)
AS
BEGIN
	Update BookTitle_Tbl
	Set AuthorID = @AuthorID,
		Title = @Title,
		CategoryID = @CategoryID
	Where BookTitleID = @BookTitleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_category]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_category]
@CategoryID nvarchar(50),
@CategoryName nvarchar(50)
AS
BEGIN
	Update Category_Tbl
	Set CateGoryName = @CategoryName
	Where CategoryID = @CategoryID
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_inventory]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_inventory]
@InventoryID nvarchar(50),
@BookID nvarchar(50),
@Index nvarchar(50),
@Status int
AS
BEGIN
	Update Inventory_Tbl
	Set BookID = @BookID,
		[Index] = @Index,
		Status = @Status
	Where InventoryID = @InventoryID
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_loan]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[update_loan]
@LoanID nvarchar(50),
@ReqID nvarchar(50),
@BookID nvarchar(50),
@ExpiredDate date,
@BorrowedDate date,
@Status int
AS
BEGIN
	Update Loan_Tbl
	Set ReqID = @ReqID,
		BookID = @BookID,
		ExpiredDate = @ExpiredDate,
		BorrowedDate = @BorrowedDate,
		Status = @Status
	Where LoanID = @LoanID
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_request]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_request]
@ReqID nvarchar(50),
@UserID nvarchar(50),
@BookTitleID nvarchar(50),
@ReqDate date,
@ReqStatus int
AS
BEGIN
	Update Request_Tbl
	Set UserID = @UserID,
	BookTitleID = @BookTitleID,
	ReqDate = @ReqDate,
	ReqStatus = @ReqStatus
	Where ReqID = @ReqID
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_request_status]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_request_status]
@ReqStatusInfo nvarchar(50),
@ReqStatus int
AS
BEGIN
	Update ReqStatus_Tbl
	Set ReqStatusInfo = @ReqStatusInfo
	Where ReqStatus = @ReqStatus
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_role]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[update_role]
@RoleID nvarchar(50),
@RoleName nvarchar(50)
AS
BEGIN
	Update Role_Tbl
	Set RoleName = @RoleName
	Where RoleID = @RoleID
	
END


GO
/****** Object:  StoredProcedure [dbo].[update_user]    Script Date: 3/19/2018 10:03:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[update_user]
	@UserID nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Phone int,
	@Email nvarchar(50),
	@RoleID nvarchar(50)
AS
BEGIN
	Update User_Tbl
	Set UserName = @UserName,
		Password = @Password,
		Phone = @Phone,
		Email = @Email,
		RoleID = @RoleID
	Where UserID = @UserID
END

GO
