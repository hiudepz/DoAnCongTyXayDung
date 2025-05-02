using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_CT_VT_Admin
    {
        CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();
        public List<CongTrinh> GetAllCongTrinh()
        {
            return db.CongTrinhs.Distinct().ToList();
        }

        public List<VatTu> GetAllVatTu()
        {
            return db.VatTus.Distinct().ToList();
        }

        public List<CongTrinh_VatTu> GetAllCTVT()
        {
            return db.CongTrinh_VatTus.Distinct().ToList();
        }
        public bool Delete(CongTrinh_VatTu what)
        {
            try
            {
                var entity = db.CongTrinh_VatTus.SingleOrDefault(vt =>
                    vt.cong_trinh_id == what.cong_trinh_id &&
                    vt.vat_tu_id == what.vat_tu_id &&
                    vt.ngay_su_dung == what.ngay_su_dung);

                if (entity != null)
                {
                    db.CongTrinh_VatTus.DeleteOnSubmit(entity);
                    db.SubmitChanges();
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(CongTrinh_VatTu what)
        {
            try
            {
                var existing = db.CongTrinh_VatTus.FirstOrDefault(vt => vt.cong_trinh_id == what.cong_trinh_id && vt.vat_tu_id == what.vat_tu_id && vt.ngay_su_dung==what.ngay_su_dung);
                if(existing != null)
                {
                    existing.so_luong=what.so_luong;
                    existing.don_gia=what.don_gia;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Insert(CongTrinh_VatTu what)
        {
            try
            {
                CongTrinh_VatTu entity = new CongTrinh_VatTu
                {
                    cong_trinh_id = what.cong_trinh_id,
                    vat_tu_id = what.vat_tu_id,

                    so_luong = what.so_luong,
                    don_gia = what.don_gia,
                    ngay_su_dung = what.ngay_su_dung
                };

                db.CongTrinh_VatTus.InsertOnSubmit(entity);
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
