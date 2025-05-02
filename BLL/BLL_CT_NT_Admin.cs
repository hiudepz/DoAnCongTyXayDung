using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_CT_NT_Admin
    {
        DAL_CT_NT_Admin dal = new DAL_CT_NT_Admin();

        public List<CongTrinh> LayDanhSachCongTrinh()
        {
            return dal.GetAllCongTrinh();
        }

        public List<NhaThau> LayDanhSachNhaThau()
        {
            return dal.GetAllNhaThau();
        }

        public List<CongTrinh_NhaThau> LayDanhSachCTNT()
        {
            return dal.GetAllCTNT();
        }
        public bool XoaNhaThauVaoCongTrinh(CongTrinh_NhaThau dto)
        {
            return dal.Delete(dto);
        }
        public bool ThemNhaThauVaoCongTrinh(CongTrinh_NhaThau dto)
        {
            return dal.Insert(dto);
        }
    }
}
