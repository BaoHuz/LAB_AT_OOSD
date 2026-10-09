using System;
using System.Windows.Forms;
using QuanLyCongTyDuLich.Forms; // Thêm namespace để gọi FrmMain

namespace QuanLyCongTyDuLich
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Đổi Form1 thành FrmMain để ứng dụng mở giao diện chính khi chạy
            Application.Run(new FrmMain());
        }
    }
}