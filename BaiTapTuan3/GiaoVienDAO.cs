using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan3
{
    internal class GiaoVienDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        // THÊM
        public void Add(GiaoVien giaoVien)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO GiaoVien3 (Magiaovien, Ten, Diachi, Ngaysinh, Cmnd, Email, SoDT)" +
                    " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                    giaoVien.TeacherCode, giaoVien.Name, giaoVien.Address, giaoVien.DayOfBirth, giaoVien.ID, giaoVien.Email, giaoVien.PhoneNumber);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("them that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //XÓA
        public void Delete(GiaoVien giaoVien)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("delete from GiaoVien3 where Magiaovien = '{0}' ", giaoVien.TeacherCode);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //SỬA
        public void Update(GiaoVien giaoVien)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sqlStr = string.Format("update GiaoVien3" +
                    " set Ten = '{0}', Diachi = '{1}', Ngaysinh = '{2}', Cmnd = '{3}', Email = '{4}', SoDT =  '{5}'" +
                    "WHERE Magiaovien = '{6}'",
                    giaoVien.Name, giaoVien.Address, giaoVien.DayOfBirth, giaoVien.ID, giaoVien.Email, giaoVien.PhoneNumber, giaoVien.TeacherCode);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Cap nhat thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("cap nhat that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        
        // check số điện thoại hợp lệ hay không 
        public void CheckPhoneNumber()
        {
            /*Regex isValidInput = new Regex(@"^\d{9,11}$");
            string strPhone = Console.ReadLine();
            if (!isValidInput.IsMatch(strPhone)) Console.WriteLine("Nhầm hàng rồi");*/
        }

        // check email hợp lệ hay không
        public void CheckEmail()
        {

        }
    }
}
