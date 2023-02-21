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
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace BaiTapTuan3
{
    public partial class frmHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        HocSinhDAO HSDAO = new HocSinhDAO();
        
        public frmHocSinh()
        {
            InitializeComponent();
        }

        public DataTable DanhSachSV()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM HocSinh3", conn);
            DataTable dtSinhVien = new DataTable();
            adapter.Fill(dtSinhVien);
            return dtSinhVien;
        }
        private void dtgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgvHocSinh.Rows[e.RowIndex];
            txtCode.Text = Convert.ToString(row.Cells["Mahocsinh"].Value);
            txtTen.Text = Convert.ToString(row.Cells["Ten"].Value);
            txtDiachi.Text = Convert.ToString(row.Cells["Diachi"].Value);
            dateTimePicker1.Text = Convert.ToString(row.Cells["Ngaysinh"].Value);
            txtCmnd.Text = Convert.ToString(row.Cells["Cmnd"].Value);
            txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
            txtSdt.Text = Convert.ToString(row.Cells["SoDT"].Value);
        }
        public void load()
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("select * from HocSinh3");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);

                dtgvHocSinh.DataSource = dtSinhVien;

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
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            load();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Function.IsInputEmpty(txtCmnd.Text) == false || Function.IsInputEmpty(txtCode.Text) == false || Function.IsInputEmpty(txtDiachi.Text) == false||
                Function.IsInputEmpty(txtEmail.Text) == false || Function.IsInputEmpty(txtSdt.Text) == false || Function.IsInputEmpty(txtTen.Text) == false)
            {
                if (Function.IsValidEmail(txtEmail.Text) == true && Function.IsPhoneNumber(txtSdt.Text) == true)
                {
                    HocSinh hocSinh = new HocSinh(Convert.ToInt32(txtCode.Text), txtTen.Text, txtDiachi.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSdt.Text);
                    HSDAO.Add(hocSinh);
                    load();
                }
                else
                {
                    MessageBox.Show("email hoac dien thoai khong hop le");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(Convert.ToInt32(txtCode.Text), txtTen.Text, txtDiachi.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSdt.Text);
            HSDAO.Delete(hocSinh);
            load();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Function.IsValidEmail(txtEmail.Text) == true && Function.IsPhoneNumber(txtSdt.Text) == true)
            {
                HocSinh hocSinh = new HocSinh(Convert.ToInt32(txtCode.Text), txtTen.Text, txtDiachi.Text, dateTimePicker1.Value, txtCmnd.Text, txtEmail.Text, txtSdt.Text);
                HSDAO.update(hocSinh);
                load();
            }
            else
            {
                MessageBox.Show("email hoac dien thoai khong hop le");
            }
        }
    }
}
