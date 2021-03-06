USE [master]
GO
/****** Object:  Database [BikersCode]    Script Date: 12/23/2018 7:38:40 AM ******/
CREATE DATABASE [BikersCode]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BikersCode', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BikersCode.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BikersCode_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BikersCode_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BikersCode] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BikersCode].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BikersCode] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BikersCode] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BikersCode] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BikersCode] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BikersCode] SET ARITHABORT OFF 
GO
ALTER DATABASE [BikersCode] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BikersCode] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BikersCode] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BikersCode] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BikersCode] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BikersCode] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BikersCode] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BikersCode] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BikersCode] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BikersCode] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BikersCode] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BikersCode] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BikersCode] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BikersCode] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BikersCode] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BikersCode] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BikersCode] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BikersCode] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BikersCode] SET  MULTI_USER 
GO
ALTER DATABASE [BikersCode] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BikersCode] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BikersCode] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BikersCode] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BikersCode] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BikersCode]
GO
/****** Object:  Table [dbo].[Accessory]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Accessory](
	[Accessory_ID] [int] NOT NULL,
	[Type] [varchar](50) NULL,
	[Size] [varchar](50) NULL,
 CONSTRAINT [PK_Accessory] PRIMARY KEY CLUSTERED 
(
	[Accessory_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill](
	[Bill_Number] [int] IDENTITY(1,1) NOT NULL,
	[Branch_Name] [varchar](50) NULL,
	[Customer_ID] [int] NULL,
	[Bill_Date] [date] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[Bill_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill Involves Product]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill Involves Product](
	[Product_ID] [int] NOT NULL,
	[Bill_Number] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Bill Involves Product] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC,
	[Bill_Number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Branch]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Branch](
	[Name] [varchar](50) NOT NULL,
	[Adress] [varchar](50) NOT NULL,
	[Manager_ID] [int] NULL,
 CONSTRAINT [PK_Branch] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Branch has Product]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Branch has Product](
	[Product_ID] [int] NOT NULL,
	[Branch_Name] [varchar](50) NOT NULL,
	[Quantity] [int] NULL CONSTRAINT [DF_Branch has Product_Quantity]  DEFAULT ((0)),
 CONSTRAINT [PK_Branch has Product] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC,
	[Branch_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Branch Sold Product]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Branch Sold Product](
	[Product_ID] [int] NOT NULL,
	[Branch_Name] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL CONSTRAINT [DF_Branch Sold Product_Quantity]  DEFAULT ((0)),
 CONSTRAINT [PK_Branch Sold Product] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC,
	[Branch_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Mobile] [varchar](50) NULL,
	[Points] [int] NOT NULL CONSTRAINT [DF_Customer_Points]  DEFAULT ((0)),
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departments](
	[Name] [varchar](50) NOT NULL,
	[Branch_Name] [varchar](50) NOT NULL,
	[Number_of_Employees] [int] NOT NULL CONSTRAINT [DF_Departments_Number of Employees]  DEFAULT ((0)),
	[Manager_ID] [int] NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Name] ASC,
	[Branch_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [char](25) NOT NULL,
	[Salary] [int] NOT NULL,
	[Mobile] [char](15) NULL,
	[Date_of_Hiring] [date] NOT NULL,
	[Department_Name] [varchar](50) NULL,
	[Branch_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Motorcycle]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Motorcycle](
	[Motorcycle_ID] [int] NOT NULL,
	[Model] [varchar](50) NOT NULL,
	[Type] [varchar](50) NULL,
	[Year] [int] NULL,
	[CC] [int] NULL,
	[Color] [varchar](50) NULL,
 CONSTRAINT [PK_Motorcycle] PRIMARY KEY CLUSTERED 
(
	[Motorcycle_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Product](
	[Product_ID] [int] IDENTITY(1,1) NOT NULL,
	[Price] [float] NULL CONSTRAINT [DF_Product_Price]  DEFAULT ((0)),
	[Total_Stock] [int] NULL CONSTRAINT [DF_Product_Total Stock]  DEFAULT ((0)),
	[Supplier_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Shipment Contains Product]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shipment Contains Product](
	[Shipment_ID] [int] NOT NULL,
	[Product_ID] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Shipment Contains Product] PRIMARY KEY CLUSTERED 
(
	[Shipment_ID] ASC,
	[Product_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shipments]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Shipments](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NULL CONSTRAINT [DF_Shipments_Status]  DEFAULT ('Pending Confirmation'),
	[Order_Date] [date] NOT NULL,
	[Arrival_Date] [date] NOT NULL,
	[Price] [float] NULL CONSTRAINT [DF_Shipments_Price]  DEFAULT ((0)),
	[Branch_Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Shipments] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SpareParts]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SpareParts](
	[SpareParts_ID] [int] NOT NULL,
	[Type] [varchar](50) NULL,
	[Condition] [varchar](50) NULL,
	[Belonging_Motorcycle_ID] [int] NULL,
 CONSTRAINT [PK_SpareParts] PRIMARY KEY CLUSTERED 
(
	[SpareParts_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[Name] [varchar](50) NOT NULL,
	[Start_Date] [date] NULL,
	[End_Date] [date] NULL,
	[Quota] [float] NULL CONSTRAINT [DF_Supplier_Quota]  DEFAULT ((0)),
	[Quota_Filled] [float] NULL CONSTRAINT [DF_Supplier_Quota Filled]  DEFAULT ((0)),
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12/23/2018 7:38:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [varchar](50) NOT NULL,
	[Pass] [varchar](200) NOT NULL,
	[Privilege] [int] NOT NULL,
	[Branch_Name] [varchar](50) NULL,
	[Department_Name] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Bill] ON 

INSERT [dbo].[Bill] ([Bill_Number], [Branch_Name], [Customer_ID], [Bill_Date]) VALUES (1, N'Maadi', 1, CAST(N'2018-12-23' AS Date))
INSERT [dbo].[Bill] ([Bill_Number], [Branch_Name], [Customer_ID], [Bill_Date]) VALUES (8, N'Maadi', 1, CAST(N'2018-12-23' AS Date))
INSERT [dbo].[Bill] ([Bill_Number], [Branch_Name], [Customer_ID], [Bill_Date]) VALUES (9, N'Maadi', 1, CAST(N'2018-12-23' AS Date))
INSERT [dbo].[Bill] ([Bill_Number], [Branch_Name], [Customer_ID], [Bill_Date]) VALUES (10, N'Maadi', 1, CAST(N'2018-12-23' AS Date))
INSERT [dbo].[Bill] ([Bill_Number], [Branch_Name], [Customer_ID], [Bill_Date]) VALUES (11, N'Maadi', 1, CAST(N'2018-12-23' AS Date))
INSERT [dbo].[Bill] ([Bill_Number], [Branch_Name], [Customer_ID], [Bill_Date]) VALUES (12, N'Maadi', 1, CAST(N'2018-12-23' AS Date))
SET IDENTITY_INSERT [dbo].[Bill] OFF
INSERT [dbo].[Bill Involves Product] ([Product_ID], [Bill_Number], [Quantity]) VALUES (1, 12, 2)
INSERT [dbo].[Branch] ([Name], [Adress], [Manager_ID]) VALUES (N'Maadi', N'11', NULL)
INSERT [dbo].[Branch] ([Name], [Adress], [Manager_ID]) VALUES (N'October', N'1', NULL)
INSERT [dbo].[Branch] ([Name], [Adress], [Manager_ID]) VALUES (N'Tagamo', N'1', NULL)
INSERT [dbo].[Branch] ([Name], [Adress], [Manager_ID]) VALUES (N'Zamalek', N'11', NULL)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'Maadi', 98)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'October', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'Tagamo', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'Zamalek', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'Maadi', NULL)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'October', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'Tagamo', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'Zamalek', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'Maadi', NULL)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'October', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'Tagamo', 0)
INSERT [dbo].[Branch has Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'Zamalek', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'Maadi', 2)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'October', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'Tagamo', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (1, N'Zamalek', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'Maadi', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'October', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'Tagamo', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (2, N'Zamalek', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'Maadi', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'October', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'Tagamo', 0)
INSERT [dbo].[Branch Sold Product] ([Product_ID], [Branch_Name], [Quantity]) VALUES (3, N'Zamalek', 0)
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([ID], [Name], [Mobile], [Points]) VALUES (1, N'Karim', NULL, 2000)
SET IDENTITY_INSERT [dbo].[Customer] OFF
INSERT [dbo].[Departments] ([Name], [Branch_Name], [Number_of_Employees], [Manager_ID]) VALUES (N'Customer Service', N'Maadi', 0, NULL)
INSERT [dbo].[Departments] ([Name], [Branch_Name], [Number_of_Employees], [Manager_ID]) VALUES (N'Sales', N'Maadi', 0, NULL)
INSERT [dbo].[Motorcycle] ([Motorcycle_ID], [Model], [Type], [Year], [CC], [Color]) VALUES (1, N'Suzuki', N'haha', 2000, 2000, N'aha')
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Product_ID], [Price], [Total_Stock], [Supplier_Name]) VALUES (1, 1000, 98, N'Athena')
INSERT [dbo].[Product] ([Product_ID], [Price], [Total_Stock], [Supplier_Name]) VALUES (2, 299, 0, N'Athena')
INSERT [dbo].[Product] ([Product_ID], [Price], [Total_Stock], [Supplier_Name]) VALUES (3, 1000, 0, N'Athena')
SET IDENTITY_INSERT [dbo].[Product] OFF
INSERT [dbo].[Shipment Contains Product] ([Shipment_ID], [Product_ID], [Quantity]) VALUES (1, 1, 100)
SET IDENTITY_INSERT [dbo].[Shipments] ON 

INSERT [dbo].[Shipments] ([ID], [Status], [Order_Date], [Arrival_Date], [Price], [Branch_Name]) VALUES (1, N'Arrived', CAST(N'2018-12-23' AS Date), CAST(N'2018-12-23' AS Date), 100000, N'Maadi')
SET IDENTITY_INSERT [dbo].[Shipments] OFF
INSERT [dbo].[Supplier] ([Name], [Start_Date], [End_Date], [Quota], [Quota_Filled]) VALUES (N'Athena', CAST(N'2018-12-23' AS Date), CAST(N'2018-12-25' AS Date), 0, 0)
INSERT [dbo].[Supplier] ([Name], [Start_Date], [End_Date], [Quota], [Quota_Filled]) VALUES (N'Hades', CAST(N'2018-12-23' AS Date), CAST(N'2018-12-25' AS Date), 0, 0)
INSERT [dbo].[Supplier] ([Name], [Start_Date], [End_Date], [Quota], [Quota_Filled]) VALUES (N'Zeus', CAST(N'2018-12-23' AS Date), CAST(N'2018-12-25' AS Date), 0, 0)
INSERT [dbo].[Users] ([Username], [Pass], [Privilege], [Branch_Name], [Department_Name]) VALUES (N'1', N'hlkWkjWSe2mJBStIrMBt72mTqfNHvxG0F3RKOlcPF/I=', 1, NULL, NULL)
INSERT [dbo].[Users] ([Username], [Pass], [Privilege], [Branch_Name], [Department_Name]) VALUES (N'2', N'hlkWkjWSe2mJBStIrMBt72mTqfNHvxG0F3RKOlcPF/I=', 2, N'Maadi', NULL)
INSERT [dbo].[Users] ([Username], [Pass], [Privilege], [Branch_Name], [Department_Name]) VALUES (N'3 ', N'hlkWkjWSe2mJBStIrMBt72mTqfNHvxG0F3RKOlcPF/I=', 3, N'Maadi', N'Customer Service')
INSERT [dbo].[Users] ([Username], [Pass], [Privilege], [Branch_Name], [Department_Name]) VALUES (N'4', N'hlkWkjWSe2mJBStIrMBt72mTqfNHvxG0F3RKOlcPF/I=', 4, N'Maadi ', N'Customer Service')
INSERT [dbo].[Users] ([Username], [Pass], [Privilege], [Branch_Name], [Department_Name]) VALUES (N'5', N'hlkWkjWSe2mJBStIrMBt72mTqfNHvxG0F3RKOlcPF/I=', 5, N'Maadi', N'Sales')
INSERT [dbo].[Users] ([Username], [Pass], [Privilege], [Branch_Name], [Department_Name]) VALUES (N'6', N'hlkWkjWSe2mJBStIrMBt72mTqfNHvxG0F3RKOlcPF/I=', 6, N'Maadi ', N'Sales')
ALTER TABLE [dbo].[Accessory]  WITH CHECK ADD  CONSTRAINT [FK_Accessory_Accessory] FOREIGN KEY([Accessory_ID])
REFERENCES [dbo].[Product] ([Product_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Accessory] CHECK CONSTRAINT [FK_Accessory_Accessory]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Branch] FOREIGN KEY([Branch_Name])
REFERENCES [dbo].[Branch] ([Name])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Branch]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Customer] FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customer] ([ID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Customer]
GO
ALTER TABLE [dbo].[Bill Involves Product]  WITH CHECK ADD  CONSTRAINT [FK_Bill Involves Product_Bill] FOREIGN KEY([Bill_Number])
REFERENCES [dbo].[Bill] ([Bill_Number])
GO
ALTER TABLE [dbo].[Bill Involves Product] CHECK CONSTRAINT [FK_Bill Involves Product_Bill]
GO
ALTER TABLE [dbo].[Bill Involves Product]  WITH CHECK ADD  CONSTRAINT [FK_Bill Involves Product_Product] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([Product_ID])
GO
ALTER TABLE [dbo].[Bill Involves Product] CHECK CONSTRAINT [FK_Bill Involves Product_Product]
GO
ALTER TABLE [dbo].[Branch]  WITH CHECK ADD  CONSTRAINT [FK_Branch_Employee] FOREIGN KEY([Manager_ID])
REFERENCES [dbo].[Employee] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Branch] CHECK CONSTRAINT [FK_Branch_Employee]
GO
ALTER TABLE [dbo].[Branch Sold Product]  WITH CHECK ADD  CONSTRAINT [FK_Branch Sold Product_Branch] FOREIGN KEY([Branch_Name])
REFERENCES [dbo].[Branch] ([Name])
GO
ALTER TABLE [dbo].[Branch Sold Product] CHECK CONSTRAINT [FK_Branch Sold Product_Branch]
GO
ALTER TABLE [dbo].[Branch Sold Product]  WITH CHECK ADD  CONSTRAINT [FK_Branch Sold Product_Product] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([Product_ID])
GO
ALTER TABLE [dbo].[Branch Sold Product] CHECK CONSTRAINT [FK_Branch Sold Product_Product]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Branch] FOREIGN KEY([Branch_Name])
REFERENCES [dbo].[Branch] ([Name])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Branch]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Employee] FOREIGN KEY([Manager_ID])
REFERENCES [dbo].[Employee] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Departments] FOREIGN KEY([Department_Name], [Branch_Name])
REFERENCES [dbo].[Departments] ([Name], [Branch_Name])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Departments]
GO
ALTER TABLE [dbo].[Motorcycle]  WITH CHECK ADD  CONSTRAINT [FK_Motorcycle_Product] FOREIGN KEY([Motorcycle_ID])
REFERENCES [dbo].[Product] ([Product_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Motorcycle] CHECK CONSTRAINT [FK_Motorcycle_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Supplier] FOREIGN KEY([Supplier_Name])
REFERENCES [dbo].[Supplier] ([Name])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Supplier]
GO
ALTER TABLE [dbo].[Shipment Contains Product]  WITH CHECK ADD  CONSTRAINT [FK_Shipment Contains Product_Product] FOREIGN KEY([Product_ID])
REFERENCES [dbo].[Product] ([Product_ID])
GO
ALTER TABLE [dbo].[Shipment Contains Product] CHECK CONSTRAINT [FK_Shipment Contains Product_Product]
GO
ALTER TABLE [dbo].[Shipment Contains Product]  WITH CHECK ADD  CONSTRAINT [FK_Shipment Contains Product_Shipments] FOREIGN KEY([Shipment_ID])
REFERENCES [dbo].[Shipments] ([ID])
GO
ALTER TABLE [dbo].[Shipment Contains Product] CHECK CONSTRAINT [FK_Shipment Contains Product_Shipments]
GO
ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Shipments_Branch] FOREIGN KEY([Branch_Name])
REFERENCES [dbo].[Branch] ([Name])
GO
ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Shipments_Branch]
GO
ALTER TABLE [dbo].[SpareParts]  WITH CHECK ADD  CONSTRAINT [FK_SpareParts_Motorcycle] FOREIGN KEY([Belonging_Motorcycle_ID])
REFERENCES [dbo].[Motorcycle] ([Motorcycle_ID])
GO
ALTER TABLE [dbo].[SpareParts] CHECK CONSTRAINT [FK_SpareParts_Motorcycle]
GO
ALTER TABLE [dbo].[SpareParts]  WITH CHECK ADD  CONSTRAINT [FK_SpareParts_Product] FOREIGN KEY([SpareParts_ID])
REFERENCES [dbo].[Product] ([Product_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SpareParts] CHECK CONSTRAINT [FK_SpareParts_Product]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Departments] FOREIGN KEY([Department_Name], [Branch_Name])
REFERENCES [dbo].[Departments] ([Name], [Branch_Name])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Departments]
GO
USE [master]
GO
ALTER DATABASE [BikersCode] SET  READ_WRITE 
GO
