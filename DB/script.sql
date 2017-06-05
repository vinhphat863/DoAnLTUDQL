USE [PerfectApp]
GO
/****** Object:  Table [dbo].[BoPhanNhanVien]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BoPhanNhanVien](
	[MaBP] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[ConQuanLy] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDV] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[ConQuanLy] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 6/5/2017 6:03:36 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](50) NULL,
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
	[ConQuanLy] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaKho] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[KyHieu] [varchar](50) NULL,
	[NguoiQuanLy] [nvarchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [int] NULL,
	[Fax] [int] NULL,
	[Email] [varchar](50) NULL,
	[DienGia] [nvarchar](50) NULL,
	[ConQuanLy] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhuVuc](
	[MaKhuVuc] [varchar](50) NULL,
	[TenKhuVuc] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaVach]    Script Date: 6/5/2017 6:03:36 PM ******/
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
	[MaVach] [varchar](50) NULL,
	[MaDV] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NULL,
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
	[ConQuanLy] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[ConQuanLy] [int] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[DiDong] [int] NULL,
	[MaBP] [varchar](50) NULL,
	[MaNVQL] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhomHang](
	[MaNHH] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](100) NULL,
	[ConQuanLy] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TyGia]    Script Date: 6/5/2017 6:03:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TyGia](
	[MaTyGia] [varchar](50) NULL,
	[TenTyGia] [nvarchar](50) NULL,
	[TyGiaQuyDoi] [float] NULL,
	[ConQuanLy] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserID]    Script Date: 6/5/2017 6:03:36 PM ******/
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
/****** Object:  Table [dbo].[VaiTro]    Script Date: 6/5/2017 6:03:36 PM ******/
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
