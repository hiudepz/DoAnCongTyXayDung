using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Nhancong_Admin
    {
        CTYXAYDUNGDataContext db = new CTYXAYDUNGDataContext();

        public List<NhanCong> GetAllMember()
        {

            //try
            //{
            //    using (var db = new CTYXAYDUNGDataContext())
            //    {
            //        return db.NhanCongs
            //               .Select(ct => new NhanCong 
            //               {
            //                   id = ct.id,
            //                   ten = ct.ten,
            //                   dia_diem = ct.dia_diem,
            //                   chu_dau_tu = ct.chu_dau_tu,
            //                   ngay_bat_dau = ct.ngay_bat_dau,
            //                   ngay_du_kien_ket_thuc = ct.ngay_du_kien_ket_thuc,
            //                   trang_thai = ct.trang_thai,
            //                   tong_muc_dau_tu = ct.tong_muc_dau_tu,
            //                   hinh_anh = ct.hinh_anh

            //               })
            //               .ToList();
            //    }
            //}
            //catch
            //{
            //    return new List<NhanCong>();// return to empty instead null
            //}

            try
            {
                using (var db = new CTYXAYDUNGDataContext())
                {
                    return db.NhanCongs.ToList() ?? new List<NhanCong>();
                }
            }
            catch
            {
                return new List<NhanCong>(); // return to empty instead null
            }
        }

        //public List<string> GetAllStatus()
        //{

        //    var statusMember = db.NhanCongs.Select(x => x.trang_thai).Distinct().ToList();

        //    //Default list
        //    var defStatus = new List<string>
        //         {
        //             "Chưa bắt đầu",
        //             "Đang thi công",
        //             "Tạm dừng",
        //             "Đã hoàn thành"
        //         };
        //    //merge statusConstuction n defStatus
        //    return defStatus.Union(statusMember).OrderBy(x => x).ToList();
        //}

        // Add contruction
        public bool AddMember(NhanCong Member)
        {
            try
            {
                db.NhanCongs.InsertOnSubmit(Member);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // DeleteMember
        public bool DeleteMember(int id)
        {
            try
            {
                var Member = db.NhanCongs.FirstOrDefault(ct => ct.id == id);
                if (Member != null)
                {
                    db.NhanCongs.DeleteOnSubmit(Member);
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

        // Update Member
        public bool UpdateMember(NhanCong updatedMember)
        {
            try
            {
                using (var db = new CTYXAYDUNGDataContext()) // Thêm using để đảm bảo giải phóng tài nguyên
                {
                    var existing = db.NhanCongs.FirstOrDefault(ct => ct.id == updatedMember.id);
                    if (existing != null)
                    {

                        existing.ho_ten = updatedMember.ho_ten;
                        existing.chuc_vu = updatedMember.chuc_vu;
                        existing.luong_ngay = updatedMember.luong_ngay;
                        existing.so_dien_thoai = updatedMember.so_dien_thoai;

                        //// Xử lý ngày hoàn thành nếu có
                        //if (updatedMember.ngay_hoan_thanh.HasValue)
                        //    existing.ngay_hoan_thanh = updatedMember.ngay_hoan_thanh;

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
    }
}
