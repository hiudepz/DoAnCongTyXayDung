using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Congtrinh_Admin
    {
        private CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();

        public List<CongTrinh> GetAllConstruction()
        {

       

            try
            {
                using (var db = new CTYXAYDUNGDataContext())
                {
                    return db.CongTrinhs.ToList() ?? new List<CongTrinh>();
                }
            }
            catch
            {
                return new List<CongTrinh>(); // return to empty instead null
            }


        }

        public List<string> GetAllStatus()
        {

            var statusConstruction= db.CongTrinhs.Select(x => x.trang_thai).Distinct().ToList();

            //Default list
            var defStatus = new List<string>
                 {
                     "Chưa bắt đầu",
                     "Đang thi công",
                     "Tạm dừng",
                     "Đã hoàn thành"
                 };
            //merge statusConstuction n defStatus
            return defStatus.Union(statusConstruction).OrderBy(x => x).ToList();
        }

        // Add contruction
        public bool AddConstruction(CongTrinh construction)
        {
            try
            {
                db.CongTrinhs.InsertOnSubmit(construction);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DeleteConstruction
        public bool DeleteConstruction(int id)
        {
            try
            {
                var construction = db.CongTrinhs.FirstOrDefault(ct => ct.id == id);
                if (construction != null)
                {
                    db.CongTrinhs.DeleteOnSubmit(construction);
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

        // Update Construction
        public bool UpdateConstruction(CongTrinh updatedConstruction)
        {
            try
            {
                using (var db = new CTYXAYDUNGDataContext()) // Thêm using để đảm bảo giải phóng tài nguyên
                {
                    var existing = db.CongTrinhs.FirstOrDefault(ct => ct.id == updatedConstruction.id);
                    if (existing != null)
                    {
                        
                        existing.ten = updatedConstruction.ten;
                        existing.dia_diem = updatedConstruction.dia_diem;
                        existing.chu_dau_tu = updatedConstruction.chu_dau_tu;
                        existing.ngay_bat_dau = updatedConstruction.ngay_bat_dau;
                        existing.ngay_du_kien_ket_thuc = updatedConstruction.ngay_du_kien_ket_thuc;
                        existing.trang_thai = updatedConstruction.trang_thai;
                        existing.tong_muc_dau_tu = updatedConstruction.tong_muc_dau_tu;
                        existing.hinh_anh = updatedConstruction.hinh_anh;

                        //// Xử lý ngày hoàn thành nếu có
                        //if (updatedConstruction.ngay_hoan_thanh.HasValue)
                        //    existing.ngay_hoan_thanh = updatedConstruction.ngay_hoan_thanh;

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
