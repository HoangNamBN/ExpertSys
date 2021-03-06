USE [master]
GO
/****** Object:  Database [diagnosisAnimal]    Script Date: 1/25/2022 15:03:40 ******/
CREATE DATABASE [diagnosisAnimal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'diagnosisAnimal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\diagnosisAnimal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'diagnosisAnimal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\diagnosisAnimal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [diagnosisAnimal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [diagnosisAnimal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [diagnosisAnimal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET ARITHABORT OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [diagnosisAnimal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [diagnosisAnimal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [diagnosisAnimal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [diagnosisAnimal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [diagnosisAnimal] SET  MULTI_USER 
GO
ALTER DATABASE [diagnosisAnimal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [diagnosisAnimal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [diagnosisAnimal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [diagnosisAnimal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [diagnosisAnimal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [diagnosisAnimal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [diagnosisAnimal] SET QUERY_STORE = OFF
GO
USE [diagnosisAnimal]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 1/25/2022 15:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[idEvent] [int] IDENTITY(1,1) NOT NULL,
	[EventName] [nvarchar](500) NULL,
	[Question] [nvarchar](500) NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[idEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventLaw]    Script Date: 1/25/2022 15:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventLaw](
	[idEvent] [int] NOT NULL,
	[idLaw] [int] NOT NULL,
	[HeSoTinCay] [decimal](3, 2) NULL,
 CONSTRAINT [PK_EventLaw] PRIMARY KEY CLUSTERED 
(
	[idEvent] ASC,
	[idLaw] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Law]    Script Date: 1/25/2022 15:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Law](
	[idLaw] [int] IDENTITY(1,1) NOT NULL,
	[LawName] [nvarchar](500) NULL,
	[HeSoTinCay] [decimal](3, 2) NULL,
 CONSTRAINT [PK_Law] PRIMARY KEY CLUSTERED 
(
	[idLaw] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 1/25/2022 15:03:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccount](
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[decentralization] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Event] ON 

INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (1, N'Hắt hơi hoi', N'bạn có hắt hơi không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (2, N'Chảy nước mắt', N'Bạn có chảy nước mắt không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (3, N'Chảy nước mũi', N'Bạn có chảy nước mũi không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (4, N'Gà khó thở rướn cổ lên để ngáp, đớp không khí', N'Bạn có thấy gà khó thở rướn cổ lên để ngáp, đớp không khí không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (5, N'Khó Thở', N'Bạn có thấy gà khó thở không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (6, N'Gà chậm lớn', N'Bạn có thấy gà chậm lớn không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (7, N'Vẩy mỏ', N'Bạn có thấy gà vẩy mỏ')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (8, N'gà ủ rũ', N'Bạn có thấy gà ủ rũ không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (9, N'lười đi lại', N'Bạn có thấy gà lười đi lại không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (10, N'lông xù', N'Bạn có thấy gà lông xù không ?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (11, N'uống nhiều nước', N'Bạn có thấy gà uống nhiều nước không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (12, N'phân lúc đầu màu trắng xanh, sau một thời gian chuyển sang màu nâu có lẫn máu và nhầy', N'Bạn có thấy phân gà lúc đầu màu trắng, xanh, sau một thời gian chuyển sang màu nâu có lẫn máu và nhầy không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (13, N'gà đi ỉa ra máu tươi', N'Bạn có thấy gà đi ỉa ra máu tươi không ?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (14, N'hậu môn dính bết máu', N'Bạn có thấy hậu môn gà dính bết máu không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (15, N'bỏ ăn', N'Bạn có thấy gà bỏ ăn không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (16, N'miệng chảy ra nước nhớt có lẫn bọt và máu', N'Bạn có thấy miệng gà chảy nước nhớt có lẫn bọt và máu không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (17, N'mào tím tái', N'Bạn có thấy mào gà tím tái?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (18, N'sốt cao ', N'Bạn có thấy gà sốt cao?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (19, N'gà ỉa phân trắng', N'Bạn có thấy phân gà màu trắng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (20, N'phân có nhiều chất nhầy', N'Bạn có thấy phân gà có chất nhầy không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (21, N'phân lợn cợn hạt cám', N'Bạn có thấy phân gà lợn cợn hạt cám không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (22, N'gà giảm ăn', N'Bạn có thấy gà giảm ăn không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (23, N'giảm uống', N'Bạn có thấy gà giảm uống không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (24, N'tiêu chảy', N'Bạn có thấy gà tiêu chảy không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (25, N'Chảy nước mũi loãng đến nhày', N'Bạn có thấy gà chảy nước mũi loãng đến nhày không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (26, N'viêm kết mạc mắt', N'Bạn có thấy gà viêm kết mạc mắt không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (27, N'thở có âm ran', N'Bạn có thấy gà thở có âm ran không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (28, N'chết rải rác, xác chết gầy', N'Bạn có thấy gà chết rải rác, xác chết gầy?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (29, N'gà giảm đẻ đột ngột', N'Bạn có thấy gà giảm đẻ đột ngột?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (30, N'trứng dị hình', N'Bạn có thấy trứng gà dị hình không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (31, N'vỏ trứng nhạt màu, nhăn nheo', N'Bạn có thấy vỏ trứng nhạt màu, nhăn nheo không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (32, N'lòng trắng trứng loãng', N'Bạn có thấy lòng trắng trứng loãng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (33, N'tỷ lệ ấm nớ giảm rất mạnh', N'Bạn có thấy tỷ lệ ấp nở giảm mạnh không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (34, N'nổi nhiều mụn ở đầu,mắt, quanh miệng', N'Bạn có thấy nổi nhiều mụn ở đầu, mắt, quanh miệng?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (35, N'mù mắt', N'Bạn có thấy gà bị mù mắt không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (36, N'nổi mụn trong miệng làm gà không ăn uống được', N'Bạn có thấy gà nổi mụn trong miệng làm gà không ăn uống được không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (37, N'sưng dây thần kinh đùi', N'Bạn có thấy dà bị sưng dây thần kinh đùi không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (38, N'gà không đi lại được', N'Bạn có thấy gà không đi lại được không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (39, N'liệt chân và cánh', N'Bạn có thấy gà liệt chân và cánh không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (40, N'gà vẹo cổ, mắt mù, ốm yếu rồi chết', N'Bạn có thấy gà vẹo cổ, mắt mù, ốm yếu rồi chết không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (41, N'viêm sưng phù đầu mặt', N'Bạn có thấy gà viêm sưng phù đầu mặt không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (42, N'lông xơ xác', N'Bạn có thấy lông gà  xơ xác không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (43, N'gà đẻ giảm sản lượng và chất lượng trứng', N'Bạn có thấy gà đẻ giảm sản lượng và chất lượng trứng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (44, N'hậu môn xưng to', N'Bạn có thấy hậu môn gà xưng to không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (45, N'cơ vùng hậu môn có bóp mạnh', N'Bạn có thấy cơ vùng hậu môn co bóp mạnh không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (46, N'phân gà trắng loãng, sau đó chuyển sang màu vàng trắng, xanh vàng đôi khi lẫn máu', N'Bạn có thấy phân gà trắng loãng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (47, N'run rẩy', N'Bạn có thấy gà run rẩy không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (48, N'gà sã cánh ỉa chảy phân xanh, phân vàng', N'Bạn có thấy gà sã cánh ỉa chảy phân xanh, phân vàng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (49, N'mào thâm', N'Bạn có thấy mào gà thâm không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (50, N'diều càng phồng nước và thức ăn, khi dốc ngược gà xuống dưới thấy có nước chảy ra', N'Bạn có thấy diều càng phồng nước và thức ăn, khi dốc ngược gà xuống dưới thấy có nước chảy ra không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (51, N'có hiện tượng thiếu máu, mào nhợt', N'Bạn có thấy có hiện tượng thiếu máu, mào nhợt không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (52, N'mổ khám gà tìm thấy giun trong ống ruột', N'Bạn có thấy khi mổ khám gà tìm thấy giun trong ông ruột không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (53, N'niêm mạc ruột sưng', N'Bạn có thấy niêm mạc ruột sưng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (54, N'tụ huyết ', N'Bạn có thấy gà  tụ huyết không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (55, N'xuất huyết', N'Bạn có thấy gà xuất huyết không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (56, N'mệt mỏi', N'Bạn có thấy gà mệt mỏi không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (57, N'mắt lim dim', N'Bạn có thấy gà mắt lim dim không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (58, N'đứng tách đàn', N'Bạn có thấy gà đứng tách đàn không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (59, N'giảm cân', N'Bạn có thấy gà giảm cân không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (60, N'gầy yếu ', N'Bạn có thấy gà gầy yếu không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (61, N'khát nước', N'Bạn có thấy gà khát nước không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (62, N'gà thở nặng nhọc, khó khăn, há mỏ để thở', N'Bạn có thấy gà thở nặng nhọc, khó khăn, há mỏ để thở không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (63, N'phổi túi khí có những chấm tổn thương màu trắng, vàng, xanh lá', N'Bạn có thấy phổi túi khí có những chấm tổn thương màu trắng, vàng, xanh lá không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (64, N'giảm sản lượng trứng', N'Bạn có thấy giảm sản lượng trứng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (65, N'lòng đỏ trứng nhạt', N'Bạn có thấy lòng đỏ trứng nhạt không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (66, N'tăng trọng kém ', N'Bạn có thấy gà tăng trọng kém không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (67, N'vỏ trứng mỏng', N'Bạn có thấy vỏ trứng mỏng không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (68, N'giảm sản lượng trứng và tỉ lệ ấp nở thấp', N'Bạn có thấy giảm sản lượng trứng và tỉ lệ ấp nở thấp không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (69, N'vẹo sương, chậm lớn', N'Bạn có thấy vẹo sương, chậm lớn không?')
INSERT [dbo].[Event] ([idEvent], [EventName], [Question]) VALUES (70, N'gà ốm', N'bạn có thấy gà ốm không?')
SET IDENTITY_INSERT [dbo].[Event] OFF
GO
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (1, 1, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (2, 1, CAST(0.15 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (3, 1, CAST(0.15 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (4, 1, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (4, 2, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (5, 2, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (5, 5, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (5, 13, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (6, 2, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (7, 2, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (8, 3, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (8, 4, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (8, 5, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (8, 8, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (9, 3, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (9, 4, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (10, 3, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (10, 4, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (10, 5, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (11, 3, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (11, 4, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (11, 13, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (12, 3, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (13, 4, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (14, 4, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (15, 5, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (15, 8, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (16, 5, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (17, 5, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (17, 13, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (18, 5, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (18, 8, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (18, 13, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (19, 6, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (20, 6, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (21, 6, CAST(0.25 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (22, 7, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (23, 7, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (25, 7, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (26, 7, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (27, 7, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (28, 9, CAST(0.40 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (29, 10, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (30, 10, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (31, 10, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (32, 10, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (34, 11, CAST(0.40 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (36, 11, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (37, 12, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (38, 12, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (39, 12, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (40, 12, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (48, 13, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[EventLaw] ([idEvent], [idLaw], [HeSoTinCay]) VALUES (70, 9, CAST(0.20 AS Decimal(3, 2)))
GO
SET IDENTITY_INSERT [dbo].[Law] ON 

INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (1, N'Bệnh ORT', CAST(0.80 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (2, N'Bệnh CRD( hen gà)', CAST(0.50 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (3, N'Bệnh cầu trùng ruột non', CAST(0.70 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (4, N'Cầu trùng manh tràng', CAST(0.80 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (5, N'Bệnh tụ huyết trùng', CAST(0.90 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (6, N'Bệnh thương hàn', CAST(0.75 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (7, N'Bệnh sổ mũi truyền nhiễm', CAST(0.80 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (8, N'Bệnh tiêu chảy do Ecoli( ở gà con )', CAST(0.60 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (9, N'Bệnh tiêu chảy do Ecoli ( ở gà lớn)', CAST(0.60 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (10, N'Hội chứng giảm đẻ', CAST(0.70 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (11, N'Bệnh đậu gà', CAST(0.70 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (12, N'Bệnh Marek', CAST(0.90 AS Decimal(3, 2)))
INSERT [dbo].[Law] ([idLaw], [LawName], [HeSoTinCay]) VALUES (13, N'Bệnh cúm gia cầm', CAST(0.70 AS Decimal(3, 2)))
SET IDENTITY_INSERT [dbo].[Law] OFF
GO
INSERT [dbo].[UserAccount] ([UserName], [Password], [decentralization]) VALUES (N'NamBN', N'1234567', N'ADMIN')
INSERT [dbo].[UserAccount] ([UserName], [Password], [decentralization]) VALUES (N'DucBN', N'1234567', N'User')
INSERT [dbo].[UserAccount] ([UserName], [Password], [decentralization]) VALUES (N'NamAnh', N'1234567', N'Experts')
GO
USE [master]
GO
ALTER DATABASE [diagnosisAnimal] SET  READ_WRITE 
GO
