using System;

namespace QuanLyHoSoBenhAn.Models
{
    // DTO Bệnh nhân
    public class BenhNhanDTO
    {
        public string MaBN { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Anh3x4 { get; set; }
    }

    // DTO Phiếu khám
    public class PhieuKhamDTO
    {
        public string MaPhieuKham { get; set; }
        public string MaHoSo { get; set; }
        public string MaBS { get; set; }
        public string MaKhoa { get; set; }
        public string MaLichHen { get; set; }
        public DateTime NgayGioKham { get; set; }
        public string TrieuChung { get; set; }
        public decimal? ThanNhiet { get; set; }
        public string HuyetAp { get; set; }
        public string ChanDoan { get; set; }
        public string DienBien { get; set; }
        public string PhanUngPhu { get; set; }
        public string LoaiKham { get; set; }
        public string TrangThai { get; set; }
    }
}