using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Services
{
    internal static class FormHelper
    {
        public static void Grid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = false;
            dgv.BackgroundColor = Color.White;
        }

        public static void Bind(ComboBox cbo, DataTable dt, string display, string value)
        {
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DataSource = dt;
        }

        public static string Val(ComboBox cbo)
        {
            return cbo.SelectedValue == null ? "" : Convert.ToString(cbo.SelectedValue);
        }

        public static bool Confirm(string text)
        {
            return MessageBox.Show(text, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void Ok(string text)
        {
            MessageBox.Show(text, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(Exception ex)
        {
            MessageBox.Show(ex.Message, "Không thực hiện được", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
