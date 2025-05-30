using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Nhathau_Admin
    {
        private CTYXAYDUNGDataContext db = DB.GetContext();
        //dgvNhathaubencongtrinh_admin

        //public class NhaThauSimple
        //{
        //    public int id { get; set; }
        //    public string ten_cong_ty { get; set; }
        //    public string ma_so_thue { get; set; }
        //}
        //public List<NhaThau> GetWhatIWant()
        //{
        //    try
        //    {
        //        using (var db = new CTYXAYDUNGDataContext())
        //        {
        //            return db.NhaThaus
        //                   .Select(nt => new NhaThau
        //                   {
        //                       id = nt.id, // Cần id để làm khóa nếu có chọn dòng
        //                       ten_cong_ty = nt.ten_cong_ty,
        //                       ma_so_thue = nt.ma_so_thue
        //                   })
        //                   .ToList();
        //        }
        //    }
        //    catch
        //    {
        //        return new List<NhaThau>();
        //    }
        //}


        public List<string> GetAllNameContractor()
        {

            return db.NhaThaus.Select(x => x.ten_cong_ty).Distinct().ToList();

            
            
        }
        public List<NhaThau> GetAllContractor()
        {

            try
            {
                using (var db = DB.GetContext())
                {
                    return db.NhaThaus.ToList() ?? new List<NhaThau>();
                }
            }
            catch
            {
                return new List<NhaThau>(); // return to empty instead null
            }

        }


        public bool AddContractor(NhaThau contractor)
        {
            try
            {
                db.NhaThaus.InsertOnSubmit(contractor);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteContractor(int id)
        {
            try
            {
                var contractor = db.NhaThaus.FirstOrDefault(ct => ct.id == id);
                if (contractor != null)
                {
                    db.NhaThaus.DeleteOnSubmit(contractor);
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

        // Update Contractor
        public bool UpdateContractor(NhaThau updatedContractor)
        {
            try
            {
                using (var db = DB.GetContext()) // Thêm using để đảm bảo giải phóng tài nguyên
                {
                    var existing = db.NhaThaus.FirstOrDefault(ct => ct.id == updatedContractor.id);
                    if (existing != null)
                    {

                        existing.ten_cong_ty = updatedContractor.ten_cong_ty;
                        existing.ma_so_thue = updatedContractor.ma_so_thue;
                        existing.dia_chi = updatedContractor.dia_chi;
                        existing.nguoi_dai_dien = updatedContractor.nguoi_dai_dien;
                        existing.so_dien_thoai = updatedContractor.so_dien_thoai;
                        existing.email = updatedContractor.email;
                        

                        //// Xử lý ngày hoàn thành nếu có
                        //if (updatedContractor.ngay_hoan_thanh.HasValue)
                        //    existing.ngay_hoan_thanh = updatedContractor.ngay_hoan_thanh;

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
        public List<NhaThau> TimKiem(string tukhoa)
        {
            return db.NhaThaus.Where(t => t.ten_cong_ty.Contains(tukhoa)).ToList();
        }
    }
}
