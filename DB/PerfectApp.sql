USE [PerfectApp]
GO
/****** Object:  Table [dbo].[BoPhanNhanVien]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_BoPhanNhanVien] PRIMARY KEY CLUSTERED 
(
	[MaBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhapHang]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhapHang](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieu] [varchar](50) NULL,
	[MaHang] [varchar](50) NULL,
	[MaDonVi] [varchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChiTietPhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DieuKhoanThanhToan]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DieuKhoanThanhToan](
	[MaDKTT] [varchar](50) NOT NULL,
	[TenDKTT] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_DieuKhoanThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaDKTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_DonViTinh] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[MaDV] [varchar](50) NULL,
	[MaNCC] [varchar](50) NULL,
	[MaVachNSX] [varchar](50) NULL,
	[TenHang] [nvarchar](50) NULL,
	[XuatXu] [nvarchar](50) NULL,
	[TonKhoToiThieu] [int] NULL,
	[TonHienTai] [int] NULL,
	[Anh] [varchar](50) NULL,
	[GiaMua] [float] NULL,
	[GiaBanSi] [float] NULL,
	[GiaBanLe] [float] NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_HangHoa] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HinhThucThanhToan]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HinhThucThanhToan](
	[MaHTTT] [varchar](50) NOT NULL,
	[TenHTTT] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_HinhThucThanhToan] PRIMARY KEY CLUSTERED 
(
	[MaHTTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[DienThoai] [varchar](11) NULL,
	[Email] [varchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[GioiHanNo] [int] NULL,
	[NganHang] [nvarchar](50) NULL,
	[NoHienTai] [int] NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhoHang]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhoHang](
	[MaKho] [varchar](50) NOT NULL,
	[NguoiQuanLy] [varchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[KyHieu] [varchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [int] NULL,
	[Fax] [int] NULL,
	[Email] [varchar](50) NULL,
	[DienGia] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_KhoHang] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhuVuc]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_KhuVuc] PRIMARY KEY CLUSTERED 
(
	[MaKhuVuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MaVach]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MaVach](
	[MaVach] [varchar](50) NOT NULL,
	[MaDV] [varchar](50) NULL,
	[SoLanIn] [int] NULL,
	[MaHang] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[Giaban] [nchar](10) NULL,
 CONSTRAINT [PK_MaVach] PRIMARY KEY CLUSTERED 
(
	[MaVach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[DienThoai] [varchar](11) NULL,
	[Email] [varchar](50) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[GioiHanNo] [int] NULL,
	[ChietKhau] [int] NULL,
	[Fax] [int] NULL,
	[Mobile] [varchar](11) NULL,
	[Website] [varchar](50) NULL,
	[NganHang] [nvarchar](50) NULL,
	[NoHienTai] [int] NULL,
	[ChucVu] [nvarchar](50) NULL,
	[NguoiLienHe] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[MaBP] [varchar](50) NULL,
	[MaNVQL] [varchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[DienThoai] [varchar](11) NULL,
	[DiDong] [varchar](11) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNHH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhanLoaiHangHoa]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhanLoaiHangHoa](
	[MaPhanLoai] [varchar](50) NOT NULL,
	[TenPhanLoai] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_PhanLoaiHangHoa] PRIMARY KEY CLUSTERED 
(
	[MaPhanLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPhieu] [varchar](50) NOT NULL,
	[MaNCC] [varchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [varchar](11) NULL,
	[Ngay] [date] NULL,
	[GhiChu] [nvarchar](50) NULL,
	[SoHoaDonVAT] [varchar](50) NULL,
	[SoHoaDonVietTay] [varchar](50) NULL,
	[MaNV] [varchar](50) NULL,
	[MaKho] [varchar](50) NULL,
	[MaDKTT] [varchar](50) NULL,
	[MaHTTT] [varchar](50) NULL,
	[HanTT] [date] NULL,
 CONSTRAINT [PK_PhieuNhapHang] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PhieuTemp]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PhieuTemp](
	[MaPhieu] [int] IDENTITY(1,1) NOT NULL,
	[MaHang] [varchar](50) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[TenDonVi] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_PhieuTemp_1] PRIMARY KEY CLUSTERED 
(
	[MaPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TyGia]    Script Date: 6/14/2017 2:01:49 PM ******/
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
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_TyGia] PRIMARY KEY CLUSTERED 
(
	[MaTyGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserID]    Script Date: 6/14/2017 2:01:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserID](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[ConQuanLy] [bit] NULL,
 CONSTRAINT [PK_UserID] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VaiTro]    Script Date: 6/14/2017 2:01:49 PM ******/
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
INSERT [dbo].[BoPhanNhanVien] ([MaBP], [Ten], [GhiChu], [ConQuanLy]) VALUES (N'BP0001', N'Bộ Phận 1', NULL, 1)
INSERT [dbo].[BoPhanNhanVien] ([MaBP], [Ten], [GhiChu], [ConQuanLy]) VALUES (N'BP0002', N'Bộ Phận 2', NULL, 0)
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhapHang] ON 

INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (1, N'PNH0003', N'HH0001', N'DV0001', 3, 5.6, N'45')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (2, N'PNH0003', N'HH0001', N'DV0001', 1, 3.6, N'1')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (3, N'PNH0004', N'HH0001', N'DV0001', 3, 5, N'8')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (4, N'PNH0005', N'HH0001', N'DV0001', 5, 6.5, N'yu')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (5, N'PNH0005', N'HH0001', N'DV0001', 5, 9, N'ôp')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (6, N'PNH0006', N'HH0001', N'DV0001', 3, 4, N'acb')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (7, N'PNH0007', N'HH0001', N'DV0001', 1, 3, N'4')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (8, N'PNH0007', N'HH0001', N'DV0001', 2, 3, N'5')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (9, N'PNH0010', N'HH0001', N'DV0001', 3, 5, N'6')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (10, N'PNH0010', N'HH0001', N'DV0001', 6, 7, N'8')
INSERT [dbo].[ChiTietPhieuNhapHang] ([MaChiTiet], [MaPhieu], [MaHang], [MaDonVi], [SoLuong], [DonGia], [GhiChu]) VALUES (11, N'PNH0011', N'HH0001', N'DV0001', 5, 6, N'8')
SET IDENTITY_INSERT [dbo].[ChiTietPhieuNhapHang] OFF
INSERT [dbo].[DieuKhoanThanhToan] ([MaDKTT], [TenDKTT], [ConQuanLy]) VALUES (N'DKTT0001', N'Thanh Toán Ngay', NULL)
INSERT [dbo].[DieuKhoanThanhToan] ([MaDKTT], [TenDKTT], [ConQuanLy]) VALUES (N'DKTT0002', N'Công Nợ', NULL)
INSERT [dbo].[DonViTinh] ([MaDV], [Ten], [GhiChu], [ConQuanLy]) VALUES (N'DV0001', N'Cái', NULL, 1)
INSERT [dbo].[HangHoa] ([MaHang], [MaLoaiHangHoa], [MaKho], [MaPhanLoai], [MaDV], [MaNCC], [MaVachNSX], [TenHang], [XuatXu], [TonKhoToiThieu], [TonHienTai], [Anh], [GiaMua], [GiaBanSi], [GiaBanLe], [ConQuanLy]) VALUES (N'HH0001', N'NHH0001', N'KH0001', N'PL0001', N'DV0001', N'NCC0001', N'HH0001', N'Samsung S8', N'Hàn Quốc', 50, 70, NULL, 12000000, 12500000, 13000000, 1)
INSERT [dbo].[HinhThucThanhToan] ([MaHTTT], [TenHTTT], [ConQuanLy]) VALUES (N'HTTT0001', N'Tiền Mặt', NULL)
INSERT [dbo].[HinhThucThanhToan] ([MaHTTT], [TenHTTT], [ConQuanLy]) VALUES (N'HTTT0002', N'Chuyển Khoản', NULL)
INSERT [dbo].[KhachHang] ([MaKH], [MaKhuVuc], [TenKH], [DiaChi], [MaSoThue], [DienThoai], [Email], [TaiKhoan], [GioiHanNo], [NganHang], [NoHienTai], [NguoiLienHe], [ConQuanLy]) VALUES (N'KH0001', N'KV0001', N'Nguyễn Văn A', N'22 Phạm Văn Đồng', N'0123456789', N'120456789', N'aa@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhoHang] ([MaKho], [NguoiQuanLy], [NguoiLienHe], [Ten], [KyHieu], [DiaChi], [DienThoai], [Fax], [Email], [DienGia], [ConQuanLy]) VALUES (N'KH0001', NULL, NULL, N'Kho 1', N'KH0001', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [ConQuanLy]) VALUES (N'KV0001', N'Miền Bắc', N'', 1)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [ConQuanLy]) VALUES (N'KV0003', N'Miền Nam', NULL, 1)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [ConQuanLy]) VALUES (N'KV0004', N'Miền Trung', N'', 1)
INSERT [dbo].[KhuVuc] ([MaKhuVuc], [TenKhuVuc], [GhiChu], [ConQuanLy]) VALUES (N'KV0006', N'jjkjk', N'fgfg', 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [MaKhuVuc], [TenNCC], [DiaChi], [MaSoThue], [DienThoai], [Email], [TaiKhoan], [GioiHanNo], [ChietKhau], [Fax], [Mobile], [Website], [NganHang], [NoHienTai], [ChucVu], [NguoiLienHe], [ConQuanLy]) VALUES (N'NCC0001', N'KV0001', N'Nhà Cung Cấp 1', N'abc', 1, N'123123', N'phat@gmail.com', N'1', 10000, 1000, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NhaCungCap] ([MaNCC], [MaKhuVuc], [TenNCC], [DiaChi], [MaSoThue], [DienThoai], [Email], [TaiKhoan], [GioiHanNo], [ChietKhau], [Fax], [Mobile], [Website], [NganHang], [NoHienTai], [ChucVu], [NguoiLienHe], [ConQuanLy]) VALUES (N'NCC0002', N'KV0001', N'Nhà cung cấp 2', N'yui', 1, N'123456', N'test@gmail.com', N'1', 12222, 1222, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NhanVien] ([MaNV], [MaBP], [MaNVQL], [Ten], [ChucVu], [DiaChi], [Email], [DienThoai], [DiDong], [ConQuanLy]) VALUES (N'NV0001', N'BP0002', NULL, N'Huỳnh Vinh Phát', N'Giám Đốc', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[NhomHang] ([MaNHH], [Ten], [GhiChu], [ConQuanLy]) VALUES (N'NHH0001', N'Điện thoại', N'Smartphone', 1)
INSERT [dbo].[NhomHang] ([MaNHH], [Ten], [GhiChu], [ConQuanLy]) VALUES (N'NHH0002', N'Laptop', N'Macbook', 1)
INSERT [dbo].[NhomHang] ([MaNHH], [Ten], [GhiChu], [ConQuanLy]) VALUES (N'NHH0003', N'Tablet', N'iPad', 0)
INSERT [dbo].[PhanLoaiHangHoa] ([MaPhanLoai], [TenPhanLoai], [ConQuanLy]) VALUES (N'PL0001', N'Hàng Hóa', NULL)
INSERT [dbo].[PhanLoaiHangHoa] ([MaPhanLoai], [TenPhanLoai], [ConQuanLy]) VALUES (N'PL0002', N'Dịch Vụ', NULL)
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0001', N'NCC0001', N'abc', N'01212', CAST(N'2017-06-07' AS Date), N'aa', N'aa', N'aa', N'NV0001', N'KH0001', N'DKTT0001', N'HTTT0002', CAST(N'2017-06-14' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0002', N'NCC0001', N'abc', N'124', CAST(N'2017-06-14' AS Date), N'aa', N'123', N'123', N'NV0001', N'KH0001', N'DKTT0001', N'HTTT0002', CAST(N'2017-06-13' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0003', N'NCC0001', N'44', N'45', CAST(N'2017-06-21' AS Date), N'asa', N'aa', N'aa', N'NV0001', N'KH0001', N'DKTT0001', N'HTTT0001', CAST(N'0001-01-01' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0004', N'NCC0001', N'ds', N'dsds', CAST(N'2017-06-07' AS Date), N'ds', N'dsd', N'dsd', N'NV0001', N'KH0001', N'DKTT0001', N'HTTT0002', CAST(N'2017-06-13' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0005', N'NCC0001', N'56', N'aa', CAST(N'2017-06-21' AS Date), N'a', N'a', N'xx', N'NV0001', N'KH0001', N'DKTT0001', N'HTTT0002', CAST(N'2017-06-13' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0006', N'NCC0001', N'đ', N'a', CAST(N'2017-06-21' AS Date), N'd', N'c', N'v', N'NV0001', N'KH0001', N'DKTT0002', N'HTTT0001', CAST(N'2017-06-14' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0007', N'NCC0001', N'a', N'a', CAST(N'2017-06-14' AS Date), N'a', N'a', N'a', N'NV0001', N'KH0001', N'DKTT0001', N'HTTT0002', CAST(N'2017-06-13' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0008', N'NCC0002', N'sa', N's', CAST(N'2017-06-21' AS Date), N'sá', N's', N's', N'NV0001', N'KH0001', N'DKTT0002', N'HTTT0001', CAST(N'2017-06-07' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0009', N'NCC0001', N'1', N'1', CAST(N'2017-06-21' AS Date), N'1', N'1', N'1', N'NV0001', N'KH0001', N'DKTT0002', N'HTTT0001', CAST(N'2017-06-22' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0010', N'NCC0002', N'd', N'd', CAST(N'2017-06-22' AS Date), N'd', N'd', N'd', N'NV0001', N'KH0001', N'DKTT0001', N'HTTT0002', CAST(N'2017-06-22' AS Date))
INSERT [dbo].[PhieuNhapHang] ([MaPhieu], [MaNCC], [DiaChi], [DienThoai], [Ngay], [GhiChu], [SoHoaDonVAT], [SoHoaDonVietTay], [MaNV], [MaKho], [MaDKTT], [MaHTTT], [HanTT]) VALUES (N'PNH0011', N'NCC0002', N's', N's', CAST(N'2017-06-14' AS Date), N's', N's', N's', N'NV0001', N'KH0001', N'DKTT0002', N'HTTT0002', CAST(N'2017-06-29' AS Date))
SET IDENTITY_INSERT [dbo].[UserID] ON 

INSERT [dbo].[UserID] ([id], [username], [password], [ConQuanLy]) VALUES (1, N'hien', N'123', NULL)
INSERT [dbo].[UserID] ([id], [username], [password], [ConQuanLy]) VALUES (2, N'phat', N'123', NULL)
INSERT [dbo].[UserID] ([id], [username], [password], [ConQuanLy]) VALUES (3, N'thang', N'123', NULL)
SET IDENTITY_INSERT [dbo].[UserID] OFF
SET IDENTITY_INSERT [dbo].[VaiTro] ON 

INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (1, N'Quản Trị', NULL)
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (2, N'Quản Lý Kho', NULL)
INSERT [dbo].[VaiTro] ([id], [Ten], [MoTa]) VALUES (3, N'Nhân Viên', NULL)
SET IDENTITY_INSERT [dbo].[VaiTro] OFF
ALTER TABLE [dbo].[ChiTietPhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapHang_HangHoa] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HangHoa] ([MaHang])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapHang] CHECK CONSTRAINT [FK_ChiTietPhieuNhapHang_HangHoa]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapHang_PhieuNhapHang] FOREIGN KEY([MaPhieu])
REFERENCES [dbo].[PhieuNhapHang] ([MaPhieu])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapHang] CHECK CONSTRAINT [FK_ChiTietPhieuNhapHang_PhieuNhapHang]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_DonViTinh1] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_DonViTinh1]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_KhoHang1] FOREIGN KEY([MaKho])
REFERENCES [dbo].[KhoHang] ([MaKho])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_KhoHang1]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhaCungCap1] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhaCungCap1]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_NhomHang1] FOREIGN KEY([MaLoaiHangHoa])
REFERENCES [dbo].[NhomHang] ([MaNHH])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_NhomHang1]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD  CONSTRAINT [FK_HangHoa_PhanLoaiHangHoa] FOREIGN KEY([MaPhanLoai])
REFERENCES [dbo].[PhanLoaiHangHoa] ([MaPhanLoai])
GO
ALTER TABLE [dbo].[HangHoa] CHECK CONSTRAINT [FK_HangHoa_PhanLoaiHangHoa]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_KhuVuc1] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_KhuVuc1]
GO
ALTER TABLE [dbo].[KhoHang]  WITH CHECK ADD  CONSTRAINT [FK_KhoHang_NhanVien1] FOREIGN KEY([NguoiQuanLy])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[KhoHang] CHECK CONSTRAINT [FK_KhoHang_NhanVien1]
GO
ALTER TABLE [dbo].[MaVach]  WITH CHECK ADD  CONSTRAINT [FK_MaVach_DonViTinh] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DonViTinh] ([MaDV])
GO
ALTER TABLE [dbo].[MaVach] CHECK CONSTRAINT [FK_MaVach_DonViTinh]
GO
ALTER TABLE [dbo].[NhaCungCap]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap_KhuVuc1] FOREIGN KEY([MaKhuVuc])
REFERENCES [dbo].[KhuVuc] ([MaKhuVuc])
GO
ALTER TABLE [dbo].[NhaCungCap] CHECK CONSTRAINT [FK_NhaCungCap_KhuVuc1]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_BoPhanNhanVien1] FOREIGN KEY([MaBP])
REFERENCES [dbo].[BoPhanNhanVien] ([MaBP])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_BoPhanNhanVien1]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_NhanVien] FOREIGN KEY([MaNVQL])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_DieuKhoanThanhToan] FOREIGN KEY([MaDKTT])
REFERENCES [dbo].[DieuKhoanThanhToan] ([MaDKTT])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_DieuKhoanThanhToan]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_HinhThucThanhToan] FOREIGN KEY([MaHTTT])
REFERENCES [dbo].[HinhThucThanhToan] ([MaHTTT])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_HinhThucThanhToan]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_KhoHang] FOREIGN KEY([MaKho])
REFERENCES [dbo].[KhoHang] ([MaKho])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_KhoHang]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_NhaCungCap]
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhapHang] CHECK CONSTRAINT [FK_PhieuNhapHang_NhanVien]
GO
