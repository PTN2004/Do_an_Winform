-- Trigger giảm tồn kho khi thêm hóa đơn
CREATE TRIGGER trg_GiamTonKho
ON ChiTietHoaDon
AFTER INSERT
AS
BEGIN
    -- Cập nhật số lượng tồn kho trong bảng Kho
    UPDATE Kho
    SET SoLuongTon = Kho.SoLuongTon - inserted.SoLuong
    FROM Kho
    INNER JOIN inserted ON Kho.MaSP = inserted.MaSP;

    -- Kiểm tra nếu tồn kho bị âm
    IF EXISTS (SELECT 1 FROM Kho WHERE SoLuongTon < 0)
    BEGIN
        -- Báo lỗi và rollback nếu tồn kho bị âm
        RAISERROR ('Số lượng tồn kho không đủ!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

UPDATE Kho
SET SoLuongTon = Kho.SoLuongTon - inserted.SoLuong
FROM Kho
INNER JOIN inserted ON Kho.MaSP = inserted.MaSP;

GO

-- Trigger tăng tồn kho khi nhập hàng
CREATE TRIGGER trg_TangTonKho
ON ChiTietNhapHang
AFTER INSERT
AS
BEGIN
    -- Cập nhật số lượng tồn kho trong bảng Kho
    UPDATE Kho
    SET SoLuongTon = Kho.SoLuongTon + inserted.SoLuong
    FROM Kho
    INNER JOIN inserted ON Kho.MaSP = inserted.MaSP; -- Tham chiếu đúng giữa Kho và ChiTietNhapHang
END;

UPDATE Kho
SET SoLuongTon = Kho.SoLuongTon + inserted.SoLuong
FROM Kho
INNER JOIN inserted ON Kho.MaSP = inserted.MaSP;

GO



-- Trigger cập nhật tổng tiền hóa đơn
CREATE TRIGGER trg_CapNhatTongTienHoaDon
ON ChiTietHoaDon
AFTER INSERT, DELETE
AS
BEGIN
    UPDATE HoaDon
    SET TongTien = (
        SELECT SUM(SoLuong * DonGia)
        FROM ChiTietHoaDon
        WHERE ChiTietHoaDon.MaHD = HoaDon.MaHD
    )
    WHERE MaHD IN (SELECT DISTINCT MaHD FROM inserted UNION SELECT DISTINCT MaHD FROM deleted);
END;

UPDATE HoaDon
SET TongTien = (
    SELECT SUM(SoLuong * DonGia)
    FROM ChiTietHoaDon
    WHERE ChiTietHoaDon.MaHD = HoaDon.MaHD
)
WHERE MaHD IN (
    SELECT DISTINCT MaHD FROM inserted
    UNION
    SELECT DISTINCT MaHD FROM deleted
);

GO

CREATE TRIGGER trg_CapNhatTichLuy
ON HoaDon
AFTER UPDATE
AS
BEGIN
    -- Cập nhật điểm tích lũy
    IF UPDATE(TongTien)
    BEGIN
        UPDATE TheThanhVien
        SET TichLuy = TichLuy + CAST(inserted.TongTien AS INT) / 100000
        FROM TheThanhVien
        INNER JOIN HoaDon ON TheThanhVien.MaKH = HoaDon.MaKH
        INNER JOIN inserted ON HoaDon.MaHD = inserted.MaHD;
    END
END;

UPDATE TheThanhVien
SET TichLuy = TichLuy + CAST(inserted.TongTien AS INT) / 100000
FROM TheThanhVien
INNER JOIN HoaDon ON TheThanhVien.MaKH = HoaDon.MaKH
INNER JOIN inserted ON HoaDon.MaHD = inserted.MaHD;

GO

