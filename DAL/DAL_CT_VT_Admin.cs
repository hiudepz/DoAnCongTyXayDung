using DTO;
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
                //CongTrinh_VatTu entity = new CongTrinh_VatTu
                //{
                //    cong_trinh_id = what.cong_trinh_id,
                //    vat_tu_id = what.vat_tu_id,

                //    so_luong = what.so_luong,
                //    don_gia = what.don_gia,
                //    ngay_su_dung = what.ngay_su_dung
                //};

                db.CongTrinh_VatTus.InsertOnSubmit(what);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<DTO_CongTrinh_VatTu> GetAllCTVT()
        {
            try
            {
                var query = from ct_vt in db.CongTrinh_VatTus
                            join ct in db.CongTrinhs on ct_vt.cong_trinh_id equals ct.id
                            join vt in db.VatTus on ct_vt.vat_tu_id equals vt.id
                            select new DTO_CongTrinh_VatTu
                            {
                                TenCongTrinh = ct.ten, // Giả sử trường tên công trình là ten_cong_trinh
                                TenVatTu = vt.ten,
                                SoLuong = (decimal)ct_vt.so_luong,
                                DonGia = (decimal)ct_vt.don_gia,
                                NgaySuDung = ct_vt.ngay_su_dung,
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_CongTrinh_VatTu>();
            }
        }
        public List<DTO_CongTrinh_VatTu> GetAllCTVTTK(string keyword = "")
        {
            try
            {
                var query = from ct_vt in db.CongTrinh_VatTus
                            join ct in db.CongTrinhs on ct_vt.cong_trinh_id equals ct.id
                            join vt in db.VatTus on ct_vt.vat_tu_id equals vt.id
                            where string.IsNullOrEmpty(keyword) || ct.ten.Contains(keyword)
                            select new DTO_CongTrinh_VatTu
                            {
                                TenCongTrinh = ct.ten, // Giả sử trường tên công trình là ten_cong_trinh
                                TenVatTu = vt.ten,
                                SoLuong = (decimal)ct_vt.so_luong,
                                DonGia = (decimal)ct_vt.don_gia,
                                NgaySuDung = ct_vt.ngay_su_dung,
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_CongTrinh_VatTu>();
            }
        }
    }
}
