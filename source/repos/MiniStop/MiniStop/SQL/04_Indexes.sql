USE MiniStop;
GO
-- --------------------
-- **Index cho các cột khóa ngoại (Foreign Key)**
-- --------------------
-- Index cho cột MaLoaiSP trong bảng SanPham
-- Tăng tốc khi JOIN bảng SanPham với bảng LoaiSP
CREATE NONCLUSTERED INDEX idx_SanPham_MaLoaiSP 
ON SanPham (MaLoaiSP);

-- Index cho cột MaKH trong bảng DonHang
-- Tăng tốc khi JOIN bảng DonHang với bảng KhachHang
CREATE NONCLUSTERED INDEX idx_DonHang_MaKH 
ON DonHang (MaKH);

-- Index cho cột MaNV trong bảng DonHang
-- Tăng tốc khi JOIN bảng DonHang với bảng NhanVien
CREATE NONCLUSTERED INDEX idx_DonHang_MaNV 
ON DonHang (MaNV);

-- Index cho cột MaSP trong bảng ChiTietHoaDon
-- Tăng tốc khi JOIN bảng ChiTietHoaDon với bảng SanPham
CREATE NONCLUSTERED INDEX idx_ChiTietHoaDon_MaSP 
ON ChiTietHoaDon (MaSP);

-- --------------------
-- **Index cho các cột tìm kiếm thường xuyên**
-- --------------------

-- Index cho cột TenSP trong bảng SanPham
-- Tăng tốc tìm kiếm sản phẩm theo tên
CREATE NONCLUSTERED INDEX idx_SanPham_TenSP 
ON SanPham (TenSP);

-- Index cho cột SDT trong bảng KhachHang
-- Tăng tốc tìm kiếm khách hàng theo số điện thoại
CREATE NONCLUSTERED INDEX idx_KhachHang_SDT 
ON KhachHang (SDT);

-- Index cho cột NgayLap trong bảng HoaDon
-- Tăng tốc lọc hóa đơn theo ngày lập
CREATE NONCLUSTERED INDEX idx_HoaDon_NgayLap 
ON HoaDon (NgayLap);

-- --------------------
-- **Index kết hợp (Composite Index)**
-- --------------------
-- Index kết hợp cho cột MaNCC và NgayNhap trong bảng NhapHang
-- Tăng tốc truy vấn lọc nhập hàng theo nhà cung cấp và ngày nhập
CREATE NONCLUSTERED INDEX idx_NhapHang_MaNCC_NgayNhap 
ON NhapHang (MaNCC, NgayNhap);

-- Index kết hợp cho cột MaKH và NgayLap trong bảng DonHang
-- Tăng tốc lọc đơn hàng theo khách hàng và ngày lập
CREATE NONCLUSTERED INDEX idx_DonHang_MaKH_NgayLap 
ON DonHang (MaKH, NgayLap);
GO


