USE [master]
GO
/****** Object:  Database [PerfectApp]    Script Date: 06/06/2017 9:29:47 ******/
CREATE DATABASE [PerfectApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PerfectApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PerfectApp.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PerfectApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\PerfectApp_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PerfectApp] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PerfectApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PerfectApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PerfectApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PerfectApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PerfectApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PerfectApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [PerfectApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PerfectApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PerfectApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PerfectApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PerfectApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PerfectApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PerfectApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PerfectApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PerfectApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PerfectApp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PerfectApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PerfectApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PerfectApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PerfectApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PerfectApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PerfectApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PerfectApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PerfectApp] SET RECOVERY FULL 
GO
ALTER DATABASE [PerfectApp] SET  MULTI_USER 
GO
ALTER DATABASE [PerfectApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PerfectApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PerfectApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PerfectApp] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [PerfectApp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'PerfectApp', N'ON'
GO
USE [PerfectApp]
GO
/****** Object:  Table [dbo].[BoPhanNhanVien]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BoPhanNhanVien](
	[MaBP] [varchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_BoPhanNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDV] [varchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHang] [varchar](50) NOT NULL,
	[MaLoaiHangHoa] [varchar](50) NULL,
	[MaKho] [varchar](50) NULL,
	[MaPhanLoai] [varchar](50) NULL,
	[TenHang] [nvarchar](50) NULL,
	[MaDV] [varchar](50) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[TonKhoToiThieu] [int] NULL,
	[TonHienTai] [int] NULL,
	[Anh] [varchar](50) NULL,
	[MaVachNSX] [varchar](50) NULL,
	[MaNCC] [varchar](50) NULL,
	[GiaMua] [float] NULL,
	[GiaBanSi] [float] NULL,
	[GiaBanLe] [float] NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](50) NOT NULL,
	[MaKhuVuc] [varchar](50) NULL,
	[TenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaSoThue] [varchar](50) NULL,
	[DienThoai] [int] NULL,
	[Email] [varchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[GioiHanNo] [int] NULL,
	[ChietKhau] [int] NULL,
	[Fax] [int] NULL,
	[Mobile] [int] NULL,
	[Website] [varchar](50) NULL,
	[NganHang] [nvarchar](50) NULL,
	[NoHienTai] [int] NULL,
	[NickYahoo] [varchar](50) NULL,
	[NickSkype] [varchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaKho] [varchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[KyHieu] [varchar](50) NULL,
	[NguoiQuanLy] [varchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [int] NULL,
	[Fax] [int] NULL,
	[Email] [varchar](50) NULL,
	[DienGia] [nvarchar](50) NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[MaKhuVuc] [varchar](50) NOT NULL,
	[TenKhuVuc] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaVach]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaVach](
	[SoLanIn] [int] NULL,
	[MaHang] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[Giaban] [nchar](10) NULL,
	[MaVach] [varchar](50) NOT NULL,
	[MaDV] [varchar](50) NULL,
 CONSTRAINT [PK_MaVach] PRIMARY KEY CLUSTERED 
(
	[MaVach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL,
	[MaKhuVuc] [varchar](50) NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[MaSoThue] [int] NULL,
	[DienThoai] [int] NULL,
	[Email] [varchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[GioiHanNo] [int] NULL,
	[ChietKhau] [int] NULL,
	[Fax] [int] NULL,
	[Mobile] [int] NULL,
	[Website] [varchar](50) NULL,
	[NganHang] [nvarchar](50) NULL,
	[NoHienTai] [int] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[ConQuanLy] [int] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[DiDong] [int] NULL,
	[MaBP] [varchar](50) NULL,
	[MaNVQL] [varchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomHang](
	[MaNHH] [varchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TyGia]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TyGia](
	[MaTyGia] [varchar](50) NOT NULL,
	[TenTyGia] [nvarchar](50) NULL,
	[TyGiaQuyDoi] [float] NULL,
	[ConQuanLy] [int] NULL,
 CONSTRAINT [PK_TyGia] PRIMARY KEY CLUSTERED 
(
	[MaTyGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserID]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserID](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VaiTro]    Script Date: 06/06/2017 9:29:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VaiTro](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MoTa] [nvarchar](100) NULL,
 CONSTRAINT [PK_VaiTro] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[KhachHang] ([MaKH], [MaKhuVuc], [TenKH], [DiaChi], [MaSoThue], [DienThoai], [Email], [TaiKhoan], [GioiHanNo], [ChietKhau], [Fax], [Mobile], [Website], [NganHang], [NoHienTai], [NickYahoo], [NickSkype], [NguoiLienHe], [ConQuanLy]) VALUES (N'KH0001', N'KV0001', N'Nguyễn Văn A', N'22 Phạm Văn Đồng', N'0123456789', 120456789, N'aa@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [GhiChu]) VALUES (N'KV0001', N'Miền Bắc', NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [GhiChu]) VALUES (N'KV0002', N'Miền Trung', NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [GhiChu]) VALUES (N'KV0003', N'Miền Nam', NULL)
SET IDENTITY_INSERT [dbo].[UserID] ON 

INSERT [dbo].[UserID] ([id], [username], [password]) VALUES (1, N'hien', N'123')
INSERT [dbo].[UserID] ([id], [username], [password]) VALUES (2, N'phat', N'123')
INSERT [dbo].[UserID] ([id], [username], [password]) VALUES (3, N'thang', N'123')
SET IDENTITY_INSERT [dbo].[UserID] OFF
SET IDENTITY_INSERT [dbo].[VaiTro] ON 

INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (1, N'Quản Trị', NULL)
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (2, N'Quản Lý Kho', NULL)
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (3, N'Nhân Viên', NULL)
SET IDENTITY_INSERT [dbo].[VaiTro] OFF
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_DonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_DonViTinh]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_KhoHang] FOREIGN KEY([MaKho])
REFERENCES [dbo].[KhoHang] ([MaKho])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_KhoHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhaCungCap]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhomHang] FOREIGN KEY([MaPhanLoai])
REFERENCES [dbo].[NhomHang] ([MaNHH])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhomHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_KhuVuc]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_NhanVien] FOREIGN KEY([NguoiQuanLy])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_NhanVien]
GO
ALTER TABLE [dbo].[MaVach]  WITH CHECK ADD  CONSTRAINT [FK_MaVach_DonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[MaVach] CHECK CONSTRAINT [FK_MaVach_DonViTinh]
GO
ALTER TABLE [dbo].[MaVach]  WITH CHECK ADD  CONSTRAINT [FK_MaVach_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[MaVach] CHECK CONSTRAINT [FK_MaVach_HangHoa]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_KhuVuc] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [FK_NhaCungCap_KhuVuc]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BoPhanNhanVien] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BoPhanNhanVien] ([MaBP])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BoPhanNhanVien]
GO
USE [master]
GO
ALTER DATABASE [PerfectApp] SET  READ_WRITE 
GO
