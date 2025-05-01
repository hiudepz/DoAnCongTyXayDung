using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CT_NT_Admin
    {
        CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();
        public List<CongTrinh> GetAllCongTrinh()
        {
            return db.CongTrinhs.Distinct().ToList();
        }

        public List<NhaThau> GetAllNhaThau()
        {
            return db.NhaThaus.Distinct().ToList();
        }

        public List<CongTrinh_NhaThau> GetAllCTNT()
        {
            return db.CongTrinh_NhaThaus.Distinct().ToList();
        }

        public bool Insert(CongTrinh_NhaThau what)
        {
            try
            {
                CongTrinh_NhaThau entity = new CongTrinh_NhaThau
                {
                    cong_trinh_id = what.cong_trinh_id,
                    nha_thau_id = what.nha_thau_id,
                    vai_tro = what.vai_tro
                };

                db.CongTrinh_NhaThaus.InsertOnSubmit(entity);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
