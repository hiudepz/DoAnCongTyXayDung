using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_PhanCong_Admin
    {
        DAL_PhanCong_Admin dal = new DAL_PhanCong_Admin();

        public bool KiemTraPhanCong(int congTrinhId, int nhanCongId)
        {
            return dal.DaPhanCong(congTrinhId, nhanCongId);
        }

        public bool PhanCong(int congTrinhId, int nhanCongId, DateTime ngayBD, DateTime ngayKT)
        {
            return dal.ThemPhanCong(congTrinhId, nhanCongId, ngayBD, ngayKT);
        }

        public bool HuyPhanCong(int congTrinhId, int nhanCongId)
        {
            return dal.XoaPhanCong(congTrinhId, nhanCongId);
        }

        public IQueryable<NhanCong> LayDanhSachNhanCong()
        {
            return dal.LayDanhSachNhanCong();
        }

        public IQueryable<CongTrinh> LayDanhSachCongTrinh()
        {
            return dal.LayDanhSachCongTrinh();
        }
    }
}
