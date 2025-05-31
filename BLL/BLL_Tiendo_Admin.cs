using DAL;
using DTO;
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

        public List<DTO_TienDo> GetProgressList()
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

            if(Progress.phan_tram_hoan_thanh <0 || Progress.phan_tram_hoan_thanh > 100)
            {
                throw new Exception("Phần trăm hoàn thành phải từ 0 đến 100");
            }
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
        public List<DTO_TienDo> GetAllProgressTK(string keyword)
        {
            return ctrDal.GetAllProgressTK(keyword);
        }

    }
}
