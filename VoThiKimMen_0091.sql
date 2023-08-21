-- Tạo cơ sở dữ liệu
CREATE DATABASE TaiKhoan;

-- Sử dụng cơ sở dữ liệu
USE TaiKhoan;

-- Tạo bảng dangnhap
CREATE TABLE dangnhap (
    id INT PRIMARY KEY,
    Username nVARCHAR(50) NOT NULL,
    Password nVARCHAR(100) NOT NULL
   
);

-- Tạo bảng sanpham
CREATE TABLE sanpham (
    id INT PRIMARY KEY not null,
    name NVARCHAR(100) NOT NULL,
    price int NOT NULL,
	quantity_in_stock int,
	Image nvarchar(255),
    KichCo nvarchar(255)
);

-- Tạo bảng NhaCungCap
CREATE TABLE NhaCungCap (
    id INT PRIMARY KEY not null,
    Ten nVARCHAR(100) NOT NULL,
    DiaChi nVARCHAR(200),
    sdt nVARCHAR(20),
	KhuVuc nvarchar(255),
	email nvarchar(255)
);

-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    MaKhachHang INT PRIMARY KEY not null,
	TenKhachHang nvarchar(255),
	SoDienThoai nvarchar(255),
	KhuVuc  nvarchar(255),
	MaSanPham int,
	TenSanPham  nvarchar(255),
	NgaylapHD Datetime,
	Soluong  int,
	Gia  nvarchar(255),
	TongTien decimal
);



