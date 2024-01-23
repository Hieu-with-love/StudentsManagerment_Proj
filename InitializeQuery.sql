SELECT * FROM SinhVien
DROP TABLE SinhVien;
GO

CREATE TABLE SinhVien(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	email varchar(150) ,
	gioitinh bit,
	diachi nvarchar(150),
	sdt varchar(12),
	cccd varchar(20),
	ngaysinh date
)