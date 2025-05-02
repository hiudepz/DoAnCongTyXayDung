using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_CT_VT_Admin
    {
        DAL_CT_VT_Admin dal = new DAL_CT_VT_Admin();

        public List<CongTrinh> LayDanhSachCongTrinh()
        {
            return dal.GetAllCongTrinh();
        }

        public List<VatTu> LayDanhSachVatTu()
        {
            return dal.GetAllVatTu();
        }

        public List<CongTrinh_VatTu> LayDanhSachCTVT()
        {
            return dal.GetAllCTVT();
        }
        public bool SuaVatTuVaoCongTrinh(CongTrinh_VatTu dto)
        {
            return dal.Update(dto);
        }
        public bool ThemVatTuVaoCongTrinh(CongTrinh_VatTu dto)
        {
            return dal.Insert(dto);
        }
        public bool XoaVatTuVaoCongTrinh(CongTrinh_VatTu dto)
        {
            return dal.Delete(dto);
        }
    }
}
