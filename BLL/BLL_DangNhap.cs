using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DangNhap
    {
        DAL_DangNhap dalDangNhap = new DAL_DangNhap();

        public NguoiDung KiemTraDangNhap (string tenDangNhap, string matKhau)
        {
            return dalDangNhap.GetByNguoiDung(tenDangNhap, matKhau);
        }
        public bool DangKyNguoiDung(NguoiDung nd)
        {
            return dalDangNhap.ThemNguoiDung(nd);
        }
        public bool DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            return dalDangNhap.DoiMatKhau(tenDangNhap, matKhauCu, matKhauMoi);
        }
    }
}
