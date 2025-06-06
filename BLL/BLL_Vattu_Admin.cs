﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Vattu_Admin
    {
        private DAL_Vattu_Admin ctrDal = new DAL_Vattu_Admin();

        public List<VatTu> GetMaterialList()
        {
            return ctrDal.GetAllMaterial();
        }

        //public List<string> GetStatusList()
        //{
        //    return ctrDal.GetAllStatus();

        //}

        public List<string> GetNameMaterialList()
        {
            return ctrDal.GetAllNameMaterials();
        }
        public bool AddMaterial(VatTu material)
        {

            if (string.IsNullOrEmpty(material.ten))
            {
                throw new Exception("Không được để trống tên");
            }
            return ctrDal.AddMaterial(material);
        }


        public bool DeleteMaterial(int id)
        {

            return ctrDal.DeleteMaterial(id);
        }


        public bool UpdateMaterial(VatTu material)
        {
      

            return ctrDal.UpdateMaterial(material);
        }

        public List<VatTu> TimKiem(string tukhoa)
        {
            return ctrDal.TimKiem(tukhoa);
        }

    }
}
