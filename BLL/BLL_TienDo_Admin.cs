using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_TienDo_Admin
    {
        private DAL_TienDo_Admin ctrDal = new DAL_TienDo_Admin();

        public List<TienDo> GetProgressList()
        {
            return ctrDal.GetAllProgress();
        }

        //public List<string> GetStatusList()
        //{
        //    return ctrDal.GetAllStatus();
        //}
        public List<TienDo> GetByTienDo()
        {
            return ctrDal.GetByTienDo();
        }

        public bool AddProgress(TienDo Progress)
        {


            return ctrDal.AddProgress(Progress);
        }


        public bool DeleteProgress(int id)
        {

            return ctrDal.DeleteProgress(id);
        }


        public bool UpdateProgress(TienDo Progress)
        {


            return ctrDal.UpdateProgress(Progress);
        }
        public List<string> GetbyCongTrinh(int congTrinhId)
        {
            return ctrDal.GetByCongTrinh(congTrinhId);
        }
        public List<CongTrinh> GetAllCongTrinh()
        {
            return ctrDal.GetAllCongTrinh();
        }
    }
}
