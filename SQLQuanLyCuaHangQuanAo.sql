CREATE DATABASE QUANLYCUAHANGQUANAO
GO

USE QUANLYCUAHANGQUANAO
GO

CREATE TABLE tblChatLieu
(
	MaChatLieu NVARCHAR(50) NOT NULL,
	TenChatLieu NVARCHAR(50) NOT NULL,
	PRIMARY KEY CLUSTERED (MaChatLieu)
)
CREATE TABLE tblKhach
(
	MaKhach NVARCHAR(50) NOT NULL,
	TenKhach NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	DienThoai NVARCHAR(50) NOT NULL,
	PRIMARY KEY CLUSTERED(MaKhach)
)
CREATE TABLE tblHang
(
	MaHang NVARCHAR(50) NOT NULL,
	TenHang NVARCHAR(50) NOT NULL,
	MaChatLieu NVARCHAR(50) NOT NULL,
	SoLuong FLOAT(50) NOT NULL,
	DonGiaNhap FLOAT(50) NOT NULL,
	DonGiaBan FLOAT(50) NOT NULL,
	Anh NVARCHAR(200) NOT NULL,
	GhiChu NVARCHAR(200) NOT NULL,
	PRIMARY KEY CLUSTERED (MaHang)
)
CREATE TABLE tblNhanVien
(
	MaNhanVien NVARCHAR(50) NOT NULL,
	TenNhanVien  NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	DienThoai NVARCHAR(50) NOT NULL,
	NgaySinh DATETIME  NOT NULL,
	PRIMARY KEY CLUSTERED(MaNhanVien) 

)
CREATE TABLE tblHDBan
(
	MaHDBan NVARCHAR(50) NOT NULL,
	MaNhanVien NVARCHAR(50) NOT NULL,
	NgayBan DATETIME NOT NULL,
	MaKhach NVARCHAR(50) NOT NULL,
	TongTien FLOAT(50) NOT NULL,
	PRIMARY KEY CLUSTERED (MaHDBan)
)
CREATE TABLE tblChiTietHDBan
(
	MaHDBan NVARCHAR(50) NOT NULL,
	MaHang NVARCHAR(50) NOT NULL ,
	SoLuong FLOAT(50) NOT NULL,
	DonGia FLOAT(50) NOT NULL,
	GiamGia FLOAT(50) NOT NULL,
	ThanhTien FLOAT(50) NOT NULL,
	PRIMARY KEY CLUSTERED (MaHDBan,MaHang)

) 