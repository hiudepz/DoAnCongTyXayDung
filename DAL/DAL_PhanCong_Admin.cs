using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhanCong_Admin
    {
        private CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();

        public List<PhanCong> GetAllPhanCong()
        {
            try
            {
                using (var db = new CTYXAYDUNGDataContext())
                {
                    db.DeferredLoadingEnabled = false;
                    return db.PhanCongs.ToList() ?? new List<PhanCong>();
                }

            }
            catch
            {
                return new List<PhanCong>(); // return to empty instead null
            }

        }
        

        // public List<PhanCong> GetByPhanCong()
        // {
        //     using (var db = new CTYXAYDUNGDataContext())
        //     {
        //         return db.PhanCongs
        //                 .OrderBy(t => t.ngay_cap_nhat)
        //                 .ToList();
        //     }
        // }
        // public List<string> GetByCongTrinh(int congTrinhId)
        // {
        //     return db.CongTrinhs.Where(t => t.id == congTrinhId)
        //.Select(t => t.ten).ToList();
        // }

        public bool AddPhanCong(PhanCong contractor) // them phan cong
        {
            try
            {
                db.PhanCongs.InsertOnSubmit(contractor);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public bool DeletePhanCong(int id) //Xóa phân công
        //{
        //    try
        //    {
        //        var contractor = db.PhanCongs.FirstOrDefault(ct => ct.id == id);
        //        if (contractor != null)
        //        {
        //            db.PhanCongs.DeleteOnSubmit(contractor);
        //            db.SubmitChanges();
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        // Update PhanCong
        //public bool UpdatePhanCong(PhanCong updatedPhanCong) //Sua
        //{
        //    try
        //    {
        //        using (var db = new CTYXAYDUNGDataContext()) // Thêm using để đảm bảo giải phóng tài nguyên
        //        {
        //            var existing = db.PhanCongs.FirstOrDefault(ct => ct.id == updatedPhanCong.id);
        //            if (existing != null)
        //            {

        //                existing.cong_trinh_id = updatedPhanCong.cong_trinh_id;
        //                existing.ngay_cap_nhat = updatedPhanCong.ngay_cap_nhat;
        //                existing.ngay_cap_nhat = updatedPhanCong.ngay_cap_nhat;
                        


        //                //// Xử lý ngày hoàn thành nếu có
        //                //if (updatedPhanCong.ngay_hoan_thanh.HasValue)
        //                //    existing.ngay_hoan_thanh = updatedPhanCong.ngay_hoan_thanh;

        //                db.SubmitChanges();
        //                return true;
        //            }
        //            return false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }

        //}
        //public List<CongTrinh> GetAllCongTrinh()
        //{
        //    return db.CongTrinhs.ToList();
        //}
    }
}

