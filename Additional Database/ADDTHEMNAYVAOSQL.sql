Drop table NGUOIDUNG
Go
CREATE TABLE NGUOIDUNG(
	TenDangNhap VARCHAR(30) NOT NULL PRIMARY KEY,
	MatKhau	VARCHAR (30) DEFAULT 0,
	LoaiNguoiDung int default 0 -- 0 = phu huynh, hoc sinh, 1 = giao vu, 2 = giao vien,3 = ban giam hieu, admin
)
GO
INSERT INTO NGUOIDUNG VALUES('admin','admin', '3')
INSERT INTO NGUOIDUNG VALUES('bangiamhieu','bangiamhieu', '3')
INSERT INTO NGUOIDUNG VALUES('giaovien','giaovien', '2')
INSERT INTO NGUOIDUNG VALUES('hocsinh','hocsinh','0')
INSERT INTO NGUOIDUNG VALUES('phuhuynh','phuhuynh','0')
INSERT INTO NGUOIDUNG VALUES('giaovu','giaovu','1')