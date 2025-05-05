using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Nhathau_Admin
    {
        private DAL_Nhathau_Admin ctrDal = new DAL_Nhathau_Admin();
        //public List<NhaThau> GetTheThingIWant()
        //{
        //    return ctrDal.GetWhatIWant();
        //}

        public List<string> GetNameContractorList()
        {
            return ctrDal.GetAllNameContractor();

        }
        public List<NhaThau> GetContractorList()
        {
            return ctrDal.GetAllContractor();
        }

        //public List<string> GetStatusList()
        //{
        //    return ctrDal.GetAllStatus();

        //}


        public bool AddContractor(NhaThau contractor)
        {
            // Validate 
            

            return ctrDal.AddContractor(contractor);
        }


        public bool DeleteContractor(int id)
        {

            return ctrDal.DeleteContractor(id);
        }


        public bool UpdateContractor(NhaThau contractor)
        {
            // valite date
            

            return ctrDal.UpdateContractor(contractor);
        }
        public List<NhaThau> TimKiem(string tukhoa)
        {
            return ctrDal.TimKiem(tukhoa);
        }
    }
}
