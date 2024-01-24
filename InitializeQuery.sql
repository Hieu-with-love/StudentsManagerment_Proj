SELECT * FROM SinhVien
DROP TABLE SinhVien;
GO

CREATE TABLE SinhVien(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	email varchar(150) ,
	gioitinh int,
	diachi nvarchar(150),
	sdt varchar(12),
	cccd varchar(20),
	ngaysinh date
)
GO

INSERT INTO SinhVien (hoten,email,gioitinh,diachi,sdt,cccd,ngaysinh)
VALUES (N'Nguyễn Văn A','adeptrai@gmail.com',0,N'Bình Dương','0978332486','05244335432313','20041209');

DROP TABLE GiaoVien;
GO

CREATE TABLE GiaoVien(
	id int PRIMARY KEY IDENTITY,
	hoten nvarchar(150),
	email varchar(150) ,
	gioitinh int,
	diachi nvarchar(150),
	sdt varchar(12),
	cccd varchar(20),
	ngaysinh date
)

SELECT * FROM GiaoVien;

INSERT INTO GiaoVien (hoten,email,gioitinh,diachi,sdt,cccd,ngaysinh)
VALUES (N'Trần Thị B','bdepgai@gmail.com',1,N'Đồng Nai','0345786231','05244335432124','19900529');
