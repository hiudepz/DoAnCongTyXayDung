using DAL;
using DTO;
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

        public List<DTO_CongTrinh_VatTu> LayDanhSachCTVT()
        {
            return dal.GetAllCTVT();
        }
        public bool SuaVatTuVaoCongTrinh(CongTrinh_VatTu dto)
        {
            if (dto.don_gia < 0)
            {
                throw new Exception("Đơn giá phải lớn hơn 0");
            }
            if (dto.so_luong < 0)
            {
                throw new Exception("Số lượng phải lớn hơn 0");
            }
            return dal.Update(dto);
        }
        public bool ThemVatTuVaoCongTrinh(CongTrinh_VatTu dto)
        {
            if (dto.don_gia <0)
            {
                throw new Exception("Đơn giá phải lớn hơn 0");
            }
            if (dto.so_luong < 0)
            {
                throw new Exception("Số lượng phải lớn hơn 0");
            }
            return dal.Insert(dto);
        }
        public bool XoaVatTuVaoCongTrinh(CongTrinh_VatTu dto)
        {
            return dal.Delete(dto);
        }
        public List<DTO_CongTrinh_VatTu> GetAllTK(string keyword)
        {
            return dal.GetAllCTVTTK(keyword);
        }
    }
}
