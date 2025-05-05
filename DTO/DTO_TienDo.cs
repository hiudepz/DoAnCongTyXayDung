using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TienDo
    {
        public int Id { get; set; }
        public int CongTrinhId { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public string MoTa { get; set; }
        public decimal PhanTramHoanThanh { get; set; }
        public string TenCongTrinh { get; set; }
    }
}
