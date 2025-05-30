using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_TienDo_Admin
    {
        private CTYXAYDUNGDataContext db = DB.GetContext();

        public List<DTO_TienDo> GetAllProgress()
        {
            try
            {
                var query = from td in db.TienDos
                            join ct in db.CongTrinhs on td.cong_trinh_id equals ct.id
                            select new DTO_TienDo
                            {
                                Id = td.id,
                                CongTrinhId = (int)td.cong_trinh_id,
                                NgayCapNhat = (DateTime)td.ngay_cap_nhat,
                                MoTa = td.mo_ta,
                                PhanTramHoanThanh = (decimal)td.phan_tram_hoan_thanh,
                                TenCongTrinh = ct.ten // Giả sử trường tên công trình là ten_cong_trinh
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_TienDo>();
            }

        }
        public List<TienDo> GetByTienDo()
        {
            using (var db = DB.GetContext())
            {
                return db.TienDos
                        .OrderBy(t => t.ngay_cap_nhat)
                        .ToList();
            }
        }
        public List<string> GetByCongTrinh(int congTrinhId)
        {
            return db.CongTrinhs.Where(t => t.id == congTrinhId)
       .Select(t => t.ten).ToList();
        }
        public bool AddProgress(TienDo contractor)
        {
            try
            {
                db.TienDos.InsertOnSubmit(contractor);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteProgress(int id)
        {
            try
            {
                var contractor = db.TienDos.FirstOrDefault(ct => ct.id == id);
                if (contractor != null)
                {
                    db.TienDos.DeleteOnSubmit(contractor);
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

        // Update Progress
        public bool UpdateProgress(TienDo updatedProgress)
        {
            try
            {
                using (var db = DB.GetContext()) // Thêm using để đảm bảo giải phóng tài nguyên
                {
                    var existing = db.TienDos.FirstOrDefault(ct => ct.id == updatedProgress.id);
                    if (existing != null)
                    {

                        existing.cong_trinh_id = updatedProgress.cong_trinh_id;
                        existing.ngay_cap_nhat = updatedProgress.ngay_cap_nhat;
                        existing.mo_ta = updatedProgress.mo_ta;
                        existing.phan_tram_hoan_thanh = updatedProgress.phan_tram_hoan_thanh;


                        //// Xử lý ngày hoàn thành nếu có
                        //if (updatedProgress.ngay_hoan_thanh.HasValue)
                        //    existing.ngay_hoan_thanh = updatedProgress.ngay_hoan_thanh;

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
        public List<CongTrinh> GetAllCongTrinh()
        {
            return db.CongTrinhs.ToList();
        }
        public List<DTO_TienDo> GetAllProgressTK(string keyword = "")
        {
            try
            {
                var query = from td in db.TienDos
                            join ct in db.CongTrinhs on td.cong_trinh_id equals ct.id
                            where string.IsNullOrEmpty(keyword) || ct.ten.Contains(keyword)
                            select new DTO_TienDo
                            {
                                Id = td.id,
                                CongTrinhId = (int)td.cong_trinh_id,
                                NgayCapNhat = (DateTime)td.ngay_cap_nhat,
                                MoTa = td.mo_ta,
                                PhanTramHoanThanh = (decimal)td.phan_tram_hoan_thanh,
                                TenCongTrinh = ct.ten
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_TienDo>();
            }
        }

    }
}
