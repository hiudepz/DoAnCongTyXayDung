using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PhanCong_Admin
    {
        private DAL_PhanCong_Admin ctrDal = new DAL_PhanCong_Admin();

        public List<DTO_PhanCong> GetPhanCongList()
        {
            return ctrDal.GetAllPhanCong();
        }
        public List<DTO_PhanCong> GetPhanCongListTK(string keyword = "")
        {
            return ctrDal.GetAllPhanCongTK(keyword);
        }

        //public List<string> GetStatusList()
        //{
        //    return ctrDal.GetAllStatus();

        //}


        public bool AddPhanCong(PhanCong PhanCong)
        {

            return ctrDal.AddPhanCong(PhanCong);
        }


        //public bool DeletePhanCong(int id)
        //{

        //    return ctrDal.DeletePhanCong(id);
        //}
        public bool DeletePhanCong(int congTrinhId, int nhanCongId, DateTime start)
        {
            
            return ctrDal.DeletePhanCong(congTrinhId, nhanCongId, start);
        }
    }
}
