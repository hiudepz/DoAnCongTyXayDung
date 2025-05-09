using DTO;
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
        public List<DTO_CongTrinh_NhaThau> GetAllCTNT()
        {
            try
            {
                var query = from ct_nt in db.CongTrinh_NhaThaus
                            join ct in db.CongTrinhs on ct_nt.cong_trinh_id equals ct.id
                            join nt in db.NhaThaus on ct_nt.nha_thau_id equals nt.id
                            
                            select new DTO_CongTrinh_NhaThau
                            {
                                TenCongTrinh = ct.ten, // Giả sử trường tên công trình là ten_cong_trinh
                                TenNhaThau = nt.ten_cong_ty,
                                VaiTro = ct_nt.vai_tro,
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_CongTrinh_NhaThau>();
            }
        }

        public List<NhaThau> GetAllNhaThau()
        {
            return db.NhaThaus.Distinct().ToList();
        }

        public List<CongTrinh> GetAllCT()
        {
            return db.CongTrinhs.Distinct().ToList();
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
                   
                if(existing != null)
                {
                    existing.vai_tro = what.vai_tro;
                    db.SubmitChanges();
                    return true;
                }
                      
                    
                    
                }
                catch
                {
                    return false;
                }
            return false;
            }
        public List<DTO_CongTrinh_NhaThau> GetAllCTNTTK(string keyword = "")
        {
            try
            {
                var query = from ct_nt in db.CongTrinh_NhaThaus
                            join ct in db.CongTrinhs on ct_nt.cong_trinh_id equals ct.id
                            join nt in db.NhaThaus on ct_nt.nha_thau_id equals nt.id
                            where string.IsNullOrEmpty(keyword) || ct.ten.Contains(keyword)
                            select new DTO_CongTrinh_NhaThau
                            {
                                TenCongTrinh = ct.ten, // Giả sử trường tên công trình là ten_cong_trinh
                                TenNhaThau = nt.ten_cong_ty,
                                VaiTro = ct_nt.vai_tro,
                            };

                return query.ToList();
            }
            catch
            {
                return new List<DTO_CongTrinh_NhaThau>();
            }
        }
    
}    
}
