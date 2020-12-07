CREATE DATABASE QLQA
GO

USE QLQA
GO


CREATE TABLE tblThongTinShop
(

id NVARCHAR(50) PRIMARY KEY,
TenShop NVARCHAR(50),
DiaChi NVARCHAR(50),
SDT	NVARCHAR(50),
LoiChao NVARCHAR(50),
Logo IMAGE
)

GO
CREATE TABLE tblSize
(
idSize NVARCHAR(50) PRIMARY KEY,
TenSize NVARCHAR(50)
)
GO
 CREATE TABLE tblChatLieu
 (
idChatLieu NVARCHAR(50) PRIMARY KEY,
TenChatLieu NVARCHAR(50)
 )

 GO
 

CREATE TABLE tblNhanVien
(
	idNhanVien NVARCHAR(50) PRIMARY KEY,
	TenNV NVARCHAR(50)  ,
	GioiTinh NVARCHAR(50)  ,
	DiaChi NVARCHAR(200)  ,
	DienThoai NVARCHAR(15)  ,
	NgaySinh DATETIME  ,
	Users NVARCHAR(50) ,
	Pass NVARCHAR(50)
)

GO


CREATE TABLE tblKhachHang
(
	iDKhachHang NVARCHAR(50) PRIMARY KEY,
	TenKhach NVARCHAR(50)  ,
	DiaChi NVARCHAR(200)  ,
	DienThoai NVARCHAR(15)  ,
	NgaySinh DATETIME  
)

GO






CREATE TABLE tblCT_Hang
(
	idCTHang NVARCHAR(50) PRIMARY KEY,
	Ten NVARCHAR(50) ,
	idSize NVARCHAR(50),
	KieuDang NVARCHAR(50) ,
	idChatLieu NVARCHAR(50) ,
	GhiChu NVARCHAR(50),

	Anh IMAGE,
	SoLuong FLOAT,
	DonGiaNhap FLOAT, 
	DonGiaBan FLOAT
	
	FOREIGN KEY (idChatLieu) REFERENCES dbo.tblChatLieu(idChatLieu),
	FOREIGN KEY (idSize) REFERENCES dbo.tblSize(idSize)
	
)



GO

CREATE TABLE tblHoaDon
(
	idHoaDon NVARCHAR(50) PRIMARY KEY ,
	NgayBan DATETIME,
	TongTien FLOAT,
	iDNhanVien NVARCHAR(50) NOT NULL,
	iDKhachHang NVARCHAR(50) NOT NULL,
	 FOREIGN KEY (iDNhanVien) REFERENCES dbo.tblNhanVien(idNhanVien),
	 FOREIGN KEY (iDKhachHang) REFERENCES dbo.tblKhachHang(iDKhachHang)

)

GO

CREATE TABLE tblCT_HoaDon
(

	SoLuong FLOAT,
	DonGia FLOAT,
	GiamGia FLOAT,
	ThanhTien FLOAT,
	idCTHang NVARCHAR(50) NOT NULL,
	idHoaDon NVARCHAR(50) NOT NULL,
	PRIMARY KEY (idCTHang,idHoaDon),
	 FOREIGN KEY (idCTHang) REFERENCES dbo.tblCT_Hang(idCTHang),
		FOREIGN KEY (idHoaDon) REFERENCES  tblHoaDon(idHoaDon)

)





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


INSERT tblCT_Hang () VALUES ()




SELECT * FROM tblChatLieu