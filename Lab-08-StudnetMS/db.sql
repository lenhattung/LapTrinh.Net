USE master;
GO
IF EXISTS (SELECT name FROM sys.databases WHERE name = N'StudentDB')
BEGIN
    ALTER DATABASE StudentDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE StudentDB;
END
GO

CREATE DATABASE StudentDB;
GO
USE StudentDB;
GO

CREATE TABLE KHOA (
    Makhoa nchar(6) PRIMARY KEY,
    Tenkhoa nchar(30)
);
GO

CREATE TABLE Mon (
    MaMH nchar(6) PRIMARY KEY,
    TenMH nchar(50),
    SoTiet int
);
GO

CREATE TABLE SinhVien (
    MaSo int PRIMARY KEY,
    HoTen nvarchar(50),
    NgaySinh datetime,
    GioiTinh bit,
    DiaChi nvarchar(50),
    DienThoai int,
    Makhoa nchar(6) REFERENCES KHOA(Makhoa)
);
GO

CREATE TABLE KetQua (
    MaSo int REFERENCES SinhVien(MaSo),
    MaMH nchar(6) REFERENCES Mon(MaMH),
    Diem int,
    PRIMARY KEY (MaSo, MaMH)
);
GO

INSERT INTO KHOA (Makhoa, Tenkhoa) VALUES 
('CNTT', N'Công Nghệ Thông Tin'),
('CNTP', N'Công Nghệ Thực Phẩm'),
('DDT', N'Điện - Điện Tử'),
('MT', N'Môi Trường'),
('NN', N'Ngoại Ngữ'),
('QTKD', N'Quản Trị Kinh Doanh');

INSERT INTO Mon (MaMH, TenMH, SoTiet) VALUES 
('001', N'Lập Trình Windows', 45),
('002', N'Cơ Sở Dữ Liệu', 45),
('003', N'Cấu Trúc Dữ Liệu', 60),
('004', N'Kỹ Thuật Lập Trình', 45),
('005', N'Ngữ Pháp', 30),
('006', N'Đọc Hiểu', 30),
('007', N'Nghe Nói', 45);

INSERT INTO SinhVien (MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, Makhoa) VALUES 
(100, N'Nguyễn Hà Giang', '1978-12-04', 1, N'Hoàng Hoa Thám', 908496767, 'CNTT'),
(101, N'Nguyễn Hà Mỹ Tiên', '1988-01-01', 0, N'Lê Quang Định', 901234567, 'CNTP'),
(102, N'Trần Ngọc Thảo', '1989-12-24', 0, N'Lý Thường Kiệt', 903334455, 'CNTT'),
(106, N'Lê Bạch Yến', '1976-02-21', 0, N'757 Pasteur', 9234455, 'CNTT');

INSERT INTO KetQua (MaSo, MaMH, Diem) VALUES 
(100, '001', 5),
(100, '002', 6),
(100, '003', 7),
(100, '004', 8),
(106, '001', 8);
GO

SELECT * FROM SinhVien;