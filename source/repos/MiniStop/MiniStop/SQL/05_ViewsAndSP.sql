-- Danh sách hóa đơn chi tiết
CREATE VIEW vw_ChiTietHoaDon AS
SELECT 
    h.MaHD AS MaHoaDon,
    k.TenKH AS TenKhachHang,
    k.SDT AS SoDienThoaiKH,
    nv.TenNV AS NhanVienLap,
    sp.TenSP AS TenSanPham,
    cthd.SoLuong,
    cthd.DonGia,
    (cthd.SoLuong * cthd.DonGia) AS ThanhTien
FROM HoaDon h
INNER JOIN ChiTietHoaDon cthd ON h.MaHD = cthd.MaHD
INNER JOIN KhachHang k ON h.MaKH = k.MaKH
INNER JOIN NhanVien nv ON h.MaNV = nv.MaNV
INNER JOIN SanPham sp ON cthd.MaSP = sp.MaSP;

SELECT *
FROM vw_ChiTietHoaDon
ORDER BY MaHoaDon, TenSanPham; 

go

-- Thống kê tồn kho
CREATE VIEW vw_TonKho AS
SELECT 
    sp.MaSP AS MaSanPham,
    sp.TenSP AS TenSanPham,
    sp.Gia AS GiaSanPham,
    kho.SoLuongTon AS SoLuongTon
FROM Kho kho
INNER JOIN SanPham sp ON kho.MaSP = sp.MaSP;

SELECT *
FROM vw_TonKho
ORDER BY SoLuongTon DESC; -- Sắp xếp sản phẩm có số lượng tồn lớn nhất trước

go

-- Doanh thu theo hóa đơn
CREATE VIEW vw_DoanhThuHoaDon AS
SELECT 
    h.MaHD AS MaHoaDon,
    h.NgayLap AS NgayLapHoaDon,
    k.TenKH AS TenKhachHang,
    nv.TenNV AS TenNhanVien,
    h.TongTien AS TongTienHoaDon
FROM HoaDon h
INNER JOIN KhachHang k ON h.MaKH = k.MaKH
INNER JOIN NhanVien nv ON h.MaNV = nv.MaNV;

SELECT *
FROM vw_DoanhThuHoaDon
ORDER BY TongTienHoaDon DESC; -- Sắp xếp hóa đơn có tổng tiền lớn nhất trước

go
-- Doanh thu theo ngày
CREATE VIEW vw_DoanhThuTheoNgay AS
SELECT 
    CAST(h.NgayLap AS DATE) AS Ngay,
    SUM(h.TongTien) AS TongDoanhThu
FROM HoaDon h
GROUP BY CAST(h.NgayLap AS DATE);

SELECT *
FROM vw_DoanhThuTheoNgay
ORDER BY Ngay ASC; -- Sắp xếp theo ngày, từ sớm đến muộn

go
-- Lịch sử nhập hàng
CREATE VIEW vw_LichSuNhapHang AS
SELECT 
    nh.MaNH AS MaNhapHang,
    ncc.TenNCC AS TenNhaCungCap,
    ncc.SDT AS SoDienThoaiNCC,
    nh.NgayNhap AS NgayNhapHang,
    nh.TongTien AS TongTienNhapHang
FROM NhapHang nh
INNER JOIN NhaCungCap ncc ON nh.MaNCC = ncc.MaNCC;

SELECT *
FROM vw_LichSuNhapHang
ORDER BY NgayNhapHang DESC; -- Sắp xếp theo ngày nhập hàng, mới nhất trước

go
-- Sản phẩm bán chạy nhất
CREATE VIEW vw_SanPhamBanChay AS
SELECT 
    sp.MaSP AS MaSanPham,
    sp.TenSP AS TenSanPham,
    SUM(cthd.SoLuong) AS TongSoLuongBan,
    SUM(cthd.SoLuong * cthd.DonGia) AS TongDoanhThu
FROM ChiTietHoaDon cthd
INNER JOIN SanPham sp ON cthd.MaSP = sp.MaSP
GROUP BY sp.MaSP, sp.TenSP;

SELECT *
FROM vw_SanPhamBanChay
ORDER BY TongSoLuongBan DESC; -- Sắp xếp sản phẩm bán chạy nhất trước


