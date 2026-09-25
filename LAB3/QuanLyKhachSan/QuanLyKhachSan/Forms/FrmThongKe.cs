using System;
using System.Data;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước Từ ngày.", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dtTongHop = s.TongHop(dtTu.Value, dtDen.Value);
            dgvTongHop.DataSource = dtTongHop;

            // Đưa thông tin tổng hợp lên các Label (nếu giao diện dùng Label hiển thị)
            if (dtTongHop.Rows.Count > 0)
            {
                DataRow r = dtTongHop.Rows[0];
                if (lblPhieuDat != null) lblPhieuDat.Text = "Phiếu đặt: " + r["SoPhieuDat"];
                if (lblDangO != null) lblDangO.Text = "Đang ở: " + r["DangO"];
                if (lblHoaDon != null) lblHoaDon.Text = "Hóa đơn: " + r["SoHoaDon"];
                if (lblDoanhThu != null) lblDoanhThu.Text = string.Format("Doanh thu HĐ: {0:N0} đ", r["DoanhThuHoaDon"]);
                if (lblDenBu != null) lblDenBu.Text = string.Format("Tổng đền bù: {0:N0} đ", r["TongDenBu"]);
            }

            // Nạp bảng thống kê dịch vụ
            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}