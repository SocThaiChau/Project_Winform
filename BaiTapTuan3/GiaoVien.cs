using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapTuan3
{
    internal class GiaoVien
    {
        public int TeacherCode;
        public string Name;
        public string Address;
        public DateTime DayOfBirth;
        public string ID;
        public string Email;
        public string PhoneNumber;

        public GiaoVien(int teacherCode, string name, string address, DateTime dayOfBirth, string iD, string email, string phoneNumber)
        {
            TeacherCode = teacherCode;
            Name = name;
            Address = address;
            DayOfBirth = dayOfBirth;
            ID = iD;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
