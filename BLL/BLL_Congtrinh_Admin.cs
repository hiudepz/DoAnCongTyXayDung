﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLL_Congtrinh_Admin
    {
        private DAL_Congtrinh_Admin ctrDal= new DAL_Congtrinh_Admin();

        public List<CongTrinh> GetConstructionList()
        {
            return ctrDal.GetAllConstruction();
        }

        public List<string> GetStatusList()
        {
            return ctrDal.GetAllStatus();
       
        }

   
        public bool AddConstruction(CongTrinh construction)
        {
            // Validate 
            if (construction.ngay_du_kien_ket_thuc < construction.ngay_bat_dau)
            {
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu");
            }
                
            if (string.IsNullOrEmpty(construction.ten))
            {
                throw new Exception("Không để trống tên");
            }
            if (string.IsNullOrEmpty(construction.dia_diem))
            {
                throw new Exception("Không để trống địa chỉ");
            }
            if (string.IsNullOrEmpty(construction.chu_dau_tu))
            {
                throw new Exception("Không để trống chủ đầu tư");
            }
            return ctrDal.AddConstruction(construction);
        }

       
        public bool DeleteConstruction(int id)
        {
            
            return ctrDal.DeleteConstruction(id);
        }

       
        public bool UpdateConstruction(CongTrinh construction)
        {
            // valite date
            if (construction.ngay_du_kien_ket_thuc < construction.ngay_bat_dau)
                throw new Exception("Ngày kết thúc phải sau ngày bắt đầu");
            if (string.IsNullOrEmpty(construction.ten))
            {
                throw new Exception("Không để trống tên");
            }
            if (string.IsNullOrEmpty(construction.dia_diem))
            {
                throw new Exception("Không để trống địa chỉ");
            }
            if (string.IsNullOrEmpty(construction.chu_dau_tu))
            {
                throw new Exception("Không để trống chủ đầu tư");
            }
            return ctrDal.UpdateConstruction(construction);
        }

        public List<CongTrinh> TimKiem(string tukhoa)
        {
            return ctrDal.TimKiem(tukhoa);
        }
    }
}
