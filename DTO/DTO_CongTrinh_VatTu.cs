using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CongTrinh_VatTu
    {
        public string TenCongTrinh { get; set; }
        public string TenVatTu { get; set; }
        public decimal SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public DateTime NgaySuDung { get; set; }
    }
}
