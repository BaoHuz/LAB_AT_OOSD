
IF DB_ID(N'QuanLyChoThueVanPhong') IS NULL CREATE DATABASE QuanLyChoThueVanPhong;
GO
USE QuanLyChoThueVanPhong;
GO


IF OBJECT_ID('sp_GiaHanVanPhong','P') IS NOT NULL DROP PROCEDURE sp_GiaHanVanPhong;
IF OBJECT_ID('sp_LapHoaDonDichVuThang','P') IS NOT NULL DROP PROCEDURE sp_LapHoaDonDichVuThang;
IF OBJECT_ID('sp_LapHopDongVaThu6Thang','P') IS NOT NULL DROP PROCEDURE sp_LapHopDongVaThu6Thang;
IF TYPE_ID('dbo.VanPhongThueType') IS NOT NULL DROP TYPE dbo.VanPhongThueType;
GO

DROP TABLE IF EXISTS KiemTraPhong;
DROP TABLE IF EXISTS TheGiuXe;
DROP TABLE IF EXISTS NhanVienVanPhong;
DROP TABLE IF EXISTS PhieuGiaHan;
DROP TABLE IF EXISTS ThanhToanDichVu;
DROP TABLE IF EXISTS ChiTietHoaDonDichVu;
DROP TABLE IF EXISTS HoaDonDichVu;
DROP TABLE IF EXISTS SuDungDichVu;
DROP TABLE IF EXISTS DichVu;
DROP TABLE IF EXISTS ThanhToanTienThue;
DROP TABLE IF EXISTS ChiTietHopDong;
DROP TABLE IF EXISTS HopDongThue;
DROP TABLE IF EXISTS KhachHang;
DROP TABLE IF EXISTS VanPhong;
DROP TABLE IF EXISTS Tang;
GO

CREATE TABLE Tang(
    MaTang varchar(20) NOT NULL PRIMARY KEY,
    TenTang nvarchar(80) NOT NULL UNIQUE,
    SoThuTu int NOT NULL UNIQUE CHECK(SoThuTu > 0),
    GhiChu nvarchar(300) NULL
);

CREATE TABLE VanPhong(
    MaVP varchar(20) NOT NULL PRIMARY KEY,
    MaTang varchar(20) NOT NULL,
    TenPhong nvarchar(80) NOT NULL,
    DienTichSuDung decimal(10,2) NOT NULL CHECK(DienTichSuDung > 0),
    Huong nvarchar(50) NOT NULL,
    DonGiaThang decimal(18,2) NOT NULL CHECK(DonGiaThang > 0),
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Trống',
    CONSTRAINT UQ_VanPhong_Tang_Ten UNIQUE(MaTang, TenPhong),
    CONSTRAINT FK_VanPhong_Tang FOREIGN KEY(MaTang) REFERENCES Tang(MaTang),
    CONSTRAINT CK_VanPhong_TrangThai CHECK(TrangThai IN (N'Trống',N'Đang thuê',N'Bảo trì'))
);

CREATE TABLE KhachHang(
    MaKH varchar(20) NOT NULL PRIMARY KEY,
    TenKhachHang nvarchar(180) NOT NULL,
    LoaiKhach nvarchar(30) NOT NULL DEFAULT N'Doanh nghiệp',
    MaSoThue varchar(30) NULL,
    DiaChi nvarchar(300) NOT NULL,
    DienThoai varchar(20) NOT NULL,
    Email varchar(160) NULL,
    CONSTRAINT UQ_KhachHang_MST UNIQUE(MaSoThue),
    CONSTRAINT CK_KhachHang_Loai CHECK(LoaiKhach IN (N'Cá nhân',N'Doanh nghiệp'))
);

CREATE TABLE HopDongThue(
    MaHD varchar(20) NOT NULL PRIMARY KEY,
    MaKH varchar(20) NOT NULL,
    NgayKy date NOT NULL,
    NgayBatDau date NOT NULL,
    SoThangThue int NOT NULL CHECK(SoThangThue >= 6),
    NgayKetThuc date NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Hiệu lực',
    GhiChu nvarchar(500) NULL,
    CONSTRAINT FK_HopDong_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT CK_HopDong_Ngay CHECK(NgayKetThuc >= NgayBatDau),
    CONSTRAINT CK_HopDong_TrangThai CHECK(TrangThai IN (N'Hiệu lực',N'Hết hạn',N'Đã hủy'))
);

CREATE TABLE ChiTietHopDong(
    MaHD varchar(20) NOT NULL,
    MaVP varchar(20) NOT NULL,
    DonGiaThang decimal(18,2) NOT NULL CHECK(DonGiaThang > 0),
    NgayBatDau date NOT NULL,
    NgayKetThuc date NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đang thuê',
    PRIMARY KEY(MaHD, MaVP),
    CONSTRAINT FK_CTHD_HD FOREIGN KEY(MaHD) REFERENCES HopDongThue(MaHD),
    CONSTRAINT FK_CTHD_VP FOREIGN KEY(MaVP) REFERENCES VanPhong(MaVP),
    CONSTRAINT CK_CTHD_Ngay CHECK(NgayKetThuc >= NgayBatDau),
    CONSTRAINT CK_CTHD_TrangThai CHECK(TrangThai IN (N'Đang thuê',N'Kết thúc'))
);

CREATE TABLE ThanhToanTienThue(
    SoTT varchar(20) NOT NULL PRIMARY KEY,
    MaHD varchar(20) NOT NULL,
    KyTuThang int NOT NULL CHECK(KyTuThang >= 1),
    KyDenThang int NOT NULL CHECK(KyDenThang >= KyTuThang),
    NgayDenHan date NOT NULL,
    NgayThanhToan date NULL,
    SoTien decimal(18,2) NOT NULL CHECK(SoTien > 0),
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chưa thanh toán',
    GhiChu nvarchar(300) NULL,
    CONSTRAINT UQ_TTT_Ky UNIQUE(MaHD, KyTuThang, KyDenThang),
    CONSTRAINT FK_TTT_HD FOREIGN KEY(MaHD) REFERENCES HopDongThue(MaHD),
    CONSTRAINT CK_TTT_TrangThai CHECK(TrangThai IN (N'Chưa thanh toán',N'Đã thanh toán')),
    CONSTRAINT CK_TTT_Ngay CHECK(NgayThanhToan IS NULL OR NgayThanhToan >= DATEADD(day,-30,NgayDenHan))
);

CREATE TABLE DichVu(
    MaDV varchar(20) NOT NULL PRIMARY KEY,
    TenDV nvarchar(120) NOT NULL UNIQUE,
    DonViTinh nvarchar(40) NOT NULL,
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    DangSuDung bit NOT NULL DEFAULT 1
);

CREATE TABLE SuDungDichVu(
    MaSD varchar(20) NOT NULL PRIMARY KEY,
    MaHD varchar(20) NOT NULL,
    MaVP varchar(20) NOT NULL,
    MaDV varchar(20) NOT NULL,
    ThangSuDung date NOT NULL,
    SoLuong decimal(18,2) NOT NULL CHECK(SoLuong >= 0),
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    ThanhTien AS CAST(SoLuong * DonGia AS decimal(18,2)) PERSISTED,
    CONSTRAINT UQ_SDDV UNIQUE(MaHD,MaVP,MaDV,ThangSuDung),
    CONSTRAINT FK_SDDV_CTHD FOREIGN KEY(MaHD,MaVP) REFERENCES ChiTietHopDong(MaHD,MaVP),
    CONSTRAINT FK_SDDV_DV FOREIGN KEY(MaDV) REFERENCES DichVu(MaDV),
    CONSTRAINT CK_SDDV_Thang CHECK(DAY(ThangSuDung)=1)
);

CREATE TABLE HoaDonDichVu(
    MaHDDV varchar(20) NOT NULL PRIMARY KEY,
    MaHD varchar(20) NOT NULL,
    ThangSuDung date NOT NULL,
    NgayLap date NOT NULL,
    TongTien decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTien >= 0),
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chưa thanh toán',
    CONSTRAINT UQ_HDDV_Thang UNIQUE(MaHD,ThangSuDung),
    CONSTRAINT FK_HDDV_HD FOREIGN KEY(MaHD) REFERENCES HopDongThue(MaHD),
    CONSTRAINT CK_HDDV_Thang CHECK(DAY(ThangSuDung)=1),
    CONSTRAINT CK_HDDV_TrangThai CHECK(TrangThai IN (N'Chưa thanh toán',N'Đã thanh toán'))
);

CREATE TABLE ChiTietHoaDonDichVu(
    MaHDDV varchar(20) NOT NULL,
    MaSD varchar(20) NOT NULL,
    ThanhTien decimal(18,2) NOT NULL CHECK(ThanhTien >= 0),
    PRIMARY KEY(MaHDDV,MaSD),
    CONSTRAINT FK_CTHDDV_HD FOREIGN KEY(MaHDDV) REFERENCES HoaDonDichVu(MaHDDV),
    CONSTRAINT FK_CTHDDV_SD FOREIGN KEY(MaSD) REFERENCES SuDungDichVu(MaSD)
);

CREATE TABLE ThanhToanDichVu(
    SoTTDV varchar(20) NOT NULL PRIMARY KEY,
    MaHDDV varchar(20) NOT NULL,
    NgayThanhToan date NOT NULL,
    SoTien decimal(18,2) NOT NULL CHECK(SoTien > 0),
    GhiChu nvarchar(300) NULL,
    CONSTRAINT FK_TTDV_HDDV FOREIGN KEY(MaHDDV) REFERENCES HoaDonDichVu(MaHDDV)
);

CREATE TABLE PhieuGiaHan(
    MaGH varchar(20) NOT NULL PRIMARY KEY,
    MaHD varchar(20) NOT NULL,
    MaVP varchar(20) NOT NULL,
    NgayLap date NOT NULL,
    SoThangGiaHan int NOT NULL CHECK(SoThangGiaHan > 0),
    TuNgay date NOT NULL,
    DenNgay date NOT NULL,
    GhiChu nvarchar(300) NULL,
    CONSTRAINT UQ_GiaHan UNIQUE(MaHD,MaVP,TuNgay),
    CONSTRAINT FK_GH_CTHD FOREIGN KEY(MaHD,MaVP) REFERENCES ChiTietHopDong(MaHD,MaVP),
    CONSTRAINT CK_GH_Ngay CHECK(DenNgay >= TuNgay)
);

CREATE TABLE NhanVienVanPhong(
    MaNV varchar(20) NOT NULL PRIMARY KEY,
    MaKH varchar(20) NOT NULL,
    MaVP varchar(20) NOT NULL,
    HoTen nvarchar(150) NOT NULL,
    ChucVu nvarchar(120) NULL,
    HinhAnh varbinary(max) NULL,
    NgayBatDau date NULL,
    DangLamViec bit NOT NULL DEFAULT 1,
    CONSTRAINT FK_NVVP_KH FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_NVVP_VP FOREIGN KEY(MaVP) REFERENCES VanPhong(MaVP)
);

CREATE TABLE TheGiuXe(
    MaThe varchar(20) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL UNIQUE,
    BienSoXe varchar(20) NOT NULL UNIQUE,
    LoaiXe nvarchar(80) NOT NULL,
    MauXe nvarchar(50) NULL,
    NgayCap date NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Hoạt động',
    CONSTRAINT FK_The_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVienVanPhong(MaNV),
    CONSTRAINT CK_The_TrangThai CHECK(TrangThai IN (N'Hoạt động',N'Khóa',N'Đã thu hồi'))
);

CREATE TABLE KiemTraPhong(
    MaKT varchar(20) NOT NULL PRIMARY KEY,
    MaVP varchar(20) NOT NULL,
    NgayKiemTra date NOT NULL,
    TinhTrang nvarchar(1000) NOT NULL,
    CoThayDoiKetCau bit NOT NULL DEFAULT 0,
    MucPhat decimal(18,2) NULL CHECK(MucPhat IS NULL OR MucPhat >= 0),
    KienNghiSuaChua nvarchar(1000) NULL,
    NguoiKiemTra nvarchar(150) NOT NULL,
    CONSTRAINT FK_KT_VP FOREIGN KEY(MaVP) REFERENCES VanPhong(MaVP)
);
GO

CREATE INDEX IX_CTHD_VP_Ngay ON ChiTietHopDong(MaVP,NgayBatDau,NgayKetThuc);
CREATE INDEX IX_TTT_HD_TrangThai ON ThanhToanTienThue(MaHD,TrangThai);
CREATE INDEX IX_HDDV_HD_TrangThai ON HoaDonDichVu(MaHD,TrangThai);
CREATE INDEX IX_KT_VP_Ngay ON KiemTraPhong(MaVP,NgayKiemTra DESC);
GO

CREATE TYPE dbo.VanPhongThueType AS TABLE(
    MaVP varchar(20) NOT NULL PRIMARY KEY,
    DonGiaThang decimal(18,2) NOT NULL CHECK(DonGiaThang > 0)
);
GO

CREATE PROCEDURE sp_LapHopDongVaThu6Thang
    @MaHD varchar(20),
    @MaKH varchar(20),
    @NgayKy date,
    @NgayBatDau date,
    @SoThangThue int,
    @GhiChu nvarchar(500) = NULL,
    @DanhSachVP dbo.VanPhongThueType READONLY
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    IF @SoThangThue < 6 THROW 50001, N'Thời gian thuê tối thiểu là 6 tháng.', 1;
    IF NOT EXISTS(SELECT 1 FROM @DanhSachVP) THROW 50002, N'Hợp đồng phải có ít nhất một văn phòng.', 1;

    DECLARE @NgayKetThuc date = DATEADD(day,-1,DATEADD(month,@SoThangThue,@NgayBatDau));
    DECLARE @Tong6Thang decimal(18,2) = (SELECT SUM(DonGiaThang) * 6 FROM @DanhSachVP);

    IF EXISTS(
        SELECT 1 FROM @DanhSachVP x
        JOIN ChiTietHopDong c ON c.MaVP=x.MaVP AND c.TrangThai=N'Đang thuê'
        WHERE c.NgayBatDau <= @NgayKetThuc AND c.NgayKetThuc >= @NgayBatDau
    ) THROW 50003, N'Có văn phòng đã được thuê trong khoảng thời gian này.', 1;

    BEGIN TRAN;
    BEGIN TRY
        INSERT INTO HopDongThue(MaHD,MaKH,NgayKy,NgayBatDau,SoThangThue,NgayKetThuc,TrangThai,GhiChu)
        VALUES(@MaHD,@MaKH,@NgayKy,@NgayBatDau,@SoThangThue,@NgayKetThuc,N'Hiệu lực',@GhiChu);

        INSERT INTO ChiTietHopDong(MaHD,MaVP,DonGiaThang,NgayBatDau,NgayKetThuc,TrangThai)
        SELECT @MaHD,MaVP,DonGiaThang,@NgayBatDau,@NgayKetThuc,N'Đang thuê' FROM @DanhSachVP;

        UPDATE v SET TrangThai=N'Đang thuê'
        FROM VanPhong v JOIN @DanhSachVP x ON v.MaVP=x.MaVP;

        INSERT INTO ThanhToanTienThue(SoTT,MaHD,KyTuThang,KyDenThang,NgayDenHan,NgayThanhToan,SoTien,TrangThai,GhiChu)
        VALUES('TT-'+@MaHD+'-01',@MaHD,1,6,@NgayKy,@NgayKy,@Tong6Thang,N'Đã thanh toán',N'Trả trước tiền thuê 6 tháng đầu');

        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END;
GO


CREATE PROCEDURE sp_LapHoaDonDichVuThang
    @MaHDDV varchar(20),
    @MaHD varchar(20),
    @ThangSuDung date,
    @NgayLap date
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;
    SET @ThangSuDung = DATEFROMPARTS(YEAR(@ThangSuDung),MONTH(@ThangSuDung),1);
    IF EXISTS(SELECT 1 FROM HoaDonDichVu WHERE MaHD=@MaHD AND ThangSuDung=@ThangSuDung)
        THROW 50011, N'Tháng này đã có hóa đơn dịch vụ.', 1;

    BEGIN TRAN;
    BEGIN TRY
        INSERT INTO HoaDonDichVu(MaHDDV,MaHD,ThangSuDung,NgayLap,TongTien,TrangThai)
        VALUES(@MaHDDV,@MaHD,@ThangSuDung,@NgayLap,0,N'Chưa thanh toán');

        INSERT INTO ChiTietHoaDonDichVu(MaHDDV,MaSD,ThanhTien)
        SELECT @MaHDDV,MaSD,ThanhTien
        FROM SuDungDichVu
        WHERE MaHD=@MaHD AND ThangSuDung=@ThangSuDung;

        UPDATE HoaDonDichVu
        SET TongTien = ISNULL((SELECT SUM(ThanhTien) FROM ChiTietHoaDonDichVu WHERE MaHDDV=@MaHDDV),0)
        WHERE MaHDDV=@MaHDDV;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END;
GO


CREATE PROCEDURE sp_GiaHanVanPhong
    @MaGH varchar(20),
    @MaHD varchar(20),
    @MaVP varchar(20),
    @NgayLap date,
    @SoThangGiaHan int,
    @GhiChu nvarchar(300)=NULL
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    DECLARE @SoThangGoc int, @NgayKetThucCu date, @DaGiaHan int, @TuNgay date, @DenNgay date;
    SELECT @SoThangGoc=h.SoThangThue, @NgayKetThucCu=c.NgayKetThuc
    FROM HopDongThue h JOIN ChiTietHopDong c ON h.MaHD=c.MaHD
    WHERE h.MaHD=@MaHD AND c.MaVP=@MaVP AND h.TrangThai=N'Hiệu lực';
    IF @SoThangGoc IS NULL THROW 50021, N'Không tìm thấy văn phòng đang thuê trong hợp đồng.', 1;

    SELECT @DaGiaHan=ISNULL(SUM(SoThangGiaHan),0) FROM PhieuGiaHan WHERE MaHD=@MaHD AND MaVP=@MaVP;
    IF @SoThangGiaHan <= 0 OR @DaGiaHan + @SoThangGiaHan > FLOOR(@SoThangGoc/2.0)
        THROW 50022, N'Tổng thời gian gia hạn vượt quá 1/2 thời gian thuê ban đầu.', 1;

    IF EXISTS(SELECT 1 FROM ThanhToanTienThue WHERE MaHD=@MaHD AND TrangThai<>N'Đã thanh toán')
        THROW 50023, N'Hợp đồng còn nợ tiền thuê.', 1;
    IF EXISTS(SELECT 1 FROM HoaDonDichVu WHERE MaHD=@MaHD AND TrangThai<>N'Đã thanh toán')
        THROW 50024, N'Hợp đồng còn nợ dịch vụ.', 1;

    SET @TuNgay = DATEADD(day,1,@NgayKetThucCu);
    SET @DenNgay = DATEADD(day,-1,DATEADD(month,@SoThangGiaHan,@TuNgay));

    IF EXISTS(
        SELECT 1 FROM ChiTietHopDong c
        WHERE c.MaVP=@MaVP AND c.MaHD<>@MaHD AND c.TrangThai=N'Đang thuê'
          AND c.NgayBatDau <= @DenNgay AND c.NgayKetThuc >= @TuNgay
    ) THROW 50025, N'Văn phòng đã được bố trí cho hợp đồng khác trong thời gian gia hạn.', 1;

    BEGIN TRAN;
    BEGIN TRY
        INSERT INTO PhieuGiaHan(MaGH,MaHD,MaVP,NgayLap,SoThangGiaHan,TuNgay,DenNgay,GhiChu)
        VALUES(@MaGH,@MaHD,@MaVP,@NgayLap,@SoThangGiaHan,@TuNgay,@DenNgay,@GhiChu);

        UPDATE ChiTietHopDong SET NgayKetThuc=@DenNgay WHERE MaHD=@MaHD AND MaVP=@MaVP;
        UPDATE HopDongThue
        SET NgayKetThuc=(SELECT MAX(NgayKetThuc) FROM ChiTietHopDong WHERE MaHD=@MaHD)
        WHERE MaHD=@MaHD;
        COMMIT;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK;
        THROW;
    END CATCH
END;
GO


INSERT INTO Tang(MaTang,TenTang,SoThuTu,GhiChu) VALUES
('T01',N'Tầng 1',1,N'Sảnh và văn phòng nhỏ'),
('T02',N'Tầng 2',2,NULL),
('T03',N'Tầng 3',3,NULL),
('T04',N'Tầng 4',4,NULL),
('T05',N'Tầng 5',5,N'Tầng cao, hướng nhìn thoáng');

INSERT INTO VanPhong(MaVP,MaTang,TenPhong,DienTichSuDung,Huong,DonGiaThang,TrangThai) VALUES
('VP101','T01',N'P101',45,N'Đông',18000000,N'Trống'),
('VP201','T02',N'P201',80,N'Nam',30000000,N'Trống'),
('VP202','T02',N'P202',60,N'Tây',24000000,N'Trống'),
('VP301','T03',N'P301',100,N'Đông Nam',42000000,N'Trống'),
('VP501','T05',N'P501',120,N'Nam',55000000,N'Trống');

INSERT INTO KhachHang(MaKH,TenKhachHang,LoaiKhach,MaSoThue,DiaChi,DienThoai,Email) VALUES
('KH001',N'Công ty CP Phần mềm Sao Việt',N'Doanh nghiệp','0310000001',N'Quận 3, TP.HCM','0283900001','contact@saoviet.local'),
('KH002',N'Công ty TNHH Thiết kế Mộc',N'Doanh nghiệp','0310000002',N'Thủ Đức, TP.HCM','0283900002','hello@moc.local');

DECLARE @VP dbo.VanPhongThueType;
INSERT INTO @VP VALUES ('VP201',30000000),('VP202',24000000);
EXEC sp_LapHopDongVaThu6Thang @MaHD='HD001',@MaKH='KH001',@NgayKy='20260101',@NgayBatDau='20260101',@SoThangThue=12,@DanhSachVP=@VP;

INSERT INTO ThanhToanTienThue(SoTT,MaHD,KyTuThang,KyDenThang,NgayDenHan,NgayThanhToan,SoTien,TrangThai,GhiChu) VALUES
('TT-HD001-07','HD001',7,7,'20260701','20260701',54000000,N'Đã thanh toán',N'Tiền thuê tháng 7'),
('TT-HD001-08','HD001',8,8,'20260801','20260801',54000000,N'Đã thanh toán',N'Tiền thuê tháng 8');

INSERT INTO DichVu(MaDV,TenDV,DonViTinh,DonGia,DangSuDung) VALUES
('DV01',N'Điện',N'kWh',3500,1),('DV02',N'Nước',N'm3',18000,1),('DV03',N'Internet',N'gói/tháng',1200000,1);

INSERT INTO SuDungDichVu(MaSD,MaHD,MaVP,MaDV,ThangSuDung,SoLuong,DonGia) VALUES
('SD001','HD001','VP201','DV01','20260801',820,3500),
('SD002','HD001','VP202','DV01','20260801',520,3500),
('SD003','HD001','VP201','DV02','20260801',25,18000),
('SD004','HD001','VP201','DV03','20260801',1,1200000);
EXEC sp_LapHoaDonDichVuThang 'HDDV001','HD001','20260801','20260831';
INSERT INTO ThanhToanDichVu(SoTTDV,MaHDDV,NgayThanhToan,SoTien,GhiChu)
SELECT 'TTDV001','HDDV001','20260831',TongTien,N'Thanh toán đủ dịch vụ tháng 8' FROM HoaDonDichVu WHERE MaHDDV='HDDV001';
UPDATE HoaDonDichVu SET TrangThai=N'Đã thanh toán' WHERE MaHDDV='HDDV001';

INSERT INTO NhanVienVanPhong(MaNV,MaKH,MaVP,HoTen,ChucVu,NgayBatDau,DangLamViec) VALUES
('NV001','KH001','VP201',N'Nguyễn Minh An',N'Trưởng nhóm','20260105',1),
('NV002','KH001','VP202',N'Trần Thu Bình',N'Kế toán','20260105',1);
INSERT INTO TheGiuXe(MaThe,MaNV,BienSoXe,LoaiXe,MauXe,NgayCap,TrangThai) VALUES
('THE001','NV001','59A1-123.45',N'Xe máy',N'Đen','20260105',N'Hoạt động'),
('THE002','NV002','59B2-234.56',N'Xe máy',N'Trắng','20260105',N'Hoạt động');

INSERT INTO KiemTraPhong(MaKT,MaVP,NgayKiemTra,TinhTrang,CoThayDoiKetCau,MucPhat,KienNghiSuaChua,NguoiKiemTra) VALUES
('KT001','VP201','20261220',N'Tường và trần tốt; hệ thống điện ổn định',0,NULL,N'Kiểm tra điều hòa định kỳ',N'Lê Văn Kỹ Thuật');
GO
