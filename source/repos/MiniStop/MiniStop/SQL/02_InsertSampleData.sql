USE MiniStop;
GO

-- Thêm dữ liệu vào bảng ChucVu
INSERT INTO ChucVu (MaChucVu, TenChucVu, MoTa)
VALUES 
(1, N'Admin', N'Quản trị hệ thống'),
(2, N'Nhân viên bán hàng', N'Quản lý khách hàng và bán hàng');

-- Thêm dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNV, TenNV, GioiTinh, NgaySinh, SDT, DiaChi, NgayVaoLam, ChucVu, TaiKhoan, MatKhau, QuyenHan)
VALUES 
(1, N'Nguyễn Văn A', N'Nam', '1990-01-01', '0123456789', N'Hà Nội', '2023-01-01', 1, 'admin', 'admin123', 'Admin'),
(2, N'Trần Thị B', N'Nữ', '1995-05-01', '0987654321', N'TP.HCM', '2023-01-01', 2, 'nv01', '123456', 'NhanVien'),
(3, N'Lê Văn C', N'Nam', '1993-03-01', '0345678901', N'Đà Nẵng', '2023-02-01', 2, 'nv02', '654321', 'NhanVien');

-- Thêm dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, SDT, Email, NgayDK)
VALUES 
(1, N'Phạm Văn D', '0981112222', 'phamd@gmail.com', '2023-01-01'),
(2, N'Nguyễn Thị E', '0933334444', 'nguyenthie@gmail.com', '2023-01-02');

-- Thêm dữ liệu vào bảng LoaiSP
INSERT INTO LoaiSP (MaLoaiSP, TenLoaiSP, MoTa)
VALUES 
(1, N'Đồ uống', N'Các loại đồ uống đóng chai'),
(2, N'Đồ ăn vặt', N'Snack và các loại đồ ăn vặt'),
(3, N'Hàng tiêu dùng', N'Sản phẩm hàng ngày như xà phòng, giấy vệ sinh');

-- Thêm dữ liệu vào bảng SanPham
INSERT INTO SanPham (MaSP, TenSP, Gia, SoLuongTon, MaLoaiSP)
VALUES 
(1, N'Coca Cola 500ml', 10000, 100, 1),
(2, N'Snack', 15000, 50, 2),
(3, N'Bàn chải đánh răng', 20000, 30, 3);

-- Thêm dữ liệu vào bảng Kho (quản lý tồn kho theo sản phẩm)
INSERT INTO Kho (MaSP, SoLuongTon)
VALUES 
(1, 100), -- Coca Cola tồn kho: 100
(2, 50),  -- Snack Lay's tồn kho: 50
(3, 30);  -- Bàn chải đánh răng tồn kho: 30


-- Thêm dữ liệu vào bảng DonHang
INSERT INTO DonHang (MaDonHang, MaKH, MaNV, NgayLap, TongTien)
VALUES 
(1, 1, 2, '2023-03-01', 0),
(2, 2, 3, '2023-03-02', 0);

-- Thêm dữ liệu vào bảng ThanhToan
INSERT INTO ThanhToan (MaDonHang, SoTienThanhToan)
VALUES 
(1, 20000), -- Thanh toán 20,000 cho đơn hàng 1
(2, 40000); -- Thanh toán 40,000 cho đơn hàng 2

-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon (MaHD, NgayLap, TongTien, MaKH, MaNV)
VALUES 
(1, '2023-03-01', 20000, 1, 2),
(2, '2023-03-02', 40000, 2, 3);

-- Thêm dữ liệu vào bảng ChiTietHoaDon
INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
VALUES 
(1, 1, 2, 10000), -- 2 chai Coca Cola giá 10,000
(1, 2, 1, 15000), -- 1 gói Snack Lay's giá 15,000
(2, 3, 2, 20000); -- 2 bàn chải đánh răng giá 20,000

-- Thêm dữ liệu vào bảng KhuyenMai
INSERT INTO KhuyenMai (MaKM, TenKM, MoTa, NgayBatDau, NgayKetThuc, PhanTramGiam)
VALUES 
(1, N'Tết 2023', N'Khuyến mãi 10% cho tất cả sản phẩm', '2023-01-15', '2023-01-30', 10.00);

-- Thêm dữ liệu vào bảng TheThanhVien
INSERT INTO TheThanhVien (MaThe, MaKH, NgayCap, TichLuy)
VALUES 
(1, 1, '2023-01-10', 100),
(2, 2, '2023-02-01', 200);

-- Thêm dữ liệu vào bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, SDT, DiaChi)
VALUES 
(1, N'Công ty Coca-Cola', '0988888888', N'123 Đường A, Hà Nội'),
(2, N'Công ty Lay''s', '0977777777', N'456 Đường B, TP.HCM');

-- Thêm dữ liệu vào bảng NhapHang
INSERT INTO NhapHang (MaNH, MaNCC, NgayNhap, TongTien)
VALUES 
(1, 1, '2023-03-01', 100000),
(2, 2, '2023-03-02', 75000);

-- Thêm dữ liệu vào bảng ChiTietNhapHang
INSERT INTO ChiTietNhapHang (MaNH, MaSP, SoLuong, DonGia)
VALUES 
(1, 1, 50, 2000), -- Nhập thêm 50 chai Coca Cola giá 2,000
(2, 2, 30, 2500); -- Nhập thêm 30 gói Snack Lay's giá 2,500
