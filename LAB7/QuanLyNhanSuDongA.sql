IF DB_ID(N'QuanLyNhanSuDongA') IS NULL
    EXEC(N'CREATE DATABASE [QuanLyNhanSuDongA]');
GO

USE [QuanLyNhanSuDongA];
GO

SET NOCOUNT ON;
SET XACT_ABORT ON;
SET DATEFIRST 1;

BEGIN TRY
    BEGIN TRANSACTION;

DROP TABLE IF EXISTS dbo.ChiTietBangLuong;
DROP TABLE IF EXISTS dbo.BangLuong;
DROP TABLE IF EXISTS dbo.CauHinhTinhLuong;
DROP TABLE IF EXISTS dbo.PhieuThuNopPhat;
DROP TABLE IF EXISTS dbo.QuyetDinhKyLuat;
DROP TABLE IF EXISTS dbo.PhieuChiKhenThuong;
DROP TABLE IF EXISTS dbo.QuyetDinhKhenThuong;
DROP TABLE IF EXISTS dbo.ChiTietPhuTroi;
DROP TABLE IF EXISTS dbo.PhieuPhuTroi;
DROP TABLE IF EXISTS dbo.PhieuChamCong;
DROP TABLE IF EXISTS dbo.ChiTietKeHoachTuan;
DROP TABLE IF EXISTS dbo.KeHoachTuan;
DROP TABLE IF EXISTS dbo.QuyetDinhLuong;
DROP TABLE IF EXISTS dbo.QuyetDinhChucVu;
DROP TABLE IF EXISTS dbo.HoSoBaoHiem;
DROP TABLE IF EXISTS dbo.HopDongLaoDong;
DROP TABLE IF EXISTS dbo.QuyetDinhTuyenDung;
DROP TABLE IF EXISTS dbo.NhanVien;
DROP TABLE IF EXISTS dbo.CaLamViec;
DROP TABLE IF EXISTS dbo.ChucVu;
DROP TABLE IF EXISTS dbo.PhongBan;

CREATE TABLE dbo.PhongBan(
 MaPB varchar(20) PRIMARY KEY,
 TenPB nvarchar(150) NOT NULL UNIQUE,
 LoaiDonVi nvarchar(30) NOT NULL CHECK(LoaiDonVi IN (N'Phòng',N'Ban',N'Phân xưởng')),
 DangHoatDong bit NOT NULL DEFAULT 1
);
CREATE TABLE dbo.ChucVu(
 MaCV varchar(20) PRIMARY KEY,
 TenCV nvarchar(120) NOT NULL UNIQUE,
 MoTa nvarchar(500) NULL
);
CREATE TABLE dbo.CaLamViec(
 MaCa varchar(20) PRIMARY KEY,
 TenCa nvarchar(100) NOT NULL UNIQUE,
 GioBatDau time NOT NULL,
 GioKetThuc time NOT NULL,
 CHECK(GioBatDau<>GioKetThuc)
);
CREATE TABLE dbo.NhanVien(
 MaNV varchar(20) PRIMARY KEY,
 HoTen nvarchar(120) NOT NULL,
 NgaySinh date NULL,
 GioiTinh nvarchar(10) NULL CHECK(GioiTinh IN (N'Nam',N'Nữ',N'Khác') OR GioiTinh IS NULL),
 CCCD varchar(20) NULL,
 DiaChi nvarchar(250) NULL,
 DienThoai varchar(20) NULL,
 Email varchar(150) NULL,
 MaPB varchar(20) NULL REFERENCES dbo.PhongBan(MaPB),
 TrangThai nvarchar(30) NOT NULL DEFAULT N'Đang thử việc'
   CHECK(TrangThai IN (N'Đang thử việc',N'Chờ hợp đồng',N'Chính thức'))
);
CREATE TABLE dbo.QuyetDinhTuyenDung(
 SoQDTD varchar(20) PRIMARY KEY,
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 MaPBThuViec varchar(20) NOT NULL REFERENCES dbo.PhongBan(MaPB),
 NgayQD date NOT NULL,
 TuNgay date NOT NULL,
 DenNgay date NOT NULL,
 LuongThuViec decimal(18,2) NOT NULL CHECK(LuongThuViec>=0),
 NoiDung nvarchar(1000) NOT NULL,
 NguoiKy nvarchar(120) NOT NULL,
 CHECK(DenNgay>=TuNgay)
);
CREATE TABLE dbo.HopDongLaoDong(
 SoHD varchar(20) PRIMARY KEY,
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 LoaiHD nvarchar(20) NOT NULL CHECK(LoaiHD IN (N'Dài hạn',N'Ngắn hạn')),
 NgayKy date NOT NULL,
 TuNgay date NOT NULL,
 DenNgay date NULL,
 NoiDung nvarchar(1000) NULL,
 TrangThai nvarchar(30) NOT NULL DEFAULT N'Đã lập'
   CHECK(TrangThai IN (N'Đã lập',N'Đang hiệu lực',N'Hết hiệu lực')),
 CHECK(DenNgay IS NULL OR DenNgay>=TuNgay)
);
CREATE TABLE dbo.HoSoBaoHiem(
 MaHSBH varchar(20) PRIMARY KEY,
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 SoHD varchar(20) NOT NULL REFERENCES dbo.HopDongLaoDong(SoHD),
 LoaiBH nvarchar(10) NOT NULL CHECK(LoaiBH IN (N'BHYT',N'BHXH')),
 SoSoThe nvarchar(50) NOT NULL,
 TyLeNguoiLD decimal(8,5) NOT NULL CHECK(TyLeNguoiLD>=0 AND TyLeNguoiLD<=1),
 TyLeCongTy decimal(8,5) NOT NULL CHECK(TyLeCongTy>=0 AND TyLeCongTy<=1),
 TuNgay date NOT NULL,
 DenNgay date NULL,
 UNIQUE(SoHD,LoaiBH,TuNgay),
 CHECK(DenNgay IS NULL OR DenNgay>=TuNgay)
);
CREATE TABLE dbo.QuyetDinhChucVu(
 SoQDCV varchar(20) PRIMARY KEY,
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 MaCV varchar(20) NOT NULL REFERENCES dbo.ChucVu(MaCV),
 NgayQD date NOT NULL,
 NgayHieuLuc date NOT NULL,
 PhuCapChucVu decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapChucVu>=0),
 NoiDung nvarchar(1000) NULL,
 NguoiKy nvarchar(120) NOT NULL
);
CREATE TABLE dbo.QuyetDinhLuong(
 SoQDL varchar(20) PRIMARY KEY,
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 NgayQD date NOT NULL,
 NgayHieuLuc date NOT NULL,
 LuongCoBan decimal(18,2) NOT NULL CHECK(LuongCoBan>=0),
 PhuCapLuong decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapLuong>=0),
 PhuCapDocHai decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapDocHai>=0),
 NoiDung nvarchar(1000) NULL,
 NguoiKy nvarchar(120) NOT NULL
);
CREATE TABLE dbo.KeHoachTuan(
 MaKH varchar(20) PRIMARY KEY,
 MaPB varchar(20) NOT NULL REFERENCES dbo.PhongBan(MaPB),
 TuanTuNgay date NOT NULL,
 TuanDenNgay date NOT NULL,
 NgayLap date NOT NULL,
 NguoiLap nvarchar(120) NOT NULL,
 CHECK(DATEDIFF(day,TuanTuNgay,TuanDenNgay)=6)
);
CREATE TABLE dbo.ChiTietKeHoachTuan(
 MaKH varchar(20) NOT NULL REFERENCES dbo.KeHoachTuan(MaKH),
 STT int NOT NULL CHECK(STT>0),
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 NgayLam date NOT NULL,
 MaCa varchar(20) NOT NULL REFERENCES dbo.CaLamViec(MaCa),
 KeHoachPhuTroi bit NOT NULL DEFAULT 0,
 SoGioPhuTroiDuKien decimal(6,2) NULL CHECK(SoGioPhuTroiDuKien>0),
 HinhThucPhuTroi nvarchar(20) NULL CHECK(HinhThucPhuTroi IN (N'Tăng ca',N'Ngày lễ',N'Ngày nghỉ')),
 PRIMARY KEY(MaKH,STT),
 CHECK((KeHoachPhuTroi=0 AND SoGioPhuTroiDuKien IS NULL AND HinhThucPhuTroi IS NULL)
    OR (KeHoachPhuTroi=1 AND SoGioPhuTroiDuKien IS NOT NULL AND HinhThucPhuTroi IS NOT NULL))
);
CREATE TABLE dbo.PhieuChamCong(
 MaCC varchar(20) PRIMARY KEY,
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 NgayCham date NOT NULL,
 MaCa varchar(20) NOT NULL REFERENCES dbo.CaLamViec(MaCa),
 GioVao time NULL,
 GioRa time NULL,
 SoGioLam decimal(6,2) NOT NULL CHECK(SoGioLam>=0),
 TrangThai nvarchar(20) NOT NULL CHECK(TrangThai IN (N'Đi làm',N'Nghỉ',N'Vắng')),
 NguoiCham nvarchar(120) NOT NULL,
 UNIQUE(MaNV,NgayCham,MaCa)
);
CREATE TABLE dbo.PhieuPhuTroi(
 SoPhieu varchar(20) PRIMARY KEY,
 NgayPhuTroi date NOT NULL,
 SoGioPhuTroi decimal(6,2) NOT NULL CHECK(SoGioPhuTroi>0),
 HinhThuc nvarchar(20) NOT NULL CHECK(HinhThuc IN (N'Tăng ca',N'Ngày lễ',N'Ngày nghỉ')),
 HeSo decimal(4,2) NOT NULL DEFAULT 1.50 CHECK(HeSo=1.50),
 NguoiLap nvarchar(120) NOT NULL,
 NoiDung nvarchar(500) NULL
);
CREATE TABLE dbo.ChiTietPhuTroi(
 SoPhieu varchar(20) NOT NULL REFERENCES dbo.PhieuPhuTroi(SoPhieu),
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 PRIMARY KEY(SoPhieu,MaNV)
);
CREATE TABLE dbo.QuyetDinhKhenThuong(
 SoQDKT varchar(20) PRIMARY KEY,
 NgayQD date NOT NULL,
 MaNV varchar(20) NULL REFERENCES dbo.NhanVien(MaNV),
 MaPB varchar(20) NULL REFERENCES dbo.PhongBan(MaPB),
 LoaiKhenThuong nvarchar(100) NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0),
 NoiDung nvarchar(1000) NOT NULL,
 NguoiKy nvarchar(120) NOT NULL,
 CONSTRAINT CK_QDKT_Target CHECK((MaNV IS NOT NULL AND MaPB IS NULL) OR (MaNV IS NULL AND MaPB IS NOT NULL))
);
CREATE TABLE dbo.PhieuChiKhenThuong(
 SoPhieuChi varchar(20) PRIMARY KEY,
 SoQDKT varchar(20) NOT NULL UNIQUE REFERENCES dbo.QuyetDinhKhenThuong(SoQDKT),
 NgayChi date NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0),
 NguoiChi nvarchar(120) NOT NULL
);
CREATE TABLE dbo.QuyetDinhKyLuat(
 SoQDKL varchar(20) PRIMARY KEY,
 NgayQD date NOT NULL,
 MaNV varchar(20) NULL REFERENCES dbo.NhanVien(MaNV),
 MaPB varchar(20) NULL REFERENCES dbo.PhongBan(MaPB),
 HinhThucXuLy nvarchar(100) NOT NULL,
 SoTienPhat decimal(18,2) NOT NULL CHECK(SoTienPhat>0),
 CachThu varchar(20) NOT NULL CHECK(CachThu IN ('PHIEU_THU','TRU_LUONG')),
 NoiDung nvarchar(1000) NOT NULL,
 NguoiKy nvarchar(120) NOT NULL,
 DaXuLy bit NOT NULL DEFAULT 0,
 CONSTRAINT CK_QDKL_Target CHECK((MaNV IS NOT NULL AND MaPB IS NULL) OR (MaNV IS NULL AND MaPB IS NOT NULL))
);
CREATE TABLE dbo.PhieuThuNopPhat(
 SoPhieuThu varchar(20) PRIMARY KEY,
 SoQDKL varchar(20) NOT NULL UNIQUE REFERENCES dbo.QuyetDinhKyLuat(SoQDKL),
 NgayThu date NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0),
 NguoiThu nvarchar(120) NOT NULL
);
CREATE TABLE dbo.CauHinhTinhLuong(
 Thang int NOT NULL CHECK(Thang BETWEEN 1 AND 12),
 Nam int NOT NULL CHECK(Nam>=2000),
 NgayCongChuan decimal(6,2) NOT NULL CHECK(NgayCongChuan>0),
 GioCongChuanNgay decimal(6,2) NOT NULL CHECK(GioCongChuanNgay>0),
 PRIMARY KEY(Thang,Nam)
);
CREATE TABLE dbo.BangLuong(
 MaBangLuong varchar(20) PRIMARY KEY,
 Thang int NOT NULL CHECK(Thang BETWEEN 1 AND 12),
 Nam int NOT NULL CHECK(Nam>=2000),
 NgayLap datetime2 NOT NULL DEFAULT SYSDATETIME(),
 NguoiLap nvarchar(120) NOT NULL,
 TrangThai nvarchar(20) NOT NULL DEFAULT N'Nháp' CHECK(TrangThai IN (N'Nháp',N'Đã chốt')),
 UNIQUE(Thang,Nam)
);
CREATE TABLE dbo.ChiTietBangLuong(
 MaBangLuong varchar(20) NOT NULL REFERENCES dbo.BangLuong(MaBangLuong),
 MaNV varchar(20) NOT NULL REFERENCES dbo.NhanVien(MaNV),
 LuongCoBan decimal(18,2) NOT NULL,
 PhuCapLuong decimal(18,2) NOT NULL,
 PhuCapDocHai decimal(18,2) NOT NULL,
 PhuCapChucVu decimal(18,2) NOT NULL,
 NgayCongThucTe decimal(6,2) NOT NULL,
 TienTheoCong decimal(18,2) NOT NULL,
 TienPhuTroi decimal(18,2) NOT NULL,
 KhauTruBaoHiem decimal(18,2) NOT NULL,
 KhauTruKyLuat decimal(18,2) NOT NULL,
 ThucLinh decimal(18,2) NOT NULL,
 PRIMARY KEY(MaBangLuong,MaNV)
);

CREATE UNIQUE INDEX UX_NhanVien_CCCD ON dbo.NhanVien(CCCD) WHERE CCCD IS NOT NULL;
CREATE INDEX IX_NhanVien_MaPB ON dbo.NhanVien(MaPB);
CREATE INDEX IX_QuyetDinhLuong_MaNV_NgayHieuLuc ON dbo.QuyetDinhLuong(MaNV, NgayHieuLuc DESC);
CREATE INDEX IX_QuyetDinhChucVu_MaNV_NgayHieuLuc ON dbo.QuyetDinhChucVu(MaNV, NgayHieuLuc DESC);
CREATE INDEX IX_PhieuChamCong_NgayCham ON dbo.PhieuChamCong(NgayCham, MaNV);

INSERT INTO dbo.PhongBan (MaPB, TenPB, LoaiDonVi, DangHoatDong) VALUES
('PB01', N'Phòng Tài chính - Kế toán', N'Phòng', 1),
('PB02', N'Phòng Kỹ thuật', N'Phòng', 1),
('PB03', N'Phân xưởng Sản xuất', N'Phân xưởng', 1),
('PB04', N'Phòng Hành chính - Nhân sự', N'Phòng', 1),
('PB05', N'Ban Quản lý chất lượng', N'Ban', 1);

INSERT INTO dbo.ChucVu (MaCV, TenCV, MoTa) VALUES
('CV01', N'Chuyên viên', N'Thực hiện công việc chuyên môn theo phân công.'),
('CV02', N'Tổ trưởng', N'Điều phối công việc và quản lý tổ sản xuất.'),
('CV03', N'Trưởng phòng', N'Quản lý nhân sự và hoạt động của phòng.'),
('CV04', N'Công nhân', N'Thực hiện công việc sản xuất tại phân xưởng.'),
('CV05', N'Nhân viên kiểm định', N'Kiểm tra chất lượng nguyên liệu và thành phẩm.');

INSERT INTO dbo.CaLamViec (MaCa, TenCa, GioBatDau, GioKetThuc) VALUES
('CA01', N'Hành chính', '08:00', '17:00'),
('CA02', N'Ca sáng', '06:00', '14:00'),
('CA03', N'Ca chiều', '14:00', '22:00'),
('CA04', N'Ca đêm', '22:00', '06:00');

INSERT INTO dbo.NhanVien (MaNV, HoTen, NgaySinh, GioiTinh, CCCD, DiaChi, DienThoai, Email, MaPB, TrangThai) VALUES
('NV001', N'Nguyễn Minh An', '19950312', N'Nam', '079000000001', N'Đà Nẵng', '0900000001', 'an.nguyen@example.com', 'PB02', N'Chính thức'),
('NV002', N'Trần Thu Hà', '19970820', N'Nữ', '079000000002', N'Đà Nẵng', '0900000002', 'ha.tran@example.com', 'PB01', N'Chính thức'),
('NV003', N'Lê Quốc Huy', '19920215', N'Nam', '079000000003', N'Đà Nẵng', '0900000003', 'huy.le@example.com', 'PB03', N'Chính thức'),
('NV004', N'Phạm Ngọc Mai', '19960909', N'Nữ', '079000000004', N'Huế', '0900000004', 'mai.pham@example.com', 'PB04', N'Chính thức'),
('NV005', N'Hoàng Đức Long', '19940425', N'Nam', '079000000005', N'Đà Nẵng', '0900000005', 'long.hoang@example.com', 'PB03', N'Chính thức'),
('NV006', N'Võ Thanh Thảo', '19981105', N'Nữ', '079000000006', N'Đà Nẵng', '0900000006', 'thao.vo@example.com', 'PB05', N'Chính thức'),
('NV007', N'Đặng Gia Bảo', '20010516', N'Nam', '079000000007', N'Đà Nẵng', '0900000007', 'bao.dang@example.com', 'PB02', N'Đang thử việc'),
('NV008', N'Bùi Khánh Linh', '20000622', N'Nữ', '079000000008', N'Huế', '0900000008', 'linh.bui@example.com', 'PB01', N'Đang thử việc'),
('NV009', N'Đỗ Minh Khang', '19991030', N'Nam', '079000000009', N'Đà Nẵng', '0900000009', 'khang.do@example.com', 'PB03', N'Chờ hợp đồng'),
('NV010', N'Nguyễn Hải Yến', '19910308', N'Nữ', '079000000010', N'Đà Nẵng', '0900000010', 'yen.nguyen@example.com', 'PB01', N'Chính thức');

INSERT INTO dbo.QuyetDinhTuyenDung (SoQDTD, MaNV, MaPBThuViec, NgayQD, TuNgay, DenNgay, LuongThuViec, NoiDung, NguoiKy)
SELECT 'TD' + RIGHT(n.MaNV, 3), n.MaNV, n.MaPB,
    CASE n.MaNV WHEN 'NV007' THEN '20261001' WHEN 'NV008' THEN '20261008' ELSE '20260625' END,
    CASE n.MaNV WHEN 'NV007' THEN '20261005' WHEN 'NV008' THEN '20261012' WHEN 'NV009' THEN '20260801' ELSE '20260701' END,
    CASE n.MaNV WHEN 'NV007' THEN '20261204' WHEN 'NV008' THEN '20261211' WHEN 'NV009' THEN '20260930' ELSE '20260831' END,
    CASE WHEN n.MaNV IN ('NV003', 'NV005', 'NV009') THEN 7000000 ELSE 8500000 END,
    N'Tuyển dụng và thử việc tại ' + p.TenPB, N'Giám đốc Nguyễn Văn Thành'
FROM dbo.NhanVien n
JOIN dbo.PhongBan p ON p.MaPB = n.MaPB;

INSERT INTO dbo.HopDongLaoDong (SoHD, MaNV, LoaiHD, NgayKy, TuNgay, DenNgay, NoiDung, TrangThai)
SELECT 'HD' + RIGHT(MaNV, 3), MaNV,
    CASE WHEN MaNV = 'NV005' THEN N'Ngắn hạn' ELSE N'Dài hạn' END,
    '20260901', '20260901', CASE WHEN MaNV = 'NV005' THEN CONVERT(date, '20270228') END,
    N'Hợp đồng lao động chính thức sau khi hoàn thành thử việc.', N'Đang hiệu lực'
FROM dbo.NhanVien
WHERE TrangThai = N'Chính thức';

INSERT INTO dbo.HoSoBaoHiem (MaHSBH, MaNV, SoHD, LoaiBH, SoSoThe, TyLeNguoiLD, TyLeCongTy, TuNgay, DenNgay)
SELECT 'BH' + RIGHT(h.MaNV, 3) + b.LoaiBH, h.MaNV, h.SoHD, b.LoaiBH,
    b.LoaiBH + '-' + h.MaNV, b.TyLeNguoiLD, b.TyLeCongTy, '20260901', NULL
FROM dbo.HopDongLaoDong h
CROSS JOIN (VALUES (N'BHYT', 0.01500, 0.03000), (N'BHXH', 0.08000, 0.17500)) b(LoaiBH, TyLeNguoiLD, TyLeCongTy)
WHERE h.LoaiHD = N'Dài hạn';

INSERT INTO dbo.QuyetDinhChucVu (SoQDCV, MaNV, MaCV, NgayQD, NgayHieuLuc, PhuCapChucVu, NoiDung, NguoiKy) VALUES
('CVQD001', 'NV001', 'CV01', '20260901', '20260901', 500000, N'Phân công chuyên viên kỹ thuật.', N'Nguyễn Văn Thành'),
('CVQD002', 'NV002', 'CV01', '20260901', '20260901', 300000, N'Phân công chuyên viên kế toán.', N'Nguyễn Văn Thành'),
('CVQD003', 'NV003', 'CV02', '20260901', '20260901', 1000000, N'Bổ nhiệm tổ trưởng sản xuất.', N'Nguyễn Văn Thành'),
('CVQD004', 'NV004', 'CV01', '20260901', '20260901', 300000, N'Phân công chuyên viên nhân sự.', N'Nguyễn Văn Thành'),
('CVQD005', 'NV005', 'CV04', '20260901', '20260901', 0, N'Phân công công nhân sản xuất.', N'Nguyễn Văn Thành'),
('CVQD006', 'NV006', 'CV05', '20260901', '20260901', 500000, N'Phân công nhân viên kiểm định.', N'Nguyễn Văn Thành'),
('CVQD010', 'NV010', 'CV03', '20260901', '20260901', 2000000, N'Bổ nhiệm trưởng phòng kế toán.', N'Nguyễn Văn Thành');

INSERT INTO dbo.QuyetDinhLuong (SoQDL, MaNV, NgayQD, NgayHieuLuc, LuongCoBan, PhuCapLuong, PhuCapDocHai, NoiDung, NguoiKy) VALUES
('L001', 'NV001', '20260901', '20260901', 12000000, 1000000, 0, N'Lương chính thức.', N'Nguyễn Văn Thành'),
('L002', 'NV002', '20260901', '20260901', 10000000, 500000, 0, N'Lương chính thức.', N'Nguyễn Văn Thành'),
('L003', 'NV003', '20260901', '20260901', 11000000, 800000, 500000, N'Lương tổ trưởng sản xuất.', N'Nguyễn Văn Thành'),
('L004', 'NV004', '20260901', '20260901', 9500000, 500000, 0, N'Lương chuyên viên nhân sự.', N'Nguyễn Văn Thành'),
('L005', 'NV005', '20260901', '20260901', 8500000, 500000, 700000, N'Lương công nhân sản xuất.', N'Nguyễn Văn Thành'),
('L006', 'NV006', '20260901', '20260901', 10500000, 700000, 300000, N'Lương nhân viên kiểm định.', N'Nguyễn Văn Thành'),
('L010', 'NV010', '20260901', '20260901', 18000000, 1500000, 0, N'Lương trưởng phòng.', N'Nguyễn Văn Thành'),
('L011', 'NV001', '20260928', '20261001', 13000000, 1000000, 0, N'Điều chỉnh lương từ tháng 10.', N'Nguyễn Văn Thành');

INSERT INTO dbo.CauHinhTinhLuong (Thang, Nam, NgayCongChuan, GioCongChuanNgay) VALUES
(9, 2026, 22, 8), (10, 2026, 22, 8), (11, 2026, 21, 8), (12, 2026, 23, 8);

INSERT INTO dbo.KeHoachTuan (MaKH, MaPB, TuanTuNgay, TuanDenNgay, NgayLap, NguoiLap)
SELECT 'KH' + RIGHT(p.MaPB, 2) + CONVERT(char(8), w.TuNgay, 112), p.MaPB,
    w.TuNgay, DATEADD(day, 6, w.TuNgay), DATEADD(day, -3, w.TuNgay), N'Phạm Ngọc Mai'
FROM dbo.PhongBan p
CROSS JOIN (VALUES (CONVERT(date, '20260831')), ('20260907'), ('20260914'), ('20260921'), ('20260928'),
    ('20261005'), ('20261012'), ('20261019'), ('20261026')) w(TuNgay);

;WITH Ngay AS
(
    SELECT CONVERT(date, '20260901') AS NgayLam
    UNION ALL
    SELECT DATEADD(day, 1, NgayLam) FROM Ngay WHERE NgayLam < '20261031'
)
INSERT INTO dbo.ChiTietKeHoachTuan (MaKH, STT, MaNV, NgayLam, MaCa, KeHoachPhuTroi, SoGioPhuTroiDuKien, HinhThucPhuTroi)
SELECT k.MaKH, ROW_NUMBER() OVER (PARTITION BY k.MaKH ORDER BY d.NgayLam, n.MaNV), n.MaNV, d.NgayLam,
    CASE WHEN n.MaPB = 'PB03' THEN 'CA02' ELSE 'CA01' END,
    CASE WHEN d.NgayLam = '20261020' AND n.MaNV IN ('NV001', 'NV003', 'NV005') THEN 1 ELSE 0 END,
    CASE WHEN d.NgayLam = '20261020' AND n.MaNV IN ('NV001', 'NV003', 'NV005') THEN 2 END,
    CASE WHEN d.NgayLam = '20261020' AND n.MaNV IN ('NV001', 'NV003', 'NV005') THEN N'Tăng ca' END
FROM Ngay d
JOIN dbo.KeHoachTuan k ON d.NgayLam BETWEEN k.TuanTuNgay AND k.TuanDenNgay
JOIN dbo.NhanVien n ON n.MaPB = k.MaPB
JOIN dbo.QuyetDinhTuyenDung td ON td.MaNV = n.MaNV AND td.TuNgay <= d.NgayLam
WHERE DATEDIFF(day, '19000101', d.NgayLam) % 7 < 5
    AND (n.TrangThai <> N'Chờ hợp đồng' OR d.NgayLam <= td.DenNgay)
OPTION (MAXRECURSION 100);

INSERT INTO dbo.PhieuChamCong (MaCC, MaNV, NgayCham, MaCa, GioVao, GioRa, SoGioLam, TrangThai, NguoiCham)
SELECT 'CC' + RIGHT(c.MaNV, 3) + CONVERT(char(8), c.NgayLam, 112), c.MaNV, c.NgayLam, c.MaCa,
    CASE WHEN a.TrangThai = N'Đi làm' THEN ca.GioBatDau END,
    CASE WHEN a.TrangThai = N'Đi làm' THEN ca.GioKetThuc END,
    CASE WHEN a.TrangThai = N'Đi làm' THEN 8 ELSE 0 END, a.TrangThai, N'Phạm Ngọc Mai'
FROM dbo.ChiTietKeHoachTuan c
JOIN dbo.CaLamViec ca ON ca.MaCa = c.MaCa
CROSS APPLY (VALUES (CASE
    WHEN c.MaNV = 'NV004' AND c.NgayLam = '20260911' THEN N'Nghỉ'
    WHEN c.MaNV = 'NV005' AND c.NgayLam = '20260917' THEN N'Vắng'
    WHEN c.MaNV = 'NV002' AND c.NgayLam = '20261009' THEN N'Nghỉ'
    ELSE N'Đi làm' END)) a(TrangThai)
WHERE c.NgayLam <= '20261023';

INSERT INTO dbo.PhieuPhuTroi (SoPhieu, NgayPhuTroi, SoGioPhuTroi, HinhThuc, HeSo, NguoiLap, NoiDung) VALUES
('PT001', '20260915', 2, N'Tăng ca', 1.50, N'Phạm Ngọc Mai', N'Hoàn thành đơn hàng tháng 9.'),
('PT002', '20260922', 3, N'Tăng ca', 1.50, N'Phạm Ngọc Mai', N'Kiểm tra và bảo trì dây chuyền.'),
('PT003', '20261010', 4, N'Ngày nghỉ', 1.50, N'Phạm Ngọc Mai', N'Kiểm kê thiết bị cuối tuần.'),
('PT004', '20261020', 2, N'Tăng ca', 1.50, N'Phạm Ngọc Mai', N'Hoàn thành kế hoạch sản xuất tuần.');

INSERT INTO dbo.ChiTietPhuTroi (SoPhieu, MaNV) VALUES
('PT001', 'NV003'), ('PT001', 'NV005'), ('PT002', 'NV001'), ('PT002', 'NV006'),
('PT003', 'NV001'), ('PT003', 'NV006'), ('PT004', 'NV001'), ('PT004', 'NV003'), ('PT004', 'NV005');

INSERT INTO dbo.QuyetDinhKhenThuong (SoQDKT, NgayQD, MaNV, MaPB, LoaiKhenThuong, SoTien, NoiDung, NguoiKy) VALUES
('KT001', '20260925', 'NV002', NULL, N'Hoàn thành tốt công việc', 1000000, N'Hoàn thành báo cáo tháng đúng hạn.', N'Nguyễn Văn Thành'),
('KT002', '20260928', NULL, 'PB03', N'Vượt chỉ tiêu sản xuất', 5000000, N'Tập thể phân xưởng hoàn thành vượt kế hoạch.', N'Nguyễn Văn Thành'),
('KT003', '20261015', 'NV006', NULL, N'Sáng kiến cải tiến', 1500000, N'Đề xuất cải tiến quy trình kiểm định.', N'Nguyễn Văn Thành'),
('KT004', '20261021', NULL, 'PB02', N'Hoàn thành dự án', 3000000, N'Hoàn thành nâng cấp hệ thống nội bộ.', N'Nguyễn Văn Thành');

INSERT INTO dbo.PhieuChiKhenThuong (SoPhieuChi, SoQDKT, NgayChi, SoTien, NguoiChi) VALUES
('PCKT001', 'KT001', '20260928', 1000000, N'Trần Thu Hà'),
('PCKT002', 'KT002', '20260929', 5000000, N'Nguyễn Hải Yến'),
('PCKT003', 'KT003', '20261016', 1500000, N'Trần Thu Hà');

INSERT INTO dbo.QuyetDinhKyLuat (SoQDKL, NgayQD, MaNV, MaPB, HinhThucXuLy, SoTienPhat, CachThu, NoiDung, NguoiKy, DaXuLy) VALUES
('KL001', '20260917', 'NV005', NULL, N'Vắng không phép', 200000, 'TRU_LUONG', N'Khấu trừ tại bảng lương tháng 9.', N'Nguyễn Văn Thành', 1),
('KL002', '20260921', 'NV003', NULL, N'Vi phạm quy trình bàn giao', 150000, 'PHIEU_THU', N'Nộp phạt theo phiếu thu.', N'Nguyễn Văn Thành', 1),
('KL003', '20261019', 'NV001', NULL, N'Vi phạm nội quy', 100000, 'TRU_LUONG', N'Khấu trừ tại bảng lương tháng 10.', N'Nguyễn Văn Thành', 0),
('KL004', '20261022', NULL, 'PB03', N'Chậm báo cáo an toàn', 300000, 'PHIEU_THU', N'Tập thể phân xưởng nộp phạt theo phiếu thu.', N'Nguyễn Văn Thành', 0);

INSERT INTO dbo.PhieuThuNopPhat (SoPhieuThu, SoQDKL, NgayThu, SoTien, NguoiThu) VALUES
('PTNP001', 'KL002', '20260922', 150000, N'Trần Thu Hà');

INSERT INTO dbo.BangLuong (MaBangLuong, Thang, Nam, NgayLap, NguoiLap, TrangThai) VALUES
('BL202609', 9, 2026, '20260930 17:00:00', N'Nguyễn Hải Yến', N'Đã chốt');

INSERT INTO dbo.ChiTietBangLuong (MaBangLuong, MaNV, LuongCoBan, PhuCapLuong, PhuCapDocHai, PhuCapChucVu,
    NgayCongThucTe, TienTheoCong, TienPhuTroi, KhauTruBaoHiem, KhauTruKyLuat, ThucLinh)
SELECT 'BL202609', n.MaNV, l.LuongCoBan, l.PhuCapLuong, l.PhuCapDocHai, cv.PhuCapChucVu,
    cc.NgayCong, t.TienCong, t.TienPhuTroi, t.TienBaoHiem, kl.TienPhat,
    t.TienCong + l.PhuCapLuong + l.PhuCapDocHai + cv.PhuCapChucVu + t.TienPhuTroi - t.TienBaoHiem - kl.TienPhat
FROM dbo.NhanVien n
CROSS JOIN (SELECT NgayCongChuan, GioCongChuanNgay FROM dbo.CauHinhTinhLuong WHERE Thang = 9 AND Nam = 2026) cfg
CROSS APPLY (SELECT TOP (1) LuongCoBan, PhuCapLuong, PhuCapDocHai FROM dbo.QuyetDinhLuong
    WHERE MaNV = n.MaNV AND NgayHieuLuc <= '20260930' ORDER BY NgayHieuLuc DESC) l
CROSS APPLY (SELECT TOP (1) PhuCapChucVu FROM dbo.QuyetDinhChucVu
    WHERE MaNV = n.MaNV AND NgayHieuLuc <= '20260930' ORDER BY NgayHieuLuc DESC) cv
CROSS APPLY (SELECT COUNT(*) AS NgayCong FROM dbo.PhieuChamCong
    WHERE MaNV = n.MaNV AND NgayCham BETWEEN '20260901' AND '20260930' AND TrangThai = N'Đi làm') cc
CROSS APPLY (SELECT ISNULL(SUM(p.SoGioPhuTroi * p.HeSo), 0) AS GioQuyDoi
    FROM dbo.PhieuPhuTroi p JOIN dbo.ChiTietPhuTroi c ON c.SoPhieu = p.SoPhieu
    WHERE c.MaNV = n.MaNV AND p.NgayPhuTroi BETWEEN '20260901' AND '20260930') pt
CROSS APPLY (SELECT ISNULL(SUM(TyLeNguoiLD), 0) AS TyLe FROM dbo.HoSoBaoHiem
    WHERE MaNV = n.MaNV AND TuNgay <= '20260930' AND (DenNgay IS NULL OR DenNgay >= '20260901')) bh
CROSS APPLY (SELECT ISNULL(SUM(SoTienPhat), 0) AS TienPhat FROM dbo.QuyetDinhKyLuat
    WHERE MaNV = n.MaNV AND CachThu = 'TRU_LUONG' AND NgayQD BETWEEN '20260901' AND '20260930') kl
CROSS APPLY (SELECT CAST(ROUND(l.LuongCoBan * cc.NgayCong / cfg.NgayCongChuan, 2) AS decimal(18,2)),
    CAST(ROUND(l.LuongCoBan / cfg.NgayCongChuan / cfg.GioCongChuanNgay * pt.GioQuyDoi, 2) AS decimal(18,2)),
    CAST(ROUND(l.LuongCoBan * bh.TyLe, 2) AS decimal(18,2))) t(TienCong, TienPhuTroi, TienBaoHiem)
WHERE n.TrangThai = N'Chính thức';

    COMMIT TRANSACTION;
END TRY
BEGIN CATCH
    IF XACT_STATE() <> 0
        ROLLBACK TRANSACTION;
    THROW;
END CATCH;
GO
