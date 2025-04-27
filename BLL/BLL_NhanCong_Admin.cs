using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_NhanCong_Admin
    {
        private DAL_Nhancong_Admin bll = new DAL_Nhancong_Admin();
        public List<NhanCong> GetMemberList()
        {
            return bll.GetAllMember();
        }


        public bool AddMember(NhanCong Member)
        {
            // Validate 


            return bll.AddMember(Member);
        }


        public bool DeleteMember(int id)
        {

            return bll.DeleteMember(id);
        }


        public bool UpdateMember(NhanCong Member)
        {
            // valite date

            return bll.UpdateMember(Member);
        }
    }
}
