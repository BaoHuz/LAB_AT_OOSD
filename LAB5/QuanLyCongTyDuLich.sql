CREATE DATABASE QuanLyCongTyDuLich;
GO
USE QuanLyCongTyDuLich;
GO


CREATE TABLE Tour (
    MaTour VARCHAR(20) PRIMARY KEY,
    TenTour NVARCHAR(180) NOT NULL,
    SoNgay INT NOT NULL CHECK (SoNgay > 0),
    SoDem INT NOT NULL CHECK (SoDem >= 0),
    DonGiaKhach DECIMAL(18,2) NOT NULL CHECK (DonGiaKhach >= 0),
    MoTa NVARCHAR(1000) NULL,
    DangMoBan BIT NOT NULL DEFAULT 1
);

CREATE TABLE PhuongTien (
    MaPT VARCHAR(20) PRIMARY KEY,
    TenPT NVARCHAR(120) NOT NULL UNIQUE,
    GhiChu NVARCHAR(300) NULL
);

CREATE TABLE DiemThamQuan (
    MaDiemTQ VARCHAR(20) PRIMARY KEY,
    TenDiemTQ NVARCHAR(180) NOT NULL,
    DiaDiem NVARCHAR(250) NOT NULL,
    NoiDung NVARCHAR(1000) NULL,
    YNghia NVARCHAR(1000) NULL
);

CREATE TABLE DiemBanVe (
    MaDiemBan VARCHAR(20) PRIMARY KEY,
    TenDiemBan NVARCHAR(150) NOT NULL,
    DiaChi NVARCHAR(250) NOT NULL,
    DienThoai VARCHAR(20) NULL
);

CREATE TABLE HuongDanVien (
    MaHDV VARCHAR(20) PRIMARY KEY,
    HoTen NVARCHAR(120) NOT NULL,
    DienThoai VARCHAR(20) NULL,
    LuongCoBan DECIMAL(18,2) NOT NULL CHECK (LuongCoBan >= 0),
    DangLamViec BIT NOT NULL DEFAULT 1
);


CREATE TABLE TourDiemDung (
    MaTour VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Tour(MaTour),
    ThuTu INT NOT NULL CHECK (ThuTu > 0),
    TenDiemDung NVARCHAR(180) NOT NULL,
    DoiPhuongTien BIT NOT NULL DEFAULT 0,
    CoNoiAn BIT NOT NULL DEFAULT 0,
    CoKhachSan BIT NOT NULL DEFAULT 0,
    HangSaoKhachSan INT NULL CHECK (HangSaoKhachSan BETWEEN 2 AND 5),
    GhiChu NVARCHAR(500) NULL,
    PRIMARY KEY (MaTour, ThuTu),
    CONSTRAINT CK_TDD_KhachSan CHECK ((CoKhachSan = 0 AND HangSaoKhachSan IS NULL) OR (CoKhachSan = 1 AND HangSaoKhachSan BETWEEN 2 AND 5))
);

CREATE TABLE TourPhuongTien (
    MaTour VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Tour(MaTour),
    ThuTuChang INT NOT NULL CHECK (ThuTuChang > 0),
    MaPT VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES PhuongTien(MaPT),
    GhiChu NVARCHAR(300) NULL,
    PRIMARY KEY (MaTour, ThuTuChang, MaPT)
);

CREATE TABLE TourDiemThamQuan (
    MaTour VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Tour(MaTour),
    MaDiemTQ VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES DiemThamQuan(MaDiemTQ),
    ThuTu INT NOT NULL CHECK (ThuTu > 0),
    PRIMARY KEY (MaTour, MaDiemTQ),
    CONSTRAINT UQ_TDTQ UNIQUE (MaTour, ThuTu)
);


CREATE TABLE ChuyenLe (
    MaChuyen VARCHAR(20) PRIMARY KEY,
    MaTour VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Tour(MaTour),
    NgayDi DATE NOT NULL,
    NgayVe DATE NOT NULL,
    DiaDiemDon NVARCHAR(250) NOT NULL,
    TrangThai NVARCHAR(40) NOT NULL DEFAULT N'Mở đăng ký' CHECK (TrangThai IN (N'Mở đăng ký', N'Đóng đăng ký')),
    CONSTRAINT CK_Chuyen_Ngay CHECK (NgayVe >= NgayDi)
);

CREATE TABLE DangKyLe (
    SoDKLe VARCHAR(20) PRIMARY KEY,
    MaChuyen VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES ChuyenLe(MaChuyen),
    MaDiemBan VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES DiemBanVe(MaDiemBan),
    NgayDangKy DATETIME NOT NULL DEFAULT SYSDATETIME(),
    TenNguoiDangKy NVARCHAR(120) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL,
    SoNguoi INT NOT NULL CHECK (SoNguoi BETWEEN 1 AND 11),
    ThanhTien DECIMAL(18,2) NOT NULL CHECK (ThanhTien >= 0),
    DaThanhToan BIT NOT NULL DEFAULT 1 CHECK (DaThanhToan = 1),
    TrangThai NVARCHAR(40) NOT NULL DEFAULT N'Đã đăng ký'
);

CREATE TABLE DoanKhach (
    MaDoan VARCHAR(20) PRIMARY KEY,
    TenCoQuanDaiDien NVARCHAR(180) NOT NULL,
    DiaChi NVARCHAR(250) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL,
    NguoiDaiDien NVARCHAR(120) NOT NULL
);

CREATE TABLE DangKyDoan (
    SoDKDoan VARCHAR(20) PRIMARY KEY,
    MaDoan VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES DoanKhach(MaDoan),
    MaTour VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES Tour(MaTour),
    NgayDangKy DATETIME NOT NULL DEFAULT SYSDATETIME(),
    NgayDi DATE NOT NULL,
    NgayKetThucDuKien DATE NOT NULL,
    SoNguoi INT NOT NULL CHECK (SoNguoi > 12),
    DiaDiemDon NVARCHAR(250) NOT NULL,
    MuaBaoHiem BIT NOT NULL DEFAULT 0,
    TienCoc DECIMAL(18,2) NOT NULL CHECK (TienCoc > 0),
    DaThanhToanCoc BIT NOT NULL DEFAULT 1,
    TongTienDuKien DECIMAL(18,2) NOT NULL CHECK (TongTienDuKien >= 0),
    TrangThai NVARCHAR(40) NOT NULL DEFAULT N'Đã đăng ký' CHECK (TrangThai IN (N'Đã đăng ký', N'Hủy - mất cọc', N'Đã hoàn tất thanh toán')),
    CONSTRAINT CK_DKDoan_Coc CHECK (TienCoc <= TongTienDuKien),
    CONSTRAINT CK_DKDoan_Ngay CHECK (NgayKetThucDuKien >= NgayDi)
);

CREATE TABLE ThanhVienDoan (
    SoDKDoan VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES DangKyDoan(SoDKDoan),
    STT INT NOT NULL CHECK (STT > 0),
    HoTen NVARCHAR(120) NOT NULL,
    NgaySinh DATE NULL,
    SoGiayTo NVARCHAR(40) NULL,
    PRIMARY KEY (SoDKDoan, STT)
);


CREATE TABLE PhanCongHDV (
    MaPhanCong VARCHAR(20) PRIMARY KEY,
    MaHDV VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES HuongDanVien(MaHDV),
    LoaiPhanCong NVARCHAR(10) NOT NULL CHECK (LoaiPhanCong IN (N'LE', N'DOAN')),
    MaChuyen VARCHAR(20) NULL FOREIGN KEY REFERENCES ChuyenLe(MaChuyen),
    SoDKDoan VARCHAR(20) NULL FOREIGN KEY REFERENCES DangKyDoan(SoDKDoan),
    ThuLaoTour DECIMAL(18,2) NOT NULL DEFAULT 0 CHECK (ThuLaoTour >= 0),
    NgayPhanCong DATETIME NOT NULL DEFAULT SYSDATETIME(),
    CONSTRAINT CK_PC_Target CHECK ((LoaiPhanCong = N'LE' AND MaChuyen IS NOT NULL AND SoDKDoan IS NULL) OR 
                                  (LoaiPhanCong = N'DOAN' AND SoDKDoan IS NOT NULL AND MaChuyen IS NULL))
);

CREATE TABLE PhieuThanhToanDoan (
    SoPhieuTT VARCHAR(20) PRIMARY KEY,
    SoDKDoan VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES DangKyDoan(SoDKDoan),
    NgayThanhToan DATETIME NOT NULL DEFAULT SYSDATETIME(),
    SoTien DECIMAL(18,2) NOT NULL CHECK (SoTien > 0),
    GhiChu NVARCHAR(250) NULL
);

CREATE TABLE KhaoSatYKien (
    MaKhaoSat VARCHAR(20) PRIMARY KEY,
    LoaiKhach NVARCHAR(10) NOT NULL CHECK (LoaiKhach IN (N'LE', N'DOAN')),
    SoDKLe VARCHAR(20) NULL FOREIGN KEY REFERENCES DangKyLe(SoDKLe),
    SoDKDoan VARCHAR(20) NULL FOREIGN KEY REFERENCES DangKyDoan(SoDKDoan),
    NgayGui DATETIME NOT NULL DEFAULT SYSDATETIME(),
    NgayPhanHoi DATETIME NULL,
    DiemDanhGia INT NULL CHECK (DiemDanhGia BETWEEN 1 AND 5),
    YKienGopY NVARCHAR(MAX) NULL,
    TrangThai NVARCHAR(30) NOT NULL DEFAULT N'Đã gửi',
    CONSTRAINT CK_KS_PhanHoi CHECK (NgayPhanHoi IS NULL OR NgayPhanHoi >= NgayGui),
    CONSTRAINT CK_KS_Target CHECK ((LoaiKhach = N'LE' AND SoDKLe IS NOT NULL AND SoDKDoan IS NULL) OR 
                                  (LoaiKhach = N'DOAN' AND SoDKDoan IS NOT NULL AND SoDKLe IS NULL))
);


CREATE UNIQUE INDEX UX_KS_Le ON KhaoSatYKien (SoDKLe) WHERE SoDKLe IS NOT NULL;
CREATE UNIQUE INDEX UX_KS_Doan ON KhaoSatYKien (SoDKDoan) WHERE SoDKDoan IS NOT NULL;
CREATE INDEX IX_PC_HDV_Ngay ON PhanCongHDV(MaHDV, NgayPhanCong);
GO



INSERT INTO Tour (MaTour, TenTour, SoNgay, SoDem, DonGiaKhach, MoTa, DangMoBan) VALUES
('T001', N'Miền Tây 3 ngày 2 đêm', 3, 2, 2500000, N'TP.HCM - Mỹ Tho - Cần Thơ - TP.HCM', 1),
('T002', N'Đà Lạt 4 ngày 3 đêm', 4, 3, 3200000, N'TP.HCM - Đà Lạt - TP.HCM', 1),
('T003', N'Hà Nội - Hạ Long 5 ngày 4 đêm', 5, 4, 8900000, N'TP.HCM - Hà Nội - Hạ Long - TP.HCM', 1);


INSERT INTO PhuongTien (MaPT, TenPT, GhiChu) VALUES
('PT01', N'Xe du lịch', NULL),
('PT02', N'Máy bay', NULL),
('PT03', N'Tàu hỏa', NULL),
('PT04', N'Tàu thủy', NULL);


INSERT INTO DiemBanVe (MaDiemBan, TenDiemBan, DiaChi, DienThoai) VALUES
('DB01', N'Điểm bán Quận 1', N'12 Lê Lợi, Quận 1, TP.HCM', '0281000001'),
('DB02', N'Điểm bán Thủ Đức', N'5 Võ Văn Ngân, TP. Thủ Đức', '0281000002');


INSERT INTO HuongDanVien (MaHDV, HoTen, DienThoai, LuongCoBan, DangLamViec) VALUES
('HDV01', N'Nguyễn Minh Anh', '0903000001', 9000000, 1),
('HDV02', N'Trần Quốc Bình', '0903000002', 9500000, 1),
('HDV03', N'Lê Thu Cúc', '0903000003', 8500000, 1);


INSERT INTO DiemThamQuan (MaDiemTQ, TenDiemTQ, DiaDiem, NoiDung, YNghia) VALUES
('DTQ01', N'Chợ nổi Cái Răng', N'Cần Thơ', N'Tham quan chợ trên sông', N'Nét văn hóa sông nước miền Tây'),
('DTQ02', N'Chùa Vĩnh Tràng', N'Mỹ Tho, Tiền Giang', N'Tham quan kiến trúc chùa', N'Di tích kiến trúc nghệ thuật cấp quốc gia'),
('DTQ03', N'Hồ Xuân Hương', N'Đà Lạt', N'Dạo quanh hồ trung tâm', N'Biểu tượng thành phố Đà Lạt'),
('DTQ04', N'Vịnh Hạ Long', N'Quảng Ninh', N'Du thuyền tham quan vịnh', N'Di sản thiên nhiên thế giới'),
('DTQ05', N'Văn Miếu - Quốc Tử Giám', N'Hà Nội', N'Tham quan di tích', N'Trường đại học đầu tiên của Việt Nam');


INSERT INTO TourDiemDung (MaTour, ThuTu, TenDiemDung, DoiPhuongTien, CoNoiAn, CoKhachSan, HangSaoKhachSan, GhiChu) VALUES
('T001', 1, N'Mỹ Tho', 0, 1, 0, NULL, NULL),
('T001', 2, N'Cần Thơ', 0, 1, 1, 3, NULL),
('T001', 3, N'TP.HCM', 0, 0, 0, NULL, N'Kết thúc tour'),
('T003', 1, N'Hà Nội', 1, 1, 1, 4, N'Đổi sang xe du lịch'),
('T003', 2, N'Hạ Long', 1, 1, 1, 5, N'Đi tàu thủy trên vịnh'),
('T003', 3, N'TP.HCM', 0, 0, 0, NULL, N'Kết thúc tour');


INSERT INTO TourPhuongTien (MaTour, ThuTuChang, MaPT, GhiChu) VALUES
('T001', 1, 'PT01', NULL),
('T001', 2, 'PT01', NULL),
('T001', 3, 'PT01', NULL),
('T003', 1, 'PT02', N'TP.HCM - Hà Nội'),
('T003', 2, 'PT01', N'Hà Nội - Hạ Long'),
('T003', 2, 'PT04', N'Tham quan vịnh'),
('T003', 3, 'PT02', N'Hà Nội - TP.HCM');


INSERT INTO TourDiemThamQuan (MaTour, MaDiemTQ, ThuTu) VALUES
('T001', 'DTQ02', 1),
('T001', 'DTQ01', 2),
('T002', 'DTQ03', 1),
('T003', 'DTQ05', 1),
('T003', 'DTQ04', 2);


INSERT INTO ChuyenLe (MaChuyen, MaTour, NgayDi, NgayVe, DiaDiemDon, TrangThai) VALUES
('CL001', 'T001', '2026-09-05', '2026-09-07', N'Nhà Văn hóa Thanh Niên, Quận 1', N'Đóng đăng ký'),
('CL002', 'T001', '2026-11-15', '2026-11-17', N'Nhà Văn hóa Thanh Niên, Quận 1', N'Mở đăng ký'),
('CL003', 'T002', '2026-11-20', '2026-11-23', N'Công viên 23/9, Quận 1', N'Mở đăng ký');


INSERT INTO DangKyLe (SoDKLe, MaChuyen, MaDiemBan, NgayDangKy, TenNguoiDangKy, DienThoai, SoNguoi, ThanhTien, DaThanhToan, TrangThai) VALUES
('DKL001', 'CL001', 'DB01', '2026-08-20 09:00:00', N'Phạm Văn Long', '0912000001', 2, 5000000, 1, N'Đã đăng ký'),
('DKL002', 'CL002', 'DB02', '2026-10-01 10:00:00', N'Võ Thị Mai', '0912000002', 3, 7500000, 1, N'Đã đăng ký');

INSERT INTO DoanKhach (MaDoan, TenCoQuanDaiDien, DiaChi, DienThoai, NguoiDaiDien) VALUES
('DK01', N'Công ty CP Phần mềm Sao Việt', N'25 Nguyễn Thị Minh Khai, Quận 3, TP.HCM', '0283900001', N'Lê Văn Hải'),
('DK02', N'Gia đình ông Trần Văn Nam', N'8 Phan Xích Long, Phú Nhuận, TP.HCM', '0909111222', N'Trần Văn Nam');


INSERT INTO DangKyDoan (SoDKDoan, MaDoan, MaTour, NgayDangKy, NgayDi, NgayKetThucDuKien, SoNguoi, DiaDiemDon, MuaBaoHiem, TienCoc, DaThanhToanCoc, TongTienDuKien, TrangThai) VALUES
('DD001', 'DK01', 'T001', '2026-08-01 08:30:00', '2026-09-10', '2026-09-12', 20, N'25 Nguyễn Thị Minh Khai, Quận 3', 0, 10000000, 1, 50000000, N'Đã đăng ký'),
('DD002', 'DK02', 'T002', '2026-09-25 14:00:00', '2026-12-10', '2026-12-13', 15, N'8 Phan Xích Long, Phú Nhuận', 0, 12000000, 1, 48000000, N'Đã đăng ký');


INSERT INTO PhanCongHDV (MaPhanCong, MaHDV, LoaiPhanCong, MaChuyen, SoDKDoan, ThuLaoTour, NgayPhanCong) VALUES
('PC001', 'HDV01', N'LE', 'CL001', NULL, 1500000, '2026-09-01'),
('PC002', 'HDV02', N'DOAN', NULL, 'DD001', 2000000, '2026-09-02'),
('PC003', 'HDV03', N'DOAN', NULL, 'DD001', 2000000, '2026-09-02');

INSERT INTO KhaoSatYKien (MaKhaoSat, LoaiKhach, SoDKLe, SoDKDoan, NgayGui, NgayPhanHoi, DiemDanhGia, YKienGopY, TrangThai) VALUES
('KS001', N'LE', 'DKL001', NULL, '2026-09-08', '2026-09-10', 5, N'Hướng dẫn viên nhiệt tình', N'Đã phản hồi');
GO

PRINT N'Khởi tạo thành công CSDL QuanLyCongTyDuLich chuẩn hóa cho ứng dụng Visual Studio 2022!';