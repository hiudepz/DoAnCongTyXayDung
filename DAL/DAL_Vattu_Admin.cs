using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Vattu_Admin
    {
        private CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();
       


        public List<string> GetAllNameMaterials()
        {

            return db.VatTus.Select(x => x.ten).Distinct().ToList();



        }
        public List<VatTu> GetAllMaterial()
        {

            try
            {
                using (var db = new CTYXAYDUNGDataContext())
                {
                    return db.VatTus.ToList() ?? new List<VatTu>();
                }
            }
            catch
            {
                return new List<VatTu>(); // return to empty instead null
            }

        }


        public bool AddMaterial(VatTu contractor)
        {
            try
            {
                db.VatTus.InsertOnSubmit(contractor);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteMaterial(int id)
        {
            try
            {
                var contractor = db.VatTus.FirstOrDefault(ct => ct.id == id);
                if (contractor != null)
                {
                    db.VatTus.DeleteOnSubmit(contractor);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Update Material
        public bool UpdateMaterial(VatTu updatedMaterial)
        {
            try
            {
                using (var db = new CTYXAYDUNGDataContext()) // Thêm using để đảm bảo giải phóng tài nguyên
                {
                    var existing = db.VatTus.FirstOrDefault(ct => ct.id == updatedMaterial.id);
                    if (existing != null)
                    {

                        existing.ma_vat_tu = updatedMaterial.ma_vat_tu;
                        existing.ten = updatedMaterial.ten;
                        existing.don_vi_tinh = updatedMaterial.don_vi_tinh;
                        existing.don_gia = updatedMaterial.don_gia;
                        existing.nha_cung_cap = updatedMaterial.nha_cung_cap;
                        existing.hinh_anh= updatedMaterial.hinh_anh;

                        //// Xử lý ngày hoàn thành nếu có
                        //if (updatedMaterial.ngay_hoan_thanh.HasValue)
                        //    existing.ngay_hoan_thanh = updatedMaterial.ngay_hoan_thanh;

                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public List<CongTrinh> TimKiem(string tukhoa)
        {
            return db.CongTrinhs.Where(t => t.ten.Contains(tukhoa)).ToList();
        }
    }
}
