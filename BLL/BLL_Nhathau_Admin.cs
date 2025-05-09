using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Nhathau_Admin
    {
        private DAL_Nhathau_Admin ctrDal = new DAL_Nhathau_Admin();
        //public List<NhaThau> GetTheThingIWant()
        //{
        //    return ctrDal.GetWhatIWant();
        //}

        public List<string> GetNameContractorList()
        {
            return ctrDal.GetAllNameContractor();

        }
        public List<NhaThau> GetContractorList()
        {
            return ctrDal.GetAllContractor();
        }

        //public List<string> GetStatusList()
        //{
        //    return ctrDal.GetAllStatus();

        //}


        public bool AddContractor(NhaThau contractor)
        {
            // Validate 
            if (contractor == null)
            {
                throw new ArgumentNullException(nameof(contractor), "Đối tượng nhà thầu không được null");
            }

            // Validate các trường bắt buộc
            if (string.IsNullOrWhiteSpace(contractor.ten_cong_ty))
            {
                throw new ArgumentException("Tên công ty không được để trống");
            }

            if (string.IsNullOrWhiteSpace(contractor.ma_so_thue))
            {
                throw new ArgumentException("Mã số thuế không được để trống");
            }

            if (string.IsNullOrWhiteSpace(contractor.dia_chi))
            {
                throw new ArgumentException("Địa chỉ không được để trống");
            }

            // Validate định dạng email nếu có
            if (!string.IsNullOrWhiteSpace(contractor.email) &&
                !Regex.IsMatch(contractor.email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("Email không hợp lệ");
            }

            // Validate số điện thoại
            if (!string.IsNullOrWhiteSpace(contractor.so_dien_thoai) &&
                !Regex.IsMatch(contractor.so_dien_thoai, @"^0\d{9,10}$"))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ");
            }
            return ctrDal.AddContractor(contractor);
        }


        public bool DeleteContractor(int id)
        {

            return ctrDal.DeleteContractor(id);
        }


        public bool UpdateContractor(NhaThau contractor)
        {
            // Validate 
            if (contractor == null)
            {
                throw new ArgumentNullException(nameof(contractor), "Đối tượng nhà thầu không được null");
            }

            // Validate các trường bắt buộc
            if (string.IsNullOrWhiteSpace(contractor.ten_cong_ty))
            {
                throw new ArgumentException("Tên công ty không được để trống");
            }

            if (string.IsNullOrWhiteSpace(contractor.ma_so_thue))
            {
                throw new ArgumentException("Mã số thuế không được để trống");
            }

            if (string.IsNullOrWhiteSpace(contractor.dia_chi))
            {
                throw new ArgumentException("Địa chỉ không được để trống");
            }

            // Validate định dạng email nếu có
            if (!string.IsNullOrWhiteSpace(contractor.email) &&
                !Regex.IsMatch(contractor.email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new ArgumentException("Email không hợp lệ");
            }

            // Validate số điện thoại
            if (!string.IsNullOrWhiteSpace(contractor.so_dien_thoai) &&
                !Regex.IsMatch(contractor.so_dien_thoai, @"^0\d{9,10}$"))
            {
                throw new ArgumentException("Số điện thoại không hợp lệ");
            }


            return ctrDal.UpdateContractor(contractor);
        }
        public List<NhaThau> TimKiem(string tukhoa)
        {
            return ctrDal.TimKiem(tukhoa);
        }
    }
}
