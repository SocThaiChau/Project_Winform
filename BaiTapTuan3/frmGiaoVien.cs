using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace BaiTapTuan3
{
    public partial class frmGiaoVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        GiaoVienDAO GVDAO = new GiaoVienDAO();

        public frmGiaoVien()
        {
            InitializeComponent();
        }
        public DataTable DanhSachSV()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM GiaoVien3", conn);
            DataTable dtSinhVien = new DataTable();
            adapter.Fill(dtSinhVien);
            return dtSinhVien;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            load();
        }
        public void load()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select * from GiaoVien3");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);

                dtgvGiaoVien.DataSource = dtSinhVien;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();

            }
        }
        private void dtgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvGiaoVien.Rows[e.RowIndex];
            txtCode.Text = Convert.ToString(row.Cells["Magiaovien"].Value);
            txtTen.Text = Convert.ToString(row.Cells["Ten"].Value);
            txtDiachi.Text = Convert.ToString(row.Cells["Diachi"].Value);
            dateTimePicker1.Text = Convert.ToString(row.Cells["Ngaysinh"].Value);
            txtCmnd.Text = Convert.ToString(row.Cells["Cmnd"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
            txtSdt.Text = Convert.ToString(row.Cells["SoDT"].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Function.IsValidEmail(txtEmail.Text) == true && Function.IsPhoneNumber(txtSdt.Text) == true)
            {
                GiaoVien giaoVien = new GiaoVien(Convert.ToInt32(txtCode.Text), txtTen.Text, txtDiachi.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSdt.Text);
                GVDAO.Add(giaoVien);
                load();
            }
            else
            {
                MessageBox.Show("email hoac dien thoai khong hop le");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(Convert.ToInt32(txtCode.Text), txtTen.Text, txtDiachi.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSdt.Text);
            GVDAO.Delete(giaoVien);
            load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Function.IsValidEmail(txtEmail.Text) == true && Function.IsPhoneNumber(txtSdt.Text) == true)
            {
                GiaoVien giaoVien = new GiaoVien(Convert.ToInt32(txtCode.Text), txtTen.Text, txtDiachi.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSdt.Text);
                GVDAO.Update(giaoVien);
                load();
            }
            else
            {
                MessageBox.Show("email hoac dien thoai khong hop le");
            }
        }

    }
}
