using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap
    {
        CTYXAYDUNGDataContext db = DB.GetContext();
        public NguoiDung GetByNguoiDung(string tenDangNhap,string matKhau)
        {
            
                return db.NguoiDungs
                    .FirstOrDefault(nd => nd.ten_dang_nhap == tenDangNhap && nd.mat_khau == matKhau);
        }
        public bool ThemNguoiDung(NguoiDung nd)
        {
            
                if (db.NguoiDungs.Any(x => x.ten_dang_nhap == nd.ten_dang_nhap))
                    return false;
                db.NguoiDungs.InsertOnSubmit(nd);
                db.SubmitChanges();
                return true;
            
        }
        public bool DoiMatKhau(string tenDangNhap, string matKhauCu, string matKhauMoi)
        {
            var nd = db.NguoiDungs
                       .FirstOrDefault(x => x.ten_dang_nhap == tenDangNhap && x.mat_khau == matKhauCu);
            if (nd == null)
                return false;

            nd.mat_khau = matKhauMoi;
            db.SubmitChanges();
            return true;
        }
    }
}
