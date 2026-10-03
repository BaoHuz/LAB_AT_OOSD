-- Create Database
CREATE DATABASE eShoppingDB;
GO

USE eShoppingDB;
GO

-- 1. Table KhachHang
CREATE TABLE KhachHang (
    MaKH VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATE NULL,
    CMND VARCHAR(20) NULL,
    DiaChi NVARCHAR(200) NULL,
    DienThoai VARCHAR(20) NULL,
    TenDangNhap VARCHAR(50) UNIQUE NOT NULL,
    MatKhau VARCHAR(100) NOT NULL,
    Email VARCHAR(100) NULL
);

-- 2. Table NhomSanPham
CREATE TABLE NhomSanPham (
    MaNhom VARCHAR(20) PRIMARY KEY,
    TenNhom NVARCHAR(100) NOT NULL
);

-- 3. Table SanPham
CREATE TABLE SanPham (
    MaSP VARCHAR(20) PRIMARY KEY,
    MaNhom VARCHAR(20) NOT NULL,
    TenSP NVARCHAR(150) NOT NULL,
    NhaSanXuat NVARCHAR(100) NULL,
    HinhAnh NVARCHAR(255) NULL,
    MoTa NVARCHAR(MAX) NULL,
    GiaBanHienHang DECIMAL(18,2) NOT NULL CHECK (GiaBanHienHang >= 0),
    TinhTrang BIT NOT NULL DEFAULT 1,
    CONSTRAINT FK_SanPham_NhomSanPham FOREIGN KEY (MaNhom) REFERENCES NhomSanPham(MaNhom)
);

-- 4. Table DonHang
CREATE TABLE DonHang (
    MaDH VARCHAR(20) PRIMARY KEY,
    MaKH VARCHAR(20) NOT NULL,
    ThoiDiemDat DATETIME NOT NULL DEFAULT GETDATE(),
    NguoiNhanHoTen NVARCHAR(100) NOT NULL,
    NguoiNhanDiaChi NVARCHAR(200) NOT NULL,
    NguoiNhanDienThoai VARCHAR(20) NOT NULL,
    LoaiPhieuDat NVARCHAR(50) NOT NULL,
    ChiPhiGiaoHang DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (ChiPhiGiaoHang >= 0),
    TongTriGia DECIMAL(18,2) NOT NULL CHECK (TongTriGia >= 0),
    LoaiTheThanhToan VARCHAR(20) NOT NULL,
    SoTheMasked VARCHAR(20) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Đã xác nhận',
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

-- 5. Table ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    MaDH VARCHAR(20) NOT NULL,
    MaSP VARCHAR(20) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL CHECK (DonGia >= 0),
    CONSTRAINT PK_ChiTietDonHang PRIMARY KEY (MaDH, MaSP),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY (MaDH) REFERENCES DonHang(MaDH),
    CONSTRAINT FK_CTDH_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);
GO

INSERT INTO KhachHang (MaKH, HoTen, NgaySinh, CMND, DiaChi, DienThoai, TenDangNhap, MatKhau, Email)
VALUES 
('KH001', N'Nguyễn Văn An', '1995-05-15', '079195000001', N'123 Nguyễn Huệ, Quận 1, TP.HCM', '0903123456', 'nguuyenvanan', '123456', 'an.nguyen@gmail.com'),
('KH002', N'Trần Thị Bích', '1998-08-20', '079198000002', N'456 Lê Lợi, Quận 1, TP.HCM', '0918234567', 'tranbich98', '123456', 'bich.tran@yahoo.com'),
('KH003', N'Lê Hoàng Cường', '1992-12-10', '079192000003', N'789 Điện Biên Phủ, Bình Thạnh, TP.HCM', '0987345678', 'cuongle92', '123456', 'cuong.le@outlook.com'),
('KH004', N'Phạm Minh Dung', '2000-03-25', '079200000004', N'12 CMT8, Quận 3, TP.HCM', '0934456789', 'dungpham', '123456', 'dung.pham@gmail.com'),
('KH005', N'Võ Quốc Em', '1997-11-05', '079197000005', N'34 Võ Văn Ngân, TP. Thủ Đức, TP.HCM', '0975567890', 'emvo97', '123456', 'em.vo@gmail.com');

INSERT INTO NhomSanPham (MaNhom, TenNhom)
VALUES 
('NSP01', N'Máy chụp hình kỹ thuật số'),
('NSP02', N'Đồ chơi trẻ em'),
('NSP03', N'Thiết bị điện gia dụng'),
('NSP04', N'Thiết bị máy tính'),
('NSP05', N'Phụ kiện công nghệ');


INSERT INTO SanPham (MaSP, MaNhom, TenSP, NhaSanXuat, HinhAnh, MoTa, GiaBanHienHang, TinhTrang)
VALUES 
('SP001', 'NSP01', N'Máy ảnh Canon EOS 80D', N'Canon', 'canon_80d.jpg', N'Cảm biến CMOS 24.2 MP, Bộc xử lý DIGIC 6', 18500000, 1),
('SP002', 'NSP01', N'Máy ảnh Sony Alpha A7 III', N'Sony', 'sony_a7m3.jpg', N'Cảm biến full-frame 24.2 MP, Quay phim 4K', 38000000, 1),
('SP003', 'NSP02', N'Bộ xếp hình Lego City', N'Lego', 'lego_city.jpg', N'Bộ lắp ráp mô hình cảnh sát 500 chi tiết', 1200000, 1),
('SP004', 'NSP03', N'Nồi chiên không dầu Philips', N'Philips', 'philips_af.jpg', N'Dung tích 4.1L, công nghệ Rapid Air', 2800000, 1),
('SP005', 'NSP04', N'Màn hình Dell UltraSharp 27 inch', N'Dell', 'dell_u2722d.jpg', N'Độ phân giải 2K QHD, tấm nền IPS chuyên đồ họa', 8500000, 1);


INSERT INTO DonHang (MaDH, MaKH, ThoiDiemDat, NguoiNhanHoTen, NguoiNhanDiaChi, NguoiNhanDienThoai, LoaiPhieuDat, ChiPhiGiaoHang, TongTriGia, LoaiTheThanhToan, SoTheMasked, TrangThai)
VALUES 
('DH001', 'KH001', '2026-10-01 09:30:00', N'Nguyễn Văn An', N'123 Nguyễn Huệ, Quận 1, TP.HCM', '0903123456', N'CPN', 0, 18500000, 'VISA', '**** **** **** 1234', N'Đã xác nhận'),
('DH002', 'KH002', '2026-10-01 14:15:00', N'Trần Văn Tâm', N'100 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0912999888', N'CPN_TRONG_NGAY', 0, 38000000, 'Master', '**** **** **** 5678', N'Đã xác nhận'),
('DH003', 'KH003', '2026-10-02 10:00:00', N'Lê Hoàng Cường', N'789 Điện Biên Phủ, Bình Thạnh, TP.HCM', '0987345678', N'THUONG', 20000, 1220000, 'Discover', '**** **** **** 9012', N'Đã xác nhận'),
('DH004', 'KH004', '2026-10-02 16:45:00', N'Phạm Minh Dung', N'12 CMT8, Quận 3, TP.HCM', '0934456789', N'CPN', 35000, 2835000, 'Amex', '**** **** *** 3456', N'Đã xác nhận'),
('DH005', 'KH005', '2026-10-03 08:20:00', N'Nguyễn Thị Mai', N'15 Xô Viết Nghệ Tĩnh, Bình Thạnh, TP.HCM', '0908111222', N'CPN_TRONG_NGAY', 0, 8500000, 'VISA', '**** **** **** 7890', N'Đã xác nhận');

INSERT INTO ChiTietDonHang (MaDH, MaSP, SoLuong, DonGia)
VALUES 
('DH001', 'SP001', 1, 18500000),
('DH002', 'SP002', 1, 38000000),
('DH003', 'SP003', 1, 1200000),
('DH004', 'SP004', 1, 2800000),
('DH005', 'SP005', 1, 8500000);
GO