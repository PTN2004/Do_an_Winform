USE MiniStop; 
GO

-- Tạo bảng ChucVu
CREATE TABLE ChucVu (
    MaChucVu INT PRIMARY KEY,
    TenChucVu NVARCHAR(50),
    MoTa NVARCHAR(255)
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(50),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SDT NVARCHAR(15),
    DiaChi NVARCHAR(255),
    NgayVaoLam DATE,
    ChucVu INT FOREIGN KEY REFERENCES ChucVu(MaChucVu),
    TaiKhoan NVARCHAR(50) UNIQUE, -- Tài khoản đăng nhập
    MatKhau NVARCHAR(50),         -- Mật khẩu đăng nhập
    QuyenHan NVARCHAR(50)         -- Quyền hạn: 'Admin' hoặc 'NhanVien'
);

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
    TenKH NVARCHAR(50),
    SDT NVARCHAR(15),
    Email NVARCHAR(100),
    NgayDK DATE
);

-- Tạo bảng LoaiSP
CREATE TABLE LoaiSP (
    MaLoaiSP INT PRIMARY KEY,
    TenLoaiSP NVARCHAR(50),
    MoTa NVARCHAR(255)
);

-- Tạo bảng SanPham
CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY,
    TenSP NVARCHAR(100),
    Gia DECIMAL(18, 2),
    SoLuongTon INT,
    MaLoaiSP INT FOREIGN KEY REFERENCES LoaiSP(MaLoaiSP)
);

-- Tạo bảng Kho (Quản lý tồn kho theo sản phẩm)
CREATE TABLE Kho (
    MaSP INT PRIMARY KEY, -- Quản lý theo Mã sản phẩm
    SoLuongTon INT -- Số lượng tồn kho
	FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

ALTER TABLE Kho
ADD CONSTRAINT FK_Kho_SanPham
FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP);

-- Tạo bảng DonHang
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY,
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV),
    NgayLap DATE,
    TongTien DECIMAL(18, 2)
);

-- Tạo bảng ThanhToan
CREATE TABLE ThanhToan (
    MaThanhToan INT PRIMARY KEY IDENTITY(1,1),
    MaDonHang INT,
    SoTienThanhToan DECIMAL(18,2),
    NgayThanhToan DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang)
);

-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    MaHD INT PRIMARY KEY,
    NgayLap DATE,
    TongTien DECIMAL(18, 2),
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    MaNV INT FOREIGN KEY REFERENCES NhanVien(MaNV)
);

-- Tạo bảng ChiTietHoaDon
CREATE TABLE ChiTietHoaDon (
    MaHD INT FOREIGN KEY REFERENCES HoaDon(MaHD),
    MaSP INT FOREIGN KEY REFERENCES SanPham(MaSP),
    SoLuong INT,
    DonGia DECIMAL(18, 2),
    PRIMARY KEY (MaHD, MaSP)
);

-- Tạo bảng KhuyenMai
CREATE TABLE KhuyenMai (
    MaKM INT PRIMARY KEY,
    TenKM NVARCHAR(100),
    MoTa NVARCHAR(255),
    NgayBatDau DATE,
    NgayKetThuc DATE,
    PhanTramGiam DECIMAL(5, 2)
);

-- Tạo bảng TheThanhVien
CREATE TABLE TheThanhVien (
    MaThe INT PRIMARY KEY,
    MaKH INT FOREIGN KEY REFERENCES KhachHang(MaKH),
    NgayCap DATE,
    TichLuy INT
);

-- Tạo bảng NhaCungCap
CREATE TABLE NhaCungCap (
    MaNCC INT PRIMARY KEY,
    TenNCC NVARCHAR(100),
    SDT NVARCHAR(15),
    DiaChi NVARCHAR(255)
);

-- Tạo bảng NhapHang
CREATE TABLE NhapHang (
    MaNH INT PRIMARY KEY,
    MaNCC INT FOREIGN KEY REFERENCES NhaCungCap(MaNCC),
    NgayNhap DATE,
    TongTien DECIMAL(18, 2)
);

-- Tạo bảng ChiTietNhapHang
CREATE TABLE ChiTietNhapHang (
    MaNH INT FOREIGN KEY REFERENCES NhapHang(MaNH),
    MaSP INT FOREIGN KEY REFERENCES SanPham(MaSP),
    SoLuong INT,
    DonGia DECIMAL(18, 2),
    PRIMARY KEY (MaNH, MaSP)
);
GO
