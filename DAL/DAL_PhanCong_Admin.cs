using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhanCong_Admin
    {
        CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();

        public bool DaPhanCong(int congTrinhId, int nhanCongId)
        {
            return db.PhanCongs.Any(p => p.cong_trinh_id == congTrinhId && p.nhan_cong_id == nhanCongId);
        }

        public bool ThemPhanCong(int congTrinhId, int nhanCongId, DateTime ngayBD, DateTime ngayKT)
        {
            try
            {
                var pc = new PhanCong
                {
                    cong_trinh_id = congTrinhId,
                    nhan_cong_id = nhanCongId,
                    ngay_bat_dau = ngayBD,
                    ngay_ket_thuc = ngayKT
                };
                db.PhanCongs.InsertOnSubmit(pc);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool XoaPhanCong(int congTrinhId, int nhanCongId)
        {
            try
            {
                var pc = db.PhanCongs.FirstOrDefault(p => p.cong_trinh_id == congTrinhId && p.nhan_cong_id == nhanCongId);
                if (pc != null)
                {
                    db.PhanCongs.DeleteOnSubmit(pc);
                    db.SubmitChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<NhanCong> LayDanhSachNhanCong()
        {
            return db.NhanCongs;
        }

        public IQueryable<CongTrinh> LayDanhSachCongTrinh()
        {
            return db.CongTrinhs;
        }
    }
}
