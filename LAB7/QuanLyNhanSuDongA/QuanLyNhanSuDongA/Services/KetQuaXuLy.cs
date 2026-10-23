namespace QuanLyNhanSuDongA.Services
{
    public class KetQuaXuLy
    {
        public bool ThanhCong { get; private set; }
        public string ThongBao { get; private set; }

        public static KetQuaXuLy Ok(string s) => new KetQuaXuLy { ThanhCong = true, ThongBao = s };
        public static KetQuaXuLy Fail(string s) => new KetQuaXuLy { ThanhCong = false, ThongBao = s };
    }
}