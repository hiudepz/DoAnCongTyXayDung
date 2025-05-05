using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhanCong_Admin
    {
        private CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();

        public List<DTO_PhanCong> GetAllPhanCong()
        {
            try
            {
                var query = from pc in db.PhanCongs
                            join ct in db.CongTrinhs on pc.cong_trinh_id equals ct.id
                            join nc in db.NhanCongs on pc.nhan_cong_id equals nc.id
                            select new DTO_PhanCong
                            {                              
                                CongTrinhId = pc.cong_trinh_id,
                                NhanCongId = pc.nhan_cong_id,
                                NgayBatDau = pc.ngay_bat_dau,
                                NgayKetThuc = pc.ngay_bat_dau,
                                TenCongTrinh = ct.ten,
                                TenNhanCong = nc.ho_ten // Giả sử trường tên công trình là ten_cong_trinh
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_PhanCong>();
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

        public bool DeletePhanCong(int congTrinhId, int nhanCongId,DateTime start) //Xóa phân công
        {
            try
            {
                var phanCong = db.PhanCongs.FirstOrDefault(p =>
                p.cong_trinh_id == congTrinhId &&
                p.nhan_cong_id == nhanCongId  &&
                p.ngay_bat_dau == start);
                if (phanCong != null)
                {
                    db.PhanCongs.DeleteOnSubmit(phanCong);
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
        public List<DTO_PhanCong> GetAllPhanCongTK(string keyword = "")
        {
            try
            {
                var query = from pc in db.PhanCongs
                            join ct in db.CongTrinhs on pc.cong_trinh_id equals ct.id
                            join nc in db.NhanCongs on pc.nhan_cong_id equals nc.id
                            where string.IsNullOrEmpty(keyword) || ct.ten.Contains(keyword)
                            select new DTO_PhanCong
                            {
                                CongTrinhId = pc.cong_trinh_id,
                                NhanCongId = pc.nhan_cong_id,
                                NgayBatDau = pc.ngay_bat_dau,
                                NgayKetThuc = pc.ngay_bat_dau,
                                TenCongTrinh = ct.ten,
                                TenNhanCong = nc.ho_ten // Giả sử trường tên công trình là ten_cong_trinh
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_PhanCong>();
            }

        }

    }
}

