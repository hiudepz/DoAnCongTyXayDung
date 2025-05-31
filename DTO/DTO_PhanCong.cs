using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhanCong
    {
        public int CongTrinhId { get; set; }
        public int NhanCongId { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public string TenCongTrinh { get; set; }
        public string TenNhanCong { get; set; }
    }
}
