using System;
using System.Windows.Forms;

namespace QuanLyNhanSuDongA
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Tắt tự động phóng to lỗi Font của Windows
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.FrmMain());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}