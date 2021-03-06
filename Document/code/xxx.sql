USE [master]
GO
/****** Object:  Database [ChuanDoanBenh]    Script Date: 1/10/2019 7:42:36 PM ******/
CREATE DATABASE [ChuanDoanBenh]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChuanDoanBenh', FILENAME = N'E:\chuyennganh\kycuoi\chuandoanbenh\BTL_HeChuyenGia_N02\Database\New folder\ChuanDoanBenh.MDF' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ChuanDoanBenh_LOG', FILENAME = N'E:\chuyennganh\kycuoi\chuandoanbenh\BTL_HeChuyenGia_N02\Database\New folder\ChuanDoanBenh_LOG.LDF' , SIZE = 4096KB , MAXSIZE = 2048GB , FILEGROWTH = 1024KB )
GO
ALTER DATABASE [ChuanDoanBenh] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChuanDoanBenh].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChuanDoanBenh] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ChuanDoanBenh] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChuanDoanBenh] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChuanDoanBenh] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ChuanDoanBenh] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChuanDoanBenh] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ChuanDoanBenh] SET  MULTI_USER 
GO
ALTER DATABASE [ChuanDoanBenh] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChuanDoanBenh] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChuanDoanBenh] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChuanDoanBenh] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ChuanDoanBenh] SET DELAYED_DURABILITY = DISABLED 
GO
USE [ChuanDoanBenh]
GO
/****** Object:  Table [dbo].[Luat]    Script Date: 1/10/2019 7:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Luat](
	[MaLuat] [int] IDENTITY(1,1) NOT NULL,
	[TenLuat] [nvarchar](200) NOT NULL,
	[HeSoTinCay] [decimal](3, 2) NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[MaLuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LuatSuKien]    Script Date: 1/10/2019 7:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuatSuKien](
	[MaSuKien] [int] NOT NULL,
	[MaLuat] [int] NOT NULL,
	[HeSoTinCay] [decimal](3, 2) NOT NULL,
 CONSTRAINT [pk_LuatSuKien] PRIMARY KEY CLUSTERED 
(
	[MaSuKien] ASC,
	[MaLuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 1/10/2019 7:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [varchar](50) NOT NULL,
	[MatKhau] [varchar](30) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[Quyen] [bit] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SuKien]    Script Date: 1/10/2019 7:42:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuKien](
	[MaSuKien] [int] IDENTITY(1,1) NOT NULL,
	[TenSuKien] [nvarchar](200) NOT NULL,
	[CauHoi] [nvarchar](500) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSuKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Luat] ON 

INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (30, N'Bệnh ORT', CAST(0.80 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (31, N'Bệnh CRD( hen gà)', CAST(0.50 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1028, N'Bệnh cầu trùng ruột non', CAST(0.70 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1029, N'Cầu trùng manh tràng', CAST(0.80 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1030, N'Bệnh tụ huyết trùng', CAST(0.90 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1031, N'Bệnh thương hàn', CAST(0.75 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1032, N'Bệnh sổ mũi truyền nhiễm', CAST(0.80 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1033, N'Bệnh tiêu chảy do Ecoli( ở gà con )', CAST(0.60 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1034, N'Bệnh tiêu chảy do Ecoli ( ở gà lớn)', CAST(0.60 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1035, N'Hội chứng giảm đẻ', CAST(0.70 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1036, N'Bệnh đậu gà', CAST(0.70 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1037, N'Bệnh Marek', CAST(0.90 AS Decimal(3, 2)))
INSERT [dbo].[Luat] ([MaLuat], [TenLuat], [HeSoTinCay]) VALUES (1038, N'Bệnh cúm gia cầm', CAST(0.70 AS Decimal(3, 2)))
SET IDENTITY_INSERT [dbo].[Luat] OFF
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1, 30, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (2, 30, CAST(0.15 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (3, 30, CAST(0.15 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (4, 30, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (4, 31, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (5, 31, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (5, 1030, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (5, 1038, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (6, 31, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (7, 31, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (8, 1028, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (8, 1029, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (8, 1030, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (8, 1033, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (9, 1028, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (9, 1029, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (10, 1028, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (10, 1029, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (10, 1030, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (11, 1028, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (11, 1029, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (11, 1038, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (12, 1028, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1001, 1029, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1002, 1029, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1003, 1030, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1003, 1033, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1004, 1030, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1005, 1030, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1005, 1038, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1006, 1030, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1006, 1033, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1006, 1038, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1007, 1031, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1008, 1031, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1009, 1031, CAST(0.25 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1010, 1032, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1011, 1032, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1013, 1032, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1014, 1032, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1015, 1032, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1016, 1034, CAST(0.40 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1017, 1035, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1018, 1035, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1019, 1035, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1020, 1035, CAST(0.10 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1022, 1036, CAST(0.40 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1024, 1036, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1025, 1037, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1026, 1037, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1027, 1037, CAST(0.20 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1028, 1037, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1036, 1038, CAST(0.30 AS Decimal(3, 2)))
INSERT [dbo].[LuatSuKien] ([MaSuKien], [MaLuat], [HeSoTinCay]) VALUES (1062, 1034, CAST(0.20 AS Decimal(3, 2)))
SET IDENTITY_INSERT [dbo].[NguoiDung] ON 

INSERT [dbo].[NguoiDung] ([ID], [TenDangNhap], [MatKhau], [HoTen], [Quyen]) VALUES (1, N'admin', N'123456', N'Nguyễn Đình Văn', 1)
INSERT [dbo].[NguoiDung] ([ID], [TenDangNhap], [MatKhau], [HoTen], [Quyen]) VALUES (2, N'1', N'1', N'lại thanh bình', 0)
SET IDENTITY_INSERT [dbo].[NguoiDung] OFF
SET IDENTITY_INSERT [dbo].[SuKien] ON 

INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1, N'Hắt hơi hoi', N'bạn có hắt hơi không ?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (2, N'Chảy nước mắt', N'Bạn có chảy nước mắt không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (3, N'Chảy nước mũi', N'Bạn có chảy nước mũi không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (4, N'Gà khó thở rướn cổ lên để ngáp, đớp không khí', N'Bạn có thấy gà khó thở rướn cổ lên để ngáp, đớp không khí không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (5, N'Khó Thở', N'Bạn có thấy gà khó thở không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (6, N'Gà chậm lớn', N'Bạn có thấy gà chậm lớn không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (7, N'Vẩy mỏ', N'Bạn có thấy gà vẩy mỏ')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (8, N'gà ủ rũ', N'Bạn có thấy gà ủ rũ không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (9, N'lười đi lại', N'Bạn có thấy gà lười đi lại không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (10, N'lông xù', N'Bạn có thấy gà lông xù không ?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (11, N'uống nhiều nước', N'Bạn có thấy gà uống nhiều nước không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (12, N'phân lúc đầu màu trắng xanh, sau một thời gian chuyển sang màu nâu có lẫn máu và nhầy', N'Bạn có thấy phân gà lúc đầu màu trắng, xanh, sau một thời gian chuyển sang màu nâu có lẫn máu và nhầy không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1001, N'gà đi ỉa ra máu tươi', N'Bạn có thấy gà đi ỉa ra máu tươi không ?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1002, N'hậu môn dính bết máu', N'Bạn có thấy hậu môn gà dính bết máu không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1003, N'bỏ ăn', N'Bạn có thấy gà bỏ ăn không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1004, N'miệng chảy ra nước nhớt có lẫn bọt và máu', N'Bạn có thấy miệng gà chảy nước nhớt có lẫn bọt và máu không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1005, N'mào tím tái', N'Bạn có thấy mào gà tím tái?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1006, N'sốt cao ', N'Bạn có thấy gà sốt cao?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1007, N'gà ỉa phân trắng', N'Bạn có thấy phân gà màu trắng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1008, N'phân có nhiều chất nhầy', N'Bạn có thấy phân gà có chất nhầy không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1009, N'phân lợn cợn hạt cám', N'Bạn có thấy phân gà lợn cợn hạt cám không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1010, N'gà giảm ăn', N'Bạn có thấy gà giảm ăn không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1011, N'giảm uống', N'Bạn có thấy gà giảm uống không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1012, N'tiêu chảy', N'Bạn có thấy gà tiêu chảy không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1013, N'Chảy nước mũi loãng đến nhày', N'Bạn có thấy gà chảy nước mũi loãng đến nhày không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1014, N'viêm kết mạc mắt', N'Bạn có thấy gà viêm kết mạc mắt không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1015, N'thở có âm ran', N'Bạn có thấy gà thở có âm ran không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1016, N'chết rải rác, xác chết gầy', N'Bạn có thấy gà chết rải rác, xác chết gầy?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1017, N'gà giảm đẻ đột ngột', N'Bạn có thấy gà giảm đẻ đột ngột?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1018, N'trứng dị hình', N'Bạn có thấy trứng gà dị hình không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1019, N'vỏ trứng nhạt màu, nhăn nheo', N'Bạn có thấy vỏ trứng nhạt màu, nhăn nheo không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1020, N'lòng trắng trứng loãng', N'Bạn có thấy lòng trắng trứng loãng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1021, N'tỷ lệ ấm nớ giảm rất mạnh', N'Bạn có thấy tỷ lệ ấp nở giảm mạnh không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1022, N'nổi nhiều mụn ở đầu,mắt, quanh miệng', N'Bạn có thấy nổi nhiều mụn ở đầu, mắt, quanh miệng?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1023, N'mù mắt', N'Bạn có thấy gà bị mù mắt không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1024, N'nổi mụn trong miệng làm gà không ăn uống được', N'Bạn có thấy gà nổi mụn trong miệng làm gà không ăn uống được không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1025, N'sưng dây thần kinh đùi', N'Bạn có thấy dà bị sưng dây thần kinh đùi không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1026, N'gà không đi lại được', N'Bạn có thấy gà không đi lại được không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1027, N'liệt chân và cánh', N'Bạn có thấy gà liệt chân và cánh không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1028, N'gà vẹo cổ, mắt mù, ốm yếu rồi chết', N'Bạn có thấy gà vẹo cổ, mắt mù, ốm yếu rồi chết không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1029, N'viêm sưng phù đầu mặt', N'Bạn có thấy gà viêm sưng phù đầu mặt không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1030, N'lông xơ xác', N'Bạn có thấy lông gà  xơ xác không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1031, N'gà đẻ giảm sản lượng và chất lượng trứng', N'Bạn có thấy gà đẻ giảm sản lượng và chất lượng trứng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1032, N'hậu môn xưng to', N'Bạn có thấy hậu môn gà xưng to không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1033, N'cơ vùng hậu môn có bóp mạnh', N'Bạn có thấy cơ vùng hậu môn co bóp mạnh không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1034, N'phân gà trắng loãng, sau đó chuyển sang màu vàng trắng, xanh vàng đôi khi lẫn máu', N'Bạn có thấy phân gà trắng loãng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1035, N'run rẩy', N'Bạn có thấy gà run rẩy không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1036, N'gà sã cánh ỉa chảy phân xanh, phân vàng', N'Bạn có thấy gà sã cánh ỉa chảy phân xanh, phân vàng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1037, N'mào thâm', N'Bạn có thấy mào gà thâm không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1038, N'diều càng phồng nước và thức ăn, khi dốc ngược gà xuống dưới thấy có nước chảy ra', N'Bạn có thấy diều càng phồng nước và thức ăn, khi dốc ngược gà xuống dưới thấy có nước chảy ra không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1039, N'có hiện tượng thiếu máu, mào nhợt', N'Bạn có thấy có hiện tượng thiếu máu, mào nhợt không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1040, N'mổ khám gà tìm thấy giun trong ông ruột', N'Bạn có thấy khi mổ khám gà tìm thấy giun trong ông ruột không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1041, N'niêm mạc ruột sưng', N'Bạn có thấy niêm mạc ruột sưng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1042, N'tụ huyết ', N'Bạn có thấy gà  tụ huyết không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1043, N'xuất huyết', N'Bạn có thấy gà xuất huyết không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1044, N'mệt mỏi', N'Bạn có thấy gà mệt mỏi không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1045, N'mắt lim dim', N'Bạn có thấy gà mắt lim dim không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1046, N'đứng tách đàn', N'Bạn có thấy gà đứng tách đàn không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1047, N'giảm cân', N'Bạn có thấy gà giảm cân không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1048, N'gầy yếu ', N'Bạn có thấy gà gầy yếu không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1049, N'khát nước', N'Bạn có thấy gà khát nước không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1050, N'gà thở nặng nhọc, khó khăn, há mỏ để thở', N'Bạn có thấy gà thở nặng nhọc, khó khăn, há mỏ để thở không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1051, N'phổi túi khí có những chấm tổn thương màu trắng, vàng, xanh lá', N'Bạn có thấy phổi túi khí có những chấm tổn thương màu trắng, vàng, xanh lá không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1052, N'giảm sản lượng trứng', N'Bạn có thấy giảm sản lượng trứng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1053, N'lòng đỏ trứng nhạt', N'Bạn có thấy lòng đỏ trứng nhạt không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1054, N'tăng trọng kém ', N'Bạn có thấy gà tăng trọng kém không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1055, N'vỏ trứng mỏng', N'Bạn có thấy vỏ trứng mỏng không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1056, N'giảm sản lượng trứng và tỉ lệ ấp nở thấp', N'Bạn có thấy giảm sản lượng trứng và tỉ lệ ấp nở thấp không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1057, N'vẹo sương, chậm lớn', N'Bạn có thấy vẹo sương, chậm lớn không?')
INSERT [dbo].[SuKien] ([MaSuKien], [TenSuKien], [CauHoi]) VALUES (1062, N'gà ốm', N'bạn có thấy gà ốm không?')
SET IDENTITY_INSERT [dbo].[SuKien] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Luat__FD3714E008EA5793]    Script Date: 1/10/2019 7:42:36 PM ******/
ALTER TABLE [dbo].[Luat] ADD UNIQUE NONCLUSTERED 
(
	[TenLuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__NguoiDun__55F68FC0164452B1]    Script Date: 1/10/2019 7:42:36 PM ******/
ALTER TABLE [dbo].[NguoiDung] ADD UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__SuKien__C9A5B1BA023D5A04]    Script Date: 1/10/2019 7:42:36 PM ******/
ALTER TABLE [dbo].[SuKien] ADD UNIQUE NONCLUSTERED 
(
	[TenSuKien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LuatSuKien]  WITH CHECK ADD FOREIGN KEY([MaLuat])
REFERENCES [dbo].[Luat] ([MaLuat])
GO
ALTER TABLE [dbo].[LuatSuKien]  WITH CHECK ADD FOREIGN KEY([MaSuKien])
REFERENCES [dbo].[SuKien] ([MaSuKien])
GO
ALTER TABLE [dbo].[Luat]  WITH CHECK ADD  CONSTRAINT [chk_HeSoTinCay_Luat] CHECK  (([HeSoTinCay]>=(0) AND [HeSoTinCay]<=(1)))
GO
ALTER TABLE [dbo].[Luat] CHECK CONSTRAINT [chk_HeSoTinCay_Luat]
GO
ALTER TABLE [dbo].[LuatSuKien]  WITH CHECK ADD  CONSTRAINT [chk_HeSoTinCay_LuatSuKien] CHECK  (([HeSoTinCay]>(0) AND [HeSoTinCay]<=(1)))
GO
ALTER TABLE [dbo].[LuatSuKien] CHECK CONSTRAINT [chk_HeSoTinCay_LuatSuKien]
GO
USE [master]
GO
ALTER DATABASE [ChuanDoanBenh] SET  READ_WRITE 
GO
