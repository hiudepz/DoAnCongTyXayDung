using DAL;
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

        public List<PhanCong> GetPhanCongList()
        {
            return ctrDal.GetAllPhanCong();
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


         
    }
}
