USE [master]
GO
/****** Object:  Database [QUANLYSANBAY]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE DATABASE [QUANLYSANBAY]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLYSANBAY', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QUANLYSANBAY.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLYSANBAY_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\QUANLYSANBAY_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QUANLYSANBAY] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLYSANBAY].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLYSANBAY] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLYSANBAY] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLYSANBAY] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLYSANBAY] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLYSANBAY] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLYSANBAY] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLYSANBAY] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLYSANBAY] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLYSANBAY] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLYSANBAY] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLYSANBAY] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLYSANBAY] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLYSANBAY', N'ON'
GO
ALTER DATABASE [QUANLYSANBAY] SET QUERY_STORE = ON
GO
ALTER DATABASE [QUANLYSANBAY] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QUANLYSANBAY]
GO
/****** Object:  User [5]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE USER [5] FOR LOGIN [NV5] WITH DEFAULT_SCHEMA=[5]
GO
/****** Object:  User [124]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE USER [124] FOR LOGIN [NV1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [123]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE USER [123] FOR LOGIN [ADMIN1] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [11]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE USER [11] FOR LOGIN [NV11] WITH DEFAULT_SCHEMA=[11]
GO
/****** Object:  User [1]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE USER [1] FOR LOGIN [NV2] WITH DEFAULT_SCHEMA=[1]
GO
/****** Object:  DatabaseRole [NHANVIEN]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE ROLE [NHANVIEN]
GO
/****** Object:  DatabaseRole [ADMIN]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE ROLE [ADMIN]
GO
ALTER ROLE [ADMIN] ADD MEMBER [5]
GO
ALTER ROLE [db_owner] ADD MEMBER [5]
GO
ALTER ROLE [NHANVIEN] ADD MEMBER [124]
GO
ALTER ROLE [db_datareader] ADD MEMBER [124]
GO
ALTER ROLE [ADMIN] ADD MEMBER [123]
GO
ALTER ROLE [db_owner] ADD MEMBER [123]
GO
ALTER ROLE [NHANVIEN] ADD MEMBER [11]
GO
ALTER ROLE [db_datareader] ADD MEMBER [11]
GO
ALTER ROLE [NHANVIEN] ADD MEMBER [1]
GO
ALTER ROLE [db_datareader] ADD MEMBER [1]
GO
ALTER ROLE [db_datareader] ADD MEMBER [NHANVIEN]
GO
ALTER ROLE [db_owner] ADD MEMBER [ADMIN]
GO
/****** Object:  Schema [1]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE SCHEMA [1]
GO
/****** Object:  Schema [11]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE SCHEMA [11]
GO
/****** Object:  Schema [5]    Script Date: 2023-07-10 1:22:42 PM ******/
CREATE SCHEMA [5]
GO
/****** Object:  Table [dbo].[LOAIMAYBAY]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIMAYBAY](
	[MALOAI] [char](50) NOT NULL,
	[KIEUDANG] [nvarchar](100) NOT NULL,
	[TRONGLUONG] [nchar](20) NOT NULL,
	[SUCCHUA] [nchar](20) NOT NULL,
 CONSTRAINT [PK_LOAIMAYBAY] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Get_LoaiMayBay]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Get_LoaiMayBay]
AS
SELECT 'Kieu Dang: ' + KIEUDANG + ' - Trong Luong: ' + TRONGLUONG + ' - Suc Chua: ' + SUCCHUA + ' - Ma Loai: ' + MALOAI AS LOAI, MALOAI
FROM     dbo.LOAIMAYBAY
GO
/****** Object:  Table [dbo].[CHUMAYBAY]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUMAYBAY](
	[MACHU] [char](50) NOT NULL,
 CONSTRAINT [PK_Table_1_1] PRIMARY KEY CLUSTERED 
(
	[MACHU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUYENVE]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUYENVE](
	[MANV] [int] NOT NULL,
	[MALOAI] [char](50) NOT NULL,
 CONSTRAINT [PK_CHUYENVE] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC,
	[MALOAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVUBAOTRI]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVUBAOTRI](
	[IDDVBT] [nchar](10) NOT NULL,
	[MANV] [int] NOT NULL,
	[MADANGKY] [char](50) NOT NULL,
	[NGAYGIO] [date] NOT NULL,
	[SOGIOBAOTRI] [int] NOT NULL,
	[CONGVIEC] [ntext] NOT NULL,
 CONSTRAINT [PK__DICHVUBA__303D6D37156398A0] PRIMARY KEY CLUSTERED 
(
	[IDDVBT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOANHNGHIEP]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHNGHIEP](
	[MADOANHNGHIEP] [char](50) NOT NULL,
	[TENDOANHNGHIEP] [nvarchar](100) NOT NULL,
	[TENNGUOIDAIDIEN] [nvarchar](50) NOT NULL,
	[DIACHI] [ntext] NOT NULL,
	[SODIENTHOAI] [char](10) NOT NULL,
	[MACHU] [char](50) NOT NULL,
 CONSTRAINT [PK_DOANHNGHIEP] PRIMARY KEY CLUSTERED 
(
	[MADOANHNGHIEP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LAI]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LAI](
	[MALOAI] [char](50) NOT NULL,
	[MAPHICONG] [int] NOT NULL,
 CONSTRAINT [PK_LAI] PRIMARY KEY CLUSTERED 
(
	[MALOAI] ASC,
	[MAPHICONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAYBAY]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAYBAY](
	[MADANGKY] [char](50) NOT NULL,
	[MALOAI] [char](50) NOT NULL,
	[MANHACHUA] [char](50) NOT NULL,
 CONSTRAINT [PK_MAYBAY] PRIMARY KEY CLUSTERED 
(
	[MADANGKY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGUOI]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGUOI](
	[SOCMND] [char](12) NOT NULL,
	[HOTEN] [nvarchar](50) NOT NULL,
	[DIACHI] [ntext] NOT NULL,
	[SODIENTHOAI] [char](11) NOT NULL,
	[MACHU] [char](50) NULL,
 CONSTRAINT [PK_NGUOI] PRIMARY KEY CLUSTERED 
(
	[SOCMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACHUAMAYBAY]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACHUAMAYBAY](
	[MANHACHUA] [char](50) NOT NULL,
	[SUCCHUA] [nchar](50) NOT NULL,
	[VITRI] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[MANHACHUA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[SOCMND] [char](12) NOT NULL,
	[LUONG] [money] NOT NULL,
	[CA] [int] NOT NULL,
	[MANV] [int] NOT NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHICONG]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHICONG](
	[SOCMND] [char](12) NOT NULL,
	[MASOBANG] [char](50) NOT NULL,
	[NGAYCAP] [date] NOT NULL,
	[MAPHICONG] [int] NOT NULL,
 CONSTRAINT [PK_PHICONG] PRIMARY KEY CLUSTERED 
(
	[MAPHICONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SOHUU]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOHUU](
	[MADANGKY] [char](50) NOT NULL,
	[MACHU] [char](50) NOT NULL,
	[NGAYBATDAU] [date] NOT NULL,
 CONSTRAINT [PK_SOHUU_1] PRIMARY KEY CLUSTERED 
(
	[MADANGKY] ASC,
	[MACHU] ASC,
	[NGAYBATDAU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CHUMAYBAY] ([MACHU]) VALUES (N'1                                                 ')
INSERT [dbo].[CHUMAYBAY] ([MACHU]) VALUES (N'2                                                 ')
INSERT [dbo].[CHUMAYBAY] ([MACHU]) VALUES (N'3                                                 ')
INSERT [dbo].[CHUMAYBAY] ([MACHU]) VALUES (N'4                                                 ')
GO
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (1, N'1                                                 ')
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (1, N'2                                                 ')
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (1, N'3                                                 ')
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (2, N'1                                                 ')
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (2, N'3                                                 ')
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (3, N'2                                                 ')
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (123, N'1                                                 ')
INSERT [dbo].[CHUYENVE] ([MANV], [MALOAI]) VALUES (123, N'2                                                 ')
GO
INSERT [dbo].[DICHVUBAOTRI] ([IDDVBT], [MANV], [MADANGKY], [NGAYGIO], [SOGIOBAOTRI], [CONGVIEC]) VALUES (N'1         ', 2, N'1                                                 ', CAST(N'2020-02-01' AS Date), 10, N'Bảo Trì Động Cơ')
INSERT [dbo].[DICHVUBAOTRI] ([IDDVBT], [MANV], [MADANGKY], [NGAYGIO], [SOGIOBAOTRI], [CONGVIEC]) VALUES (N'2         ', 1, N'2                                                 ', CAST(N'2023-07-04' AS Date), 2, N'Vệ Sinh Chỗ NGồi')
INSERT [dbo].[DICHVUBAOTRI] ([IDDVBT], [MANV], [MADANGKY], [NGAYGIO], [SOGIOBAOTRI], [CONGVIEC]) VALUES (N'3         ', 123, N'2                                                 ', CAST(N'2023-06-27' AS Date), 5, N'ABCD')
GO
INSERT [dbo].[DOANHNGHIEP] ([MADOANHNGHIEP], [TENDOANHNGHIEP], [TENNGUOIDAIDIEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'DN1                                               ', N'Viettel', N'Hoang Khoa', N'TPHCM', N'973847276 ', N'4                                                 ')
GO
INSERT [dbo].[LAI] ([MALOAI], [MAPHICONG]) VALUES (N'1                                                 ', 1)
INSERT [dbo].[LAI] ([MALOAI], [MAPHICONG]) VALUES (N'1                                                 ', 2)
INSERT [dbo].[LAI] ([MALOAI], [MAPHICONG]) VALUES (N'2                                                 ', 1)
INSERT [dbo].[LAI] ([MALOAI], [MAPHICONG]) VALUES (N'2                                                 ', 2)
INSERT [dbo].[LAI] ([MALOAI], [MAPHICONG]) VALUES (N'3                                                 ', 10)
INSERT [dbo].[LAI] ([MALOAI], [MAPHICONG]) VALUES (N'4                                                 ', 10)
GO
INSERT [dbo].[LOAIMAYBAY] ([MALOAI], [KIEUDANG], [TRONGLUONG], [SUCCHUA]) VALUES (N'1                                                 ', N'Boeing', N'1000                ', N'100                 ')
INSERT [dbo].[LOAIMAYBAY] ([MALOAI], [KIEUDANG], [TRONGLUONG], [SUCCHUA]) VALUES (N'2                                                 ', N'Airbus', N'1500                ', N'125                 ')
INSERT [dbo].[LOAIMAYBAY] ([MALOAI], [KIEUDANG], [TRONGLUONG], [SUCCHUA]) VALUES (N'3                                                 ', N'ATR', N'350                 ', N'20                  ')
INSERT [dbo].[LOAIMAYBAY] ([MALOAI], [KIEUDANG], [TRONGLUONG], [SUCCHUA]) VALUES (N'4                                                 ', N'Antonov', N'900                 ', N'75                  ')
GO
INSERT [dbo].[MAYBAY] ([MADANGKY], [MALOAI], [MANHACHUA]) VALUES (N'1                                                 ', N'1                                                 ', N'1                                                 ')
INSERT [dbo].[MAYBAY] ([MADANGKY], [MALOAI], [MANHACHUA]) VALUES (N'2                                                 ', N'1                                                 ', N'2                                                 ')
INSERT [dbo].[MAYBAY] ([MADANGKY], [MALOAI], [MANHACHUA]) VALUES (N'3                                                 ', N'2                                                 ', N'1                                                 ')
INSERT [dbo].[MAYBAY] ([MADANGKY], [MALOAI], [MANHACHUA]) VALUES (N'4                                                 ', N'4                                                 ', N'3                                                 ')
GO
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'107839283   ', N'Thai Bao', N'Lao Cai', N'987654321  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'18279384    ', N'Gia Huy', N'TPHCM', N'982039483  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'287392837   ', N'Phạm Gia Bảo', N'Tiền Giang', N'944750240  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'374659382   ', N'Tran Anh', N'TPHCM', N'980273843  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'473829384   ', N'Phạm Thanh Tai', N'TPHCM', N'987654321  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'687926354   ', N'Nguyen Thi An', N'Van Lam', N'345173892  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'783647362   ', N'Minh Thuong', N'Quan 2', N'937461928  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'847374637   ', N'Van Van', N'TPHCM', N'987673764  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'89273623    ', N'Tran Hai', N'Binh Duong', N'972837463  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'893746284   ', N'Nguyen Thai Long', N'TPHCM', N'927381726  ', N'2                                                 ')
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'938472647   ', N'Ngoc Tu', N'Daklak', N'97868374   ', N'3                                                 ')
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'982038273   ', N'Nguyen Van A', N'Quan 3', N'378867879  ', NULL)
INSERT [dbo].[NGUOI] ([SOCMND], [HOTEN], [DIACHI], [SODIENTHOAI], [MACHU]) VALUES (N'987654321   ', N'Ngoc Ha', N'Tien Giang', N'987654398  ', NULL)
GO
INSERT [dbo].[NHACHUAMAYBAY] ([MANHACHUA], [SUCCHUA], [VITRI]) VALUES (N'1                                                 ', N'10                                                ', N'A')
INSERT [dbo].[NHACHUAMAYBAY] ([MANHACHUA], [SUCCHUA], [VITRI]) VALUES (N'2                                                 ', N'8                                                 ', N'B')
INSERT [dbo].[NHACHUAMAYBAY] ([MANHACHUA], [SUCCHUA], [VITRI]) VALUES (N'3                                                 ', N'15                                                ', N'C')
INSERT [dbo].[NHACHUAMAYBAY] ([MANHACHUA], [SUCCHUA], [VITRI]) VALUES (N'4                                                 ', N'8                                                 ', N'D')
GO
INSERT [dbo].[NHANVIEN] ([SOCMND], [LUONG], [CA], [MANV]) VALUES (N'287392837   ', 1000000.0000, 2, 1)
INSERT [dbo].[NHANVIEN] ([SOCMND], [LUONG], [CA], [MANV]) VALUES (N'687926354   ', 1000000.0000, 3, 2)
INSERT [dbo].[NHANVIEN] ([SOCMND], [LUONG], [CA], [MANV]) VALUES (N'987654321   ', 9000000.0000, 2, 3)
INSERT [dbo].[NHANVIEN] ([SOCMND], [LUONG], [CA], [MANV]) VALUES (N'982038273   ', 7000000.0000, 2, 5)
INSERT [dbo].[NHANVIEN] ([SOCMND], [LUONG], [CA], [MANV]) VALUES (N'847374637   ', 8000000.0000, 1, 11)
INSERT [dbo].[NHANVIEN] ([SOCMND], [LUONG], [CA], [MANV]) VALUES (N'374659382   ', 10000000.0000, 1, 123)
INSERT [dbo].[NHANVIEN] ([SOCMND], [LUONG], [CA], [MANV]) VALUES (N'783647362   ', 20000000.0000, 2, 124)
GO
INSERT [dbo].[PHICONG] ([SOCMND], [MASOBANG], [NGAYCAP], [MAPHICONG]) VALUES (N'18279384    ', N'BL1                                               ', CAST(N'2002-08-15' AS Date), 1)
INSERT [dbo].[PHICONG] ([SOCMND], [MASOBANG], [NGAYCAP], [MAPHICONG]) VALUES (N'89273623    ', N'BL2                                               ', CAST(N'2023-07-06' AS Date), 2)
INSERT [dbo].[PHICONG] ([SOCMND], [MASOBANG], [NGAYCAP], [MAPHICONG]) VALUES (N'938472647   ', N'BL4                                               ', CAST(N'2016-06-14' AS Date), 4)
INSERT [dbo].[PHICONG] ([SOCMND], [MASOBANG], [NGAYCAP], [MAPHICONG]) VALUES (N'107839283   ', N'BL3                                               ', CAST(N'2023-07-04' AS Date), 10)
GO
INSERT [dbo].[SOHUU] ([MADANGKY], [MACHU], [NGAYBATDAU]) VALUES (N'1                                                 ', N'1                                                 ', CAST(N'2023-07-05' AS Date))
INSERT [dbo].[SOHUU] ([MADANGKY], [MACHU], [NGAYBATDAU]) VALUES (N'2                                                 ', N'2                                                 ', CAST(N'2023-07-03' AS Date))
INSERT [dbo].[SOHUU] ([MADANGKY], [MACHU], [NGAYBATDAU]) VALUES (N'3                                                 ', N'1                                                 ', CAST(N'2023-07-03' AS Date))
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_MACHU]    Script Date: 2023-07-10 1:22:42 PM ******/
ALTER TABLE [dbo].[DOANHNGHIEP] ADD  CONSTRAINT [UK_MACHU] UNIQUE NONCLUSTERED 
(
	[MACHU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_SOCMND]    Script Date: 2023-07-10 1:22:42 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD  CONSTRAINT [UK_SOCMND] UNIQUE NONCLUSTERED 
(
	[SOCMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_MASOBANG]    Script Date: 2023-07-10 1:22:42 PM ******/
ALTER TABLE [dbo].[PHICONG] ADD  CONSTRAINT [UK_MASOBANG] UNIQUE NONCLUSTERED 
(
	[MASOBANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_PC_SOCMND]    Script Date: 2023-07-10 1:22:42 PM ******/
ALTER TABLE [dbo].[PHICONG] ADD  CONSTRAINT [UK_PC_SOCMND] UNIQUE NONCLUSTERED 
(
	[SOCMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHUYENVE]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENVE_LOAIMAYBAY] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAIMAYBAY] ([MALOAI])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CHUYENVE] CHECK CONSTRAINT [FK_CHUYENVE_LOAIMAYBAY]
GO
ALTER TABLE [dbo].[CHUYENVE]  WITH CHECK ADD  CONSTRAINT [FK_CHUYENVE_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[CHUYENVE] CHECK CONSTRAINT [FK_CHUYENVE_NHANVIEN]
GO
ALTER TABLE [dbo].[DICHVUBAOTRI]  WITH CHECK ADD  CONSTRAINT [FK_DICHVUBAOTRI_MAYBAY] FOREIGN KEY([MADANGKY])
REFERENCES [dbo].[MAYBAY] ([MADANGKY])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DICHVUBAOTRI] CHECK CONSTRAINT [FK_DICHVUBAOTRI_MAYBAY]
GO
ALTER TABLE [dbo].[DICHVUBAOTRI]  WITH CHECK ADD  CONSTRAINT [FK_DICHVUBAOTRI_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DICHVUBAOTRI] CHECK CONSTRAINT [FK_DICHVUBAOTRI_NHANVIEN]
GO
ALTER TABLE [dbo].[DOANHNGHIEP]  WITH CHECK ADD  CONSTRAINT [FK_DOANHNGHIEP_NGUOICHU] FOREIGN KEY([MACHU])
REFERENCES [dbo].[CHUMAYBAY] ([MACHU])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DOANHNGHIEP] CHECK CONSTRAINT [FK_DOANHNGHIEP_NGUOICHU]
GO
ALTER TABLE [dbo].[LAI]  WITH CHECK ADD  CONSTRAINT [FK_LAI_LOAIMAYBAY] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAIMAYBAY] ([MALOAI])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LAI] CHECK CONSTRAINT [FK_LAI_LOAIMAYBAY]
GO
ALTER TABLE [dbo].[LAI]  WITH CHECK ADD  CONSTRAINT [FK_LAI_PHICONG] FOREIGN KEY([MAPHICONG])
REFERENCES [dbo].[PHICONG] ([MAPHICONG])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LAI] CHECK CONSTRAINT [FK_LAI_PHICONG]
GO
ALTER TABLE [dbo].[MAYBAY]  WITH CHECK ADD  CONSTRAINT [FK_MAYBAY_LOAIMAYBAY] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAIMAYBAY] ([MALOAI])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MAYBAY] CHECK CONSTRAINT [FK_MAYBAY_LOAIMAYBAY]
GO
ALTER TABLE [dbo].[MAYBAY]  WITH CHECK ADD  CONSTRAINT [FK_MAYBAY_NHACHUAMAYBAY] FOREIGN KEY([MANHACHUA])
REFERENCES [dbo].[NHACHUAMAYBAY] ([MANHACHUA])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[MAYBAY] CHECK CONSTRAINT [FK_MAYBAY_NHACHUAMAYBAY]
GO
ALTER TABLE [dbo].[NGUOI]  WITH CHECK ADD  CONSTRAINT [FK_NGUOI_NGUOICHU] FOREIGN KEY([MACHU])
REFERENCES [dbo].[CHUMAYBAY] ([MACHU])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NGUOI] CHECK CONSTRAINT [FK_NGUOI_NGUOICHU]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_NGUOI] FOREIGN KEY([SOCMND])
REFERENCES [dbo].[NGUOI] ([SOCMND])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_NGUOI]
GO
ALTER TABLE [dbo].[PHICONG]  WITH CHECK ADD  CONSTRAINT [FK_PHICONG_NGUOI] FOREIGN KEY([SOCMND])
REFERENCES [dbo].[NGUOI] ([SOCMND])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PHICONG] CHECK CONSTRAINT [FK_PHICONG_NGUOI]
GO
ALTER TABLE [dbo].[SOHUU]  WITH CHECK ADD  CONSTRAINT [FK_SOHUU_MAYBAY] FOREIGN KEY([MADANGKY])
REFERENCES [dbo].[MAYBAY] ([MADANGKY])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SOHUU] CHECK CONSTRAINT [FK_SOHUU_MAYBAY]
GO
ALTER TABLE [dbo].[SOHUU]  WITH CHECK ADD  CONSTRAINT [FK_SOHUU_NGUOICHU] FOREIGN KEY([MACHU])
REFERENCES [dbo].[CHUMAYBAY] ([MACHU])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SOHUU] CHECK CONSTRAINT [FK_SOHUU_NGUOICHU]
GO
/****** Object:  StoredProcedure [dbo].[BackupData]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[INSERTCTCV]    Script Date: 6/25/2023 7:41:38 PM ******/
create PROCEDURE [dbo].[BackupData]
    @BackupFilePath NVARCHAR(500)
AS
BEGIN
    DECLARE @Backup NVARCHAR(1000);
    SET @Backup = 'BACKUP DATABASE QUANLYSANBAY TO DISK = ''' + @BackupFilePath + '''';
    EXEC sp_executesql @Backup;
END
GO
/****** Object:  StoredProcedure [dbo].[GetCacMayBayMaNhanVienChuyenVe]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[GetCacMayBayMaNhanVienChuyenVe]
    @ma_nv int
AS
BEGIN
	SELECT MADANGKY
	FROM MAYBAY
	INNER JOIN (
		SELECT MALOAI FROM CHUYENVE WHERE MANV = @ma_nv
	) AS LOAI ON MAYBAY.MALOAI = LOAI.MALOAI;
END


GO
/****** Object:  StoredProcedure [dbo].[LAY_THONG_TIN]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[LAY_THONG_TIN]
@TENLOGIN NVARCHAR(20)
AS
DECLARE @UID INT
DECLARE @MANV INT
SELECT @UID = uid, @MANV = NAME FROM SYS.sysusers
  WHERE SID = SUSER_SID(@TENLOGIN)

SELECT MANV = @MANV,
       HOTEN = (SELECT HOTEN FROM NGUOI WHERE SOCMND = (SELECT SOCMND FROM NHANVIEN WHERE NHANVIEN.MANV = @MANV)),
	   TENNHOM = NAME 
	FROM SYS.sysusers
	WHERE uid = (SELECT groupuid FROM SYS.sysmembers WHERE memberuid = @UID)

GO
/****** Object:  StoredProcedure [dbo].[sp_CheckNguoiTonTai]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_CheckNguoiTonTai] 
@CMND int
as
begin
	if exists(select * from QUANLYSANBAY.DBO.NGUOI where SOCMND = @CMND)
	return 1
	return 0
end

GO
/****** Object:  StoredProcedure [dbo].[sp_CheckTonTai]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[sp_CheckTonTai] 
@tablename nvarchar(50), @PK nvarchar(50), @PK_value nvarchar(50)
as
begin
	declare @sql nvarchar(300)
	set @sql = 'declare @count int = 0 '
	         + 'if exists(select * from QUANLYSANBAY.DBO.'+@tablename+'  where ' + @PK +'= '''+ @PK_value + ''') set @count = 1 ' 
			 + ' select @count'
	print(@sql)
    exec(@sql)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_get_max_value]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_get_max_value]
    @table_name NVARCHAR(255),
    @column_name NVARCHAR(255)
AS
BEGIN
    DECLARE @sql NVARCHAR(MAX);
    DECLARE @max_value INT;

    SET @sql = N'SELECT @max_value = MAX(' + QUOTENAME(@column_name) + N') FROM ' + QUOTENAME(@table_name);

    EXEC sp_executesql @sql, N'@max_value INT OUTPUT', @max_value = @max_value OUTPUT;

    SELECT @max_value AS MaxValue;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_ReportDSDoanhNghiep]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_ReportDSDoanhNghiep] 
AS
BEGIN
	SELECT MADOANHNGHIEP,TENDOANHNGHIEP,TENNGUOIDAIDIEN,DIACHI,SODIENTHOAI,MACHU FROM DOANHNGHIEP
END


GO
/****** Object:  StoredProcedure [dbo].[sp_ReportDVBT]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_ReportDVBT] 
AS
BEGIN
	SELECT IDDVBT,MANV,MADANGKY,NGAYGIO,SOGIOBAOTRI,CONGVIEC FROM DICHVUBAOTRI
END

GO
/****** Object:  StoredProcedure [dbo].[sp_ReportNhanVien]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReportNhanVien] 
AS
BEGIN
	SELECT NV.MANV, NV.CA, NV.LUONG, NV.SOCMND, NGUOI.DIACHI, NGUOI.HOTEN, NGUOI.SODIENTHOAI
	FROM NHANVIEN AS NV, NGUOI
	WHERE NV.SOCMND = NGUOI.SOCMND
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ReportPhiCong]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ReportPhiCong] 
AS
BEGIN
	
	SELECT PC.SOCMND,PC.MASOBANG,PC.NGAYCAP,PC.MAPHICONG, NGUOI.DIACHI, NGUOI.HOTEN, NGUOI.SODIENTHOAI
	FROM PHICONG AS PC, NGUOI
	WHERE PC.SOCMND = NGUOI.SOCMND
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNguoi]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SuaNguoi]
    @CMND char(12),
    @HoTen nvarchar(50),
    @DiaChi ntext,
    @SoDienThoai char(11),
    @MaChu char(50)
AS
BEGIN
    UPDATE NGUOI
    SET HOTEN = @HoTen,
        DIACHI = @DiaChi,
        SODIENTHOAI = @SoDienThoai,
        MACHU = @MaChu
    WHERE SOCMND = @CMND
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SuaNhanVien]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_SuaNhanVien]
    @MaNV int,
    @CMND char(12),
    @Luong money,
    @Ca int
AS
BEGIN
    UPDATE NHANVIEN
    SET SOCMND = @CMND,
        LUONG = @Luong,
        CA = @Ca
    WHERE MANV = @MaNV
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SuaPhiCong]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_SuaPhiCong]
    @MaPC INT,
    @CMND CHAR(12),
    @MaSoBang CHAR(50),
    @NgayCap DATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE PHICONG
    SET SOCMND = @CMND,
        MASOBANG = @MaSoBang,
        NGAYCAP = @NgayCap
    WHERE MAPHICONG = @MaPC;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[sp_TaoTaiKhoan]
    @LGNAME VARCHAR(50),  @PASS VARCHAR(50),
    @USERNAME VARCHAR(50),  @ROLE VARCHAR(50)     
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS, 'QUANLYSANBAY'
  IF (@RET =1)  -- LOGIN NAME BI TRUNG
  BEGIN
     RAISERROR ('Login name bị trùng', 16,1)
	 RETURN
  END 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RAISERROR ('Nhân viên dã có login name', 16,2)
       RETURN
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE = 'ADMIN'
  BEGIN
      EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  END
GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNguoi]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_ThemNguoi] 
@CMND char(12), @HoTen nvarchar(50), @DiaChi ntext, @SoDienThoai char(11), @MaChu char(50)
as
begin
	INSERT INTO NGUOI(SOCMND, HOTEN, DIACHI, SODIENTHOAI,MACHU)
	VALUES (@CMND, @HoTen, @DiaChi , @SoDienThoai, @MaChu)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemNhanVien]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[sp_ThemNhanVien] 
@CMND int, @Luong money, @Ca int, @MaNV int
as
begin
	INSERT INTO NHANVIEN (SOCMND, LUONG, CA, MANV)
	VALUES (@CMND, @Luong, @Ca, @MaNV)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemPhiCong]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[sp_ThemPhiCong] 
@CMND char(12), @MaSoBang char(50), @NgayCap date, @MaPC int
as
begin
	INSERT INTO PHICONG (SOCMND, MASOBANG, NGAYCAP, MAPHICONG)
	VALUES (@CMND, @MaSoBang, @NgayCap , @MaPC)
end

GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNguoi]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaNguoi]
    @CMND char(12)
AS
BEGIN
    DELETE FROM NGUOI
    WHERE SOCMND = @CMND
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaNhanVien]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaNhanVien]
    @MaNV int
AS
BEGIN
    DELETE FROM NHANVIEN
    WHERE MaNV = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaPhiCong]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaPhiCong]
    @MaPC int
AS
BEGIN
    DELETE FROM PhiCong
    WHERE MAPHICONG = @MaPC
END
GO
/****** Object:  StoredProcedure [dbo].[ThongTinNhanVien]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[ThongTinNhanVien]
AS
	SELECT NV.MANV, NV.CA, NV.LUONG, NV.SOCMND, NGUOI.DIACHI, NGUOI.HOTEN, NGUOI.SODIENTHOAI
	FROM NHANVIEN AS NV, NGUOI
	WHERE NV.SOCMND = NGUOI.SOCMND

GO
/****** Object:  StoredProcedure [dbo].[ThongTinPhiCong]    Script Date: 2023-07-10 1:22:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[ThongTinPhiCong]
AS
	SELECT PC.MAPHICONG, PC.MASOBANG, PC.NGAYCAP, PC.SOCMND, NGUOI.DIACHI, NGUOI.HOTEN, NGUOI.SODIENTHOAI
	FROM PHICONG AS PC, NGUOI
	WHERE PC.SOCMND = NGUOI.SOCMND

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "LOAIMAYBAY"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Get_LoaiMayBay'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Get_LoaiMayBay'
GO
USE [master]
GO
ALTER DATABASE [QUANLYSANBAY] SET  READ_WRITE 
GO
