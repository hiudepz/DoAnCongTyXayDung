using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Congtrinh_Admin
    {
        private DAL_Congtrinh_Admin ctrDal= new DAL_Congtrinh_Admin();

        public List<CongTrinh> GetConstructionList()
        {
            return ctrDal.GetAllConstruction();
        }

        public List<string> GetStatusList()
        {
            return ctrDal.GetAllStatus();
       
        }

   
        public bool AddConstruction(CongTrinh construction)
        {
            // Validate 
            if (construction.ngay_du_kien_ket_thuc < construction.ngay_bat_dau)
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu");

            return ctrDal.AddConstruction(construction);
        }

       
        public bool DeleteConstruction(int id)
        {
            
            return ctrDal.DeleteConstruction(id);
        }

       
        public bool UpdateConstruction(CongTrinh construction)
        {
            // valite date
            if (construction.ngay_du_kien_ket_thuc < construction.ngay_bat_dau)
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu");

            return ctrDal.UpdateConstruction(construction);
        }

        public List<CongTrinh> TimKiem(string tukhoa)
        {
            return ctrDal.TimKiem(tukhoa);
        }
    }
}
