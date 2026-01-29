CREATE DATABASE StudentDB
GO
USE StudentDB
GO

-- =====================
-- Bảng Khoa
-- =====================
CREATE TABLE Khoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
)

-- =====================
-- Bảng SinhVien
-- =====================
CREATE TABLE SinhVien (
    MaSo INT PRIMARY KEY,
    HoTen NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh BIT,
    DiaChi NVARCHAR(200),
    DienThoai NVARCHAR(20),
    MaKhoa INT,
    CONSTRAINT FK_SinhVien_Khoa 
        FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
)

-- =====================
-- Bảng Mon
-- =====================
CREATE TABLE Mon (
    MaMH INT PRIMARY KEY,
    TenMH NVARCHAR(100),
    SoTiet INT
)

-- =====================
-- Bảng KetQua
-- =====================
CREATE TABLE KetQua (
    MaSo INT,
    MaMH INT,
    Diem FLOAT,
    CONSTRAINT PK_KetQua PRIMARY KEY (MaSo, MaMH),
    CONSTRAINT FK_KQ_SV FOREIGN KEY (MaSo) REFERENCES SinhVien(MaSo),
    CONSTRAINT FK_KQ_MH FOREIGN KEY (MaMH) REFERENCES Mon(MaMH)
)


INSERT INTO Khoa VALUES
(1, N'Công nghệ thông tin'),
(2, N'Kế toán'),
(3, N'Quản trị kinh doanh')

INSERT INTO SinhVien VALUES
(1, N'Nguyễn Văn A', '2002-05-10', 1, N'TP.HCM', '0901111111', 1),
(2, N'Trần Thị B', '2001-09-20', 0, N'Biên Hòa', '0902222222', 2)

INSERT INTO Mon VALUES
(1, N'Lập trình C#', 45),
(2, N'Cơ sở dữ liệu', 45)

INSERT INTO KetQua VALUES
(1,1,8.5),
(1,2,7.0),
(2,1,6.5)

