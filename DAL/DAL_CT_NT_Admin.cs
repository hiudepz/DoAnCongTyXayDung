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

        public bool Delete(CongTrinh_NhaThau dto)
        {
            var obj = db.CongTrinh_NhaThaus
                        .FirstOrDefault(x => x.cong_trinh_id == dto.cong_trinh_id && x.nha_thau_id == dto.nha_thau_id);
            if (obj != null)
            {
                db.CongTrinh_NhaThaus.DeleteOnSubmit(obj);
                db.SubmitChanges();
                return true;
            }
            return false;
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
            public bool Update(CongTrinh_NhaThau what)
            {
                try
                {
                    var existing = db.CongTrinh_NhaThaus.FirstOrDefault(nt=>nt.cong_trinh_id==what.cong_trinh_id && nt.nha_thau_id==what.nha_thau_id);
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
