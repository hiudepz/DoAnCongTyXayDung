using DAL;
using DTO;
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
            return dal.GetAllCT();
        }

        public List<NhaThau> LayDanhSachNhaThau()
        {
            return dal.GetAllNhaThau();
        }

        public List<DTO_CongTrinh_NhaThau> LayDanhSachCTNT()
        {
            return dal.GetAllCTNT();
        }
        public bool XoaNhaThauVaoCongTrinh(CongTrinh_NhaThau dto)
        {
            return dal.Delete(dto);
        }
        public bool ThemNhaThauVaoCongTrinh(CongTrinh_NhaThau dto)
        {
            if(string.IsNullOrEmpty(dto.vai_tro))
            {
                throw new Exception("Vai trò không được để trống");
            }
            return dal.Insert(dto);
        }
        public bool SuaNhaThauVaCongTrinh(CongTrinh_NhaThau dto)
        {
            if (string.IsNullOrEmpty(dto.vai_tro))
            {
                throw new Exception("Vai trò không được để trống");
            }
            return dal.Update(dto);
        }
        public List<DTO_CongTrinh_NhaThau> GetAllTK(string keyword)
        {
            return dal.GetAllCTNTTK(keyword);
        }
    }
}
