CREATE DATABASE Quan_Ly_QuanAoo
GO

USE Quan_Ly_QuanAoo
GO

CREATE TABLE tblNhanVien
(
	iDNhanVien NVARCHAR(50) PRIMARY KEY,
	TenNV NVARCHAR(50) NOT NULL,
	GioiTinh NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(200) NOT NULL,
	DienThoai NVARCHAR(15) NOT NULL,
	NgaySinh DATETIME NOT NULL
)

GO


CREATE TABLE tblKhachHang
(
	iDKhachHang NVARCHAR(50) PRIMARY KEY,
	TenKhach NVARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(200) NOT NULL,
	DienThoai NVARCHAR(15) NOT NULL,
	NgaySinh DATETIME NOT NULL
)

GO


CREATE TABLE tblCT_Hang
(
	idCTHang NVARCHAR(50) PRIMARY KEY,
	Ten NVARCHAR(50) NOT NULL,
	Size NVARCHAR(10) NOT NULL,
	KieuDang NVARCHAR(50) NOT NULL,
	ChatLieu NVARCHAR(50) NOT NULL
)

GO


CREATE TABLE tblHang
(
	idHang NVARCHAR(50) PRIMARY KEY,
	SoLuong INT NOT NULL,
	DonGiaNhap FLOAT NOT NULL,
	DonGiaBan FLOAT NOT NULL,
	Anh NVARCHAR(200),
	GhiChu NVARCHAR(200),
	idCTHang NVARCHAR(50) NOT NULL ,

	 FOREIGN KEY (idCTHang) REFERENCES dbo.tblCT_Hang
)

GO

CREATE TABLE tblHoaDon
(
	idHoaDon NVARCHAR(50) PRIMARY KEY ,
	NgayBan DATETIME,
	TongTien FLOAT,
	iDNhanVien NVARCHAR(50) NOT NULL,
	iDKhachHang NVARCHAR(50) NOT NULL,
	 FOREIGN KEY (iDNhanVien) REFERENCES dbo.tblNhanVien,
	 FOREIGN KEY (iDKhachHang) REFERENCES dbo.tblKhachHang,

)

GO

CREATE TABLE tblCT_HoaDon
(
	idCTHoaDon NVARCHAR(50) PRIMARY KEY ,
	SoLuong INT,
	DonGia INT,
	GiamGia INT,
	ThanhTien FLOAT,
	idHang NVARCHAR(50) NOT NULL,
	idHoaDon NVARCHAR(50) NOT NULL,
	 FOREIGN KEY (idHang) REFERENCES dbo.tblHang,
	 FOREIGN KEY (idHoaDon) REFERENCES dbo.tblHoaDon

)

GO

CREATE TABLE tblDoanhThu
(
	--idDoanhThu INT PRIMARY KEY,
	idThang  INT NOT NULL,
	idNam	INT NOT NULL,
	TongDoanhThu FLOAT ,

	CONSTRAINT PK_tblDoanhThu PRIMARY KEY (idThang  ,idNam)
	
)

GO

CREATE TABLE tblCT_DoanhThu
(
	idNgay INT NOT NULL,
	DoanhThu FLOAT,
	TongSoKhach INT,
	TiLe INT,

	idThang			 INT NOT NULL,
	idNam			INT NOT NULL,
	idCTHoaDon		NVARCHAR(50)   NOT NULL,

	CONSTRAINT PK_tblCT_DoanhThu PRIMARY KEY (idNgay,idThang,idNam),
	FOREIGN KEY (idCTHoaDon) REFERENCES dbo.tblCT_HoaDon,
	FOREIGN KEY (idThang,idNam) REFERENCES dbo.tblDoanhThu

)
GO

CREATE TABLE tblUsers
  (
	idUser INT PRIMARY KEY IDENTITY,
	Users NVARCHAR(50) NOT NULL,
	Pass NVARCHAR(50) NOT NULL
  )
  
 GO
 
CREATE TABLE tblMaster
  (
	idMaster INT PRIMARY KEY IDENTITY,
	Users NVARCHAR(50) NOT NULL,
	Pass NVARCHAR(50) NOT NULL
  )

