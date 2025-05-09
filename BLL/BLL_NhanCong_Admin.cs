using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLL_NhanCong_Admin
    {
        private DAL_Nhancong_Admin bll = new DAL_Nhancong_Admin();
        public List<NhanCong> GetMemberList()
        {
            return bll.GetAllMember();
        }


        public bool AddMember(NhanCong Member)
        {
            // Validate 
            if (Member == null)
            {
                throw new ArgumentNullException("Đối tượng nhân công không được null");
            }
            if (string.IsNullOrWhiteSpace(Member.ho_ten))
            {
                throw new ArgumentException("Họ tên không được để trống");
            }

            if (string.IsNullOrWhiteSpace(Member.chuc_vu))
            {
                throw new ArgumentException("Chức vụ không được để trống");
            }

            if (Member.luong_ngay <= 0)
            {
                throw new ArgumentException("Lương ngày phải lớn hơn 0");
            }

            if (string.IsNullOrWhiteSpace(Member.so_dien_thoai))
            {
                throw new ArgumentException("Số điện thoại không được để trống");
            }

            // Validate số điện thoại (ví dụ: 10-11 số, bắt đầu bằng 0)
            if (!Regex.IsMatch(Member.so_dien_thoai, @"^0\d{9,10}$"))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ");
            }

            return bll.AddMember(Member);
        }


        public bool DeleteMember(int id)
        {

            return bll.DeleteMember(id);
        }


        public bool UpdateMember(NhanCong Member)
        {
            // valite date
            if (Member == null)
            {
                throw new ArgumentNullException("Đối tượng nhân công không được null");
            }
            if (string.IsNullOrWhiteSpace(Member.ho_ten))
            {
                throw new ArgumentException("Họ tên không được để trống");
            }

            if (string.IsNullOrWhiteSpace(Member.chuc_vu))
            {
                throw new ArgumentException("Chức vụ không được để trống");
            }

            if (Member.luong_ngay <= 0)
            {
                throw new ArgumentException("Lương ngày phải lớn hơn 0");
            }

            if (string.IsNullOrWhiteSpace(Member.so_dien_thoai))
            {
                throw new ArgumentException("Số điện thoại không được để trống");
            }

            // Validate số điện thoại (ví dụ: 10-11 số, bắt đầu bằng 0)
            if (!Regex.IsMatch(Member.so_dien_thoai, @"^0\d{9,10}$"))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ");
            }
            return bll.UpdateMember(Member);
        }
        public List<NhanCong> TimKiem(string tukhoa)
        {
            return bll.TimKiem(tukhoa);
        }
    }
}
