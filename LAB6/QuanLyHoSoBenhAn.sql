IF DB_ID(N'QuanLyHoSoBenhAn') IS NULL
 CREATE DATABASE QuanLyHoSoBenhAn;
GO
USE QuanLyHoSoBenhAn;
GO
CREATE TABLE BenhNhan(
 MaBN varchar(20) PRIMARY KEY,
 HoTen nvarchar(120) NOT NULL, NgaySinh date NOT NULL,
 DiaChi nvarchar(250) NOT NULL, DienThoai varchar(20) NOT NULL,
 Anh3x4 nvarchar(500) NOT NULL
);
CREATE TABLE HoSoBenhAn(
 MaHoSo varchar(20) PRIMARY KEY,
 MaBN varchar(20) NOT NULL UNIQUE REFERENCES BenhNhan(MaBN),
 NgayCap datetime2 NOT NULL,
 TrangThai varchar(20) NOT NULL DEFAULT 'HoatDong'
  CHECK(TrangThai IN ('HoatDong','LuuTru'))
);
CREATE TABLE PhieuThuLePhi(
 SoPhieuThu varchar(20) PRIMARY KEY,
 MaHoSo varchar(20) NOT NULL REFERENCES HoSoBenhAn(MaHoSo),
 NgayThu datetime2 NOT NULL,
 SoTien decimal(18,2) NOT NULL CHECK(SoTien>0),
 NamApDung int NOT NULL CHECK(NamApDung BETWEEN 1900 AND 9999),
 TuNgay datetime2 NOT NULL, DenNgay datetime2 NOT NULL,
 UNIQUE(MaHoSo,TuNgay),
 CHECK(DenNgay=DATEADD(day,365,TuNgay)),
 CHECK(NamApDung=YEAR(TuNgay)),
 CHECK(TuNgay>=NgayThu)
);
CREATE TABLE BacSi(
 MaBS varchar(20) PRIMARY KEY, HoTen nvarchar(120) NOT NULL,
 ChuyenKhoa nvarchar(120) NULL, DienThoai varchar(20) NULL
);
CREATE TABLE KhoaDieuTri(
 MaKhoa varchar(20) PRIMARY KEY,
 TenKhoa nvarchar(120) NOT NULL UNIQUE,
 PhongKham nvarchar(60) NULL
);
CREATE TABLE LichHenDinhKy(
 MaLichHen varchar(20) PRIMARY KEY,
 MaHoSo varchar(20) NOT NULL REFERENCES HoSoBenhAn(MaHoSo),
 NgayGioHen datetime2 NOT NULL,
 Quy int NOT NULL CHECK(Quy BETWEEN 1 AND 4), Nam int NOT NULL,
 TrangThai varchar(20) NOT NULL DEFAULT 'DaHen'
  CHECK(TrangThai IN ('DaHen','DaKham','Huy')),
 CHECK(Quy=DATEPART(QUARTER,NgayGioHen) AND Nam=YEAR(NgayGioHen))
);
CREATE UNIQUE INDEX UX_Lich_Quy
 ON LichHenDinhKy(MaHoSo,Nam,Quy) WHERE TrangThai<>'Huy';
CREATE TABLE PhieuKhamBenh(
 MaPhieuKham varchar(20) PRIMARY KEY,
 MaHoSo varchar(20) NOT NULL REFERENCES HoSoBenhAn(MaHoSo),
 MaBS varchar(20) NOT NULL REFERENCES BacSi(MaBS),
 MaKhoa varchar(20) NOT NULL REFERENCES KhoaDieuTri(MaKhoa),
 MaLichHen varchar(20) NULL REFERENCES LichHenDinhKy(MaLichHen),
 NgayGioKham datetime2 NOT NULL,
 TrieuChung nvarchar(1000) NULL,
 ThanNhiet decimal(4,1) NULL CHECK(ThanNhiet BETWEEN 25 AND 45),
 HuyetAp nvarchar(30) NULL, ChanDoan nvarchar(1000) NULL,
 DienBien nvarchar(1500) NULL, PhanUngPhu nvarchar(1000) NULL,
 LoaiKham varchar(10) NOT NULL CHECK(LoaiKham IN ('Thuong','DinhKy')),
 TrangThai varchar(20) NOT NULL DEFAULT 'DangXuLy'
  CHECK(TrangThai IN ('DangXuLy','ChoThanhToan','HoanTat')),
 NgayHoanTat datetime2 NULL, NguoiHoanTat nvarchar(100) NULL,
 UNIQUE(MaPhieuKham,MaBS),
 CHECK((LoaiKham='Thuong' AND MaLichHen IS NULL) OR
       (LoaiKham='DinhKy' AND MaLichHen IS NOT NULL)),
 CHECK(TrangThai<>'HoanTat' OR
       (NgayHoanTat IS NOT NULL AND NguoiHoanTat IS NOT NULL))
);
CREATE UNIQUE INDEX UX_Phieu_Lich ON PhieuKhamBenh(MaLichHen)
 WHERE MaLichHen IS NOT NULL;
CREATE TABLE XetNghiem(
 MaXetNghiem varchar(20) PRIMARY KEY,
 TenXetNghiem nvarchar(150) NOT NULL,
 DonGia decimal(18,2) NOT NULL CHECK(DonGia>=0)
);
CREATE TABLE ChiDinhXetNghiem(
 MaPhieuKham varchar(20) NOT NULL REFERENCES PhieuKhamBenh(MaPhieuKham),
 MaXetNghiem varchar(20) NOT NULL REFERENCES XetNghiem(MaXetNghiem),
 NgayChiDinh datetime2 NOT NULL,
 DonGiaApDung decimal(18,2) NOT NULL CHECK(DonGiaApDung>=0),
 KetQua nvarchar(2000) NULL, NgayThucHien datetime2 NULL,
 TrangThai varchar(20) NOT NULL DEFAULT 'ChoKetQua'
  CHECK(TrangThai IN ('ChoKetQua','DaCoKetQua')),
 PRIMARY KEY(MaPhieuKham,MaXetNghiem),
 CHECK(TrangThai<>'DaCoKetQua' OR
  (NULLIF(LTRIM(RTRIM(KetQua)),N'') IS NOT NULL
   AND NgayThucHien IS NOT NULL AND NgayThucHien>=NgayChiDinh))
);
CREATE TABLE Thuoc(
 MaThuoc varchar(20) PRIMARY KEY, TenThuoc nvarchar(150) NOT NULL,
 DonViTinh nvarchar(40) NOT NULL,
 DonGia decimal(18,2) NOT NULL CHECK(DonGia>=0),
 DangSuDung bit NOT NULL DEFAULT 1
);
CREATE TABLE ToaThuoc(
 MaToa varchar(20) PRIMARY KEY,
 MaPhieuKham varchar(20) NOT NULL UNIQUE,
 MaBS varchar(20) NOT NULL, NgayLap datetime2 NOT NULL,
 DanDoBacSi nvarchar(1000) NULL,
 DaPhat bit NOT NULL DEFAULT 0, NgayPhat datetime2 NULL,
 FOREIGN KEY(MaPhieuKham,MaBS)
  REFERENCES PhieuKhamBenh(MaPhieuKham,MaBS),
 CHECK((DaPhat=0 AND NgayPhat IS NULL) OR
       (DaPhat=1 AND NgayPhat IS NOT NULL))
);
CREATE TABLE ChiTietToaThuoc(
 MaToa varchar(20) NOT NULL REFERENCES ToaThuoc(MaToa),
 MaThuoc varchar(20) NOT NULL REFERENCES Thuoc(MaThuoc),
 SoLuong int NOT NULL CHECK(SoLuong>0),
 LieuDung nvarchar(150) NOT NULL CHECK(LEN(LTRIM(RTRIM(LieuDung)))>0),
 CachDung nvarchar(200) NOT NULL CHECK(LEN(LTRIM(RTRIM(CachDung)))>0),
 DonGiaApDung decimal(18,2) NOT NULL CHECK(DonGiaApDung>=0),
 ThanhTien AS (SoLuong*DonGiaApDung) PERSISTED,
 PRIMARY KEY(MaToa,MaThuoc)
);
CREATE TABLE HoaDonVienPhi(
 SoHoaDon varchar(20) PRIMARY KEY,
 MaPhieuKham varchar(20) NOT NULL UNIQUE
  REFERENCES PhieuKhamBenh(MaPhieuKham),
 NgayThanhToan datetime2 NULL,
 TongTienKham decimal(18,2) NOT NULL CHECK(TongTienKham>=0),
 TongTienXN decimal(18,2) NOT NULL CHECK(TongTienXN>=0),
 TongTienThuoc decimal(18,2) NOT NULL CHECK(TongTienThuoc>=0),
 MienGiam decimal(18,2) NOT NULL DEFAULT 0 CHECK(MienGiam>=0),
 TongThanhToan AS
  (TongTienKham+TongTienXN+TongTienThuoc-MienGiam) PERSISTED,
 DaThanhToan bit NOT NULL DEFAULT 0,
 CHECK(MienGiam<=TongTienKham+TongTienXN+TongTienThuoc),
 CHECK((DaThanhToan=0 AND NgayThanhToan IS NULL) OR
       (DaThanhToan=1 AND NgayThanhToan IS NOT NULL))
);
CREATE INDEX IX_Phieu_HoSo ON PhieuKhamBenh(MaHoSo,NgayGioKham);
CREATE INDEX IX_Phi_HieuLuc ON PhieuThuLePhi(MaHoSo,TuNgay,DenNgay);
GO

CREATE PROCEDURE dbo.sp_DangKyMoi
 @MaBN varchar(20), @MaHoSo varchar(20), @SoPhieuThu varchar(20),
 @HoTen nvarchar(120), @NgaySinh date, @DiaChi nvarchar(250),
 @DienThoai varchar(20), @Anh nvarchar(500), @SoTien decimal(18,2)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 DECLARE @Now datetime2=SYSDATETIME();
 IF @NgaySinh IS NULL OR @NgaySinh>CAST(@Now AS date)
  OR @SoTien IS NULL OR @SoTien<=0
  OR NULLIF(LTRIM(RTRIM(@HoTen)),N'') IS NULL
  OR NULLIF(LTRIM(RTRIM(@DiaChi)),N'') IS NULL
  OR NULLIF(LTRIM(RTRIM(@DienThoai)),'') IS NULL
  OR NULLIF(LTRIM(RTRIM(@Anh)),N'') IS NULL
  THROW 50001,N'Thong tin dang ky hoac le phi khong hop le.',1;
 BEGIN TRY
  BEGIN TRAN;
  INSERT BenhNhan VALUES(@MaBN,@HoTen,@NgaySinh,@DiaChi,@DienThoai,@Anh);
  INSERT HoSoBenhAn VALUES(@MaHoSo,@MaBN,@Now,'HoatDong');
  INSERT PhieuThuLePhi VALUES(@SoPhieuThu,@MaHoSo,@Now,@SoTien,
   YEAR(@Now),@Now,DATEADD(day,365,@Now));
  COMMIT;
 END TRY
 BEGIN CATCH
  IF XACT_STATE()<>0 ROLLBACK;
  THROW;
 END CATCH
END;
GO

CREATE TYPE dbo.DongToaThuoc AS TABLE(
 MaThuoc varchar(20) PRIMARY KEY, SoLuong int NOT NULL,
 LieuDung nvarchar(150) NOT NULL, CachDung nvarchar(200) NOT NULL
);
GO
CREATE PROCEDURE dbo.sp_LapToaThuoc
 @MaToa varchar(20), @MaPhieuKham varchar(20), @MaBS varchar(20),
 @DanDo nvarchar(1000), @Dong dbo.DongToaThuoc READONLY
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  IF NOT EXISTS(SELECT 1 FROM PhieuKhamBenh WITH(UPDLOCK,HOLDLOCK)
   WHERE MaPhieuKham=@MaPhieuKham AND MaBS=@MaBS
    AND TrangThai='DangXuLy'
    AND NULLIF(LTRIM(RTRIM(ChanDoan)),N'') IS NOT NULL)
   THROW 50002,N'Phieu, bac si hoac chan doan khong hop le.',1;
  IF NOT EXISTS(SELECT 1 FROM @Dong)
   OR EXISTS(SELECT 1 FROM @Dong d LEFT JOIN Thuoc t WITH(HOLDLOCK)
    ON t.MaThuoc=d.MaThuoc
    WHERE t.MaThuoc IS NULL OR t.DangSuDung=0 OR d.SoLuong<=0
     OR LEN(LTRIM(RTRIM(d.LieuDung)))=0
     OR LEN(LTRIM(RTRIM(d.CachDung)))=0)
   THROW 50003,N'Danh sach thuoc khong hop le.',1;
  INSERT ToaThuoc(MaToa,MaPhieuKham,MaBS,NgayLap,DanDoBacSi)
   VALUES(@MaToa,@MaPhieuKham,@MaBS,SYSDATETIME(),@DanDo);
  INSERT ChiTietToaThuoc
   (MaToa,MaThuoc,SoLuong,LieuDung,CachDung,DonGiaApDung)
   SELECT @MaToa,d.MaThuoc,d.SoLuong,d.LieuDung,d.CachDung,t.DonGia
   FROM @Dong d JOIN Thuoc t ON t.MaThuoc=d.MaThuoc;
  COMMIT;
 END TRY
 BEGIN CATCH
  IF XACT_STATE()<>0 ROLLBACK;
  THROW;
 END CATCH
END;
GO

CREATE PROCEDURE dbo.sp_DatLichHen
 @MaLichHen varchar(20), @MaHoSo varchar(20), @NgayHen datetime2
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  IF @NgayHen IS NULL OR @NgayHen<=SYSDATETIME()
   THROW 50004,N'Ngay hen phai o tuong lai.',1;
  IF NOT EXISTS(SELECT 1 FROM HoSoBenhAn WITH(UPDLOCK,HOLDLOCK)
   WHERE MaHoSo=@MaHoSo AND TrangThai='HoatDong')
   THROW 50005,N'Ho so khong hop le.',1;
  IF NOT EXISTS(SELECT 1 FROM PhieuThuLePhi
   WHERE MaHoSo=@MaHoSo AND TuNgay<=@NgayHen AND @NgayHen<DenNgay)
   THROW 50006,N'Le phi khong phu ngay hen.',1;
  INSERT LichHenDinhKy
   VALUES(@MaLichHen,@MaHoSo,@NgayHen,DATEPART(QUARTER,@NgayHen),
    YEAR(@NgayHen),'DaHen');
  COMMIT;
 END TRY
 BEGIN CATCH
  IF XACT_STATE()<>0 ROLLBACK;
  THROW;
 END CATCH
END;
GO

CREATE PROCEDURE dbo.sp_HoanTatPhieu
 @MaPhieuKham varchar(20), @NguoiXacNhan nvarchar(100)
AS
BEGIN
 SET NOCOUNT ON; SET XACT_ABORT ON;
 BEGIN TRY
  BEGIN TRAN;
  IF NULLIF(LTRIM(RTRIM(@NguoiXacNhan)),N'') IS NULL
   THROW 50007,N'Thieu nguoi xac nhan.',1;
  IF NOT EXISTS(SELECT 1 FROM PhieuKhamBenh WITH(UPDLOCK,HOLDLOCK)
   WHERE MaPhieuKham=@MaPhieuKham AND TrangThai='ChoThanhToan'
    AND NULLIF(LTRIM(RTRIM(ChanDoan)),N'') IS NOT NULL)
   THROW 50008,N'Phieu chua du dieu kien hoan tat.',1;
  IF EXISTS(SELECT 1 FROM ChiDinhXetNghiem
   WHERE MaPhieuKham=@MaPhieuKham AND TrangThai<>'DaCoKetQua')
   THROW 50009,N'Con xet nghiem chua co ket qua.',1;
  IF NOT EXISTS(SELECT 1 FROM HoaDonVienPhi WITH(UPDLOCK,HOLDLOCK)
   WHERE MaPhieuKham=@MaPhieuKham AND DaThanhToan=1)
   THROW 50010,N'Chua thanh toan hoac xac nhan mien phi.',1;
  IF EXISTS(SELECT 1 FROM ToaThuoc
   WHERE MaPhieuKham=@MaPhieuKham AND DaPhat=0)
   THROW 50011,N'Toa thuoc chua duoc xac nhan phat.',1;
  UPDATE PhieuKhamBenh SET TrangThai='HoanTat',
   NgayHoanTat=SYSDATETIME(),NguoiHoanTat=@NguoiXacNhan
   WHERE MaPhieuKham=@MaPhieuKham;
  COMMIT;
 END TRY
 BEGIN CATCH
  IF XACT_STATE()<>0 ROLLBACK;
  THROW;
 END CATCH
END;
GO


-- 1. THÊM DANH MỤC BÁC SĨ (BacSi)
INSERT INTO BacSi (MaBS, HoTen, ChuyenKhoa, DienThoai) VALUES
('BS01', N'Trần Văn An', N'Nội tổng quát', '0901234567'),
('BS02', N'Lê Thị Bình', N'Tim mạch', '0912345678'),
('BS03', N'Phạm Minh Cường', N'Tai Mũi Họng', '0923456789'),
('BS04', N'Nguyễn Thanh Dũng', N'Nhi khoa', '0934567890');

-- 2. THÊM DANH MỤC KHOA ĐIỀU TRỊ (KhoaDieuTri)
INSERT INTO KhoaDieuTri (MaKhoa, TenKhoa, PhongKham) VALUES
('K01', N'Khoa Nội Tổng Hợp', N'Phòng 101 - Lầu 1'),
('K02', N'Khoa Tim Mạch', N'Phòng 202 - Lầu 2'),
('K03', N'Khoa Tai Mũi Họng', N'Phòng 105 - Lầu 1'),
('K04', N'Khoa Khám Bệnh Định Kỳ', N'Phòng 301 - Lầu 3');

-- 3. THÊM DANH MỤC XÉT NGHIỆM (XetNghiem)
INSERT INTO XetNghiem (MaXetNghiem, TenXetNghiem, DonGia) VALUES
('XN01', N'Xét nghiệm Công thức máu toàn phần (CBC)', 120000.00),
('XN02', N'Xét nghiệm Đường huyết lúc đói (Glucose)', 80000.00),
('XN03', N'Chụp X-quang Phổi thẳng', 150000.00),
('XN04', N'Siêu âm Tim màu', 350000.00);

-- 4. THÊM DANH MỤC THUỐC (Thuoc)
INSERT INTO Thuoc (MaThuoc, TenThuoc, DonViTinh, DonGia, DangSuDung) VALUES
('T01', N'Paracetamol 500mg', N'Viên', 1500.00, 1),
('T02', N'Amoxicillin 500mg', N'Viên', 3000.00, 1),
('T03', N'Amlodipine 5mg', N'Viên', 2500.00, 1),
('T04', N'Siro Ho Prospan 100ml', N'Chai', 75000.00, 1),
('T05', N'Vitamin C 500mg', N'Viên', 1000.00, 1);
GO

-- 5. ĐĂNG KÝ BỆNH NHÂN MỚI & THU LỆ PHÍ NĂM QUA STORED PROCEDURE (sp_DangKyMoi)
-- Đăng ký Bệnh nhân 1
EXEC dbo.sp_DangKyMoi 
    @MaBN = 'BN01', 
    @MaHoSo = 'HS01', 
    @SoPhieuThu = 'PT01', 
    @HoTen = N'Nguyễn Văn Hùng', 
    @NgaySinh = '1985-05-15', 
    @DiaChi = N'123 Nguyễn Văn Cừ, Q.5, TP.HCM', 
    @DienThoai = '0987654321', 
    @Anh = N'/images/patients/BN01.jpg', 
    @SoTien = 200000.00;

-- Đăng ký Bệnh nhân 2
EXEC dbo.sp_DangKyMoi 
    @MaBN = 'BN02', 
    @MaHoSo = 'HS02', 
    @SoPhieuThu = 'PT02', 
    @HoTen = N'Trần Thị Mai', 
    @NgaySinh = '1992-09-20', 
    @DiaChi = N'456 Lê Văn Sỹ, Q.3, TP.HCM', 
    @DienThoai = '0976543210', 
    @Anh = N'/images/patients/BN02.jpg', 
    @SoTien = 200000.00;
GO

-- 6. ĐẶT LỊCH HẸN KHÁM ĐỊNH KỲ THEO QUÝ QUA STORED PROCEDURE (sp_DatLichHen)
-- Đặt lịch hẹn khám định kỳ Quý 4/2026 cho HS01
EXEC dbo.sp_DatLichHen 
    @MaLichHen = 'LH01', 
    @MaHoSo = 'HS01', 
    @NgayHen = '2026-10-25 08:30:00';
GO

-- 7. THÊM PHIẾU KHÁM BỆNH (PhieuKhamBenh)
-- Phiếu 1: Khám thường cho HS01
INSERT INTO PhieuKhamBenh (
    MaPhieuKham, MaHoSo, MaBS, MaKhoa, MaLichHen, NgayGioKham, 
    TrieuChung, ThanNhiet, HuyetAp, ChanDoan, DienBien, PhanUngPhu, 
    LoaiKham, TrangThai
) VALUES (
    'PK01', 'HS01', 'BS01', 'K01', NULL, '2026-10-18 09:00:00',
    N'Sốt nhẹ, ho kéo dài, mệt mỏi', 38.2, '120/80', N'Viêm phế quản cấp', 
    N'Bệnh nhân tỉnh táo, họng đỏ', N'Không có tiền sử dị ứng',
    'Thuong', 'ChoThanhToan'
);

-- Phiếu 2: Khám định kỳ cho HS01 (Gắn với Lịch hẹn LH01)
INSERT INTO PhieuKhamBenh (
    MaPhieuKham, MaHoSo, MaBS, MaKhoa, MaLichHen, NgayGioKham, 
    TrieuChung, ThanNhiet, HuyetAp, ChanDoan, DienBien, PhanUngPhu, 
    LoaiKham, TrangThai
) VALUES (
    'PK02', 'HS01', 'BS02', 'K04', 'LH01', '2026-10-25 08:30:00',
    N'Khám sức khỏe định kỳ quý IV', 36.6, '115/75', N'Sức khỏe bình thường, huyết áp ổn định', 
    N'Thể trạng tốt', N'Không',
    'DinhKy', 'ChoThanhToan'
);

-- Cập nhật trạng thái Lịch hẹn sang 'DaKham' sau khi tạo phiếu khám định kỳ
UPDATE LichHenDinhKy SET TrangThai = 'DaKham' WHERE MaLichHen = 'LH01';
GO

-- 8. THÊM CHỈ ĐỊNH XÉT NGHIỆM (ChiDinhXetNghiem)
INSERT INTO ChiDinhXetNghiem (
    MaPhieuKham, MaXetNghiem, NgayChiDinh, DonGiaApDung, KetQua, NgayThucHien, TrangThai
) VALUES 
('PK01', 'XN01', '2026-10-18 09:15:00', 120000.00, N'Bạch cầu tăng nhẹ (11.2 K/uL)', '2026-10-18 10:00:00', 'DaCoKetQua'),
('PK01', 'XN03', '2026-10-18 09:15:00', 150000.00, N'Rốn phổi đậm, không thấy tổn thương xơ rãnh', '2026-10-18 10:30:00', 'DaCoKetQua');
GO

-- 9. LẬP TOA THUỐC QUA STORED PROCEDURE (sp_LapToaThuoc)
-- Chuẩn bị bảng tạm cho danh sách thuốc kê cho PK01
DECLARE @ToaThuocTab dbo.DongToaThuoc;

INSERT INTO @ToaThuocTab (MaThuoc, SoLuong, LieuDung, CachDung) VALUES
('T01', 20, N'Ngày 3 lần, lần 1 viên', N'Uống sau khi ăn khi sốt trên 38.5 độ'),
('T02', 14, N'Ngày 2 lần, lần 1 viên', N'Uống sáng và chiều sau ăn 30 phút');

EXEC dbo.sp_LapToaThuoc 
    @MaToa = 'TOA01', 
    @MaPhieuKham = 'PK01', 
    @MaBS = 'BS01', 
    @DanDo = N'Uống nhiều nước ấm, nghỉ ngơi, tái khám nếu sốt cao liên tục.', 
    @Dong = @ToaThuocTab;
GO

-- 10. THÊM HÓA ĐƠN VIỆN PHÍ (HoaDonVienPhi)
-- Hóa đơn PK01 (Khám thường): Tiền khám (100.000) + XN (270.000) + Thuốc (72.000) = 442.000đ
INSERT INTO HoaDonVienPhi (
    SoHoaDon, MaPhieuKham, NgayThanhToan, TongTienKham, TongTienXN, TongTienThuoc, MienGiam, DaThanhToan
) VALUES (
    'HD01', 'PK01', '2026-10-18 11:00:00', 100000.00, 270000.00, 72000.00, 0.00, 1
);

-- Hóa đơn PK02 (Khám định kỳ): Tiền khám (100.000) được Miễn giảm (100.000) -> Tổng = 0đ
INSERT INTO HoaDonVienPhi (
    SoHoaDon, MaPhieuKham, NgayThanhToan, TongTienKham, TongTienXN, TongTienThuoc, MienGiam, DaThanhToan
) VALUES (
    'HD02', 'PK02', '2026-10-25 09:00:00', 100000.00, 0.00, 0.00, 100000.00, 1
);

-- Xác nhận Phát thuốc cho TOA01 sau khi đã thanh toán HD01
UPDATE ToaThuoc 
SET DaPhat = 1, NgayPhat = '2026-10-18 11:15:00' 
WHERE MaToa = 'TOA01';
GO

-- 11. HOÀN TẤT VÀ CHỐT HỒ SƠ QUA STORED PROCEDURE (sp_HoanTatPhieu)
EXEC dbo.sp_HoanTatPhieu 
    @MaPhieuKham = 'PK01', 
    @NguoiXacNhan = N'NV_NguyenThiHoa';

EXEC dbo.sp_HoanTatPhieu 
    @MaPhieuKham = 'PK02', 
    @NguoiXacNhan = N'NV_NguyenThiHoa';
GO


SELECT * FROM BenhNhan;
SELECT * FROM HoSoBenhAn;
SELECT * FROM PhieuThuLePhi;
SELECT * FROM PhieuKhamBenh;
SELECT * FROM ChiDinhXetNghiem;
SELECT * FROM ToaThuoc;
SELECT * FROM ChiTietToaThuoc;
SELECT * FROM HoaDonVienPhi;

