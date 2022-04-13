using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_PhongBan
    {
        private string DTO_MaPhong;
        private string DTO_TenPhong;
        private string DTO_GhiChu;
        public string _MaPhong
        {
            get
            {
                return DTO_MaPhong;
            }
            set
            {
                DTO_MaPhong = value;
            }
        }
        public string _TenPhong
        {
            get
            {
                return DTO_TenPhong;
            }
            set
            {
                DTO_TenPhong = value;
            }
        }
        public string _GhiChu
        {
            get
            {
                return DTO_GhiChu;
            }
            set
            {
                DTO_GhiChu = value;
            }
        }
        public DTO_PhongBan(string MaPhong, string TenPhong, string GhiChu)
        {
            this.DTO_MaPhong = MaPhong;
            this.DTO_TenPhong = TenPhong;
            this.DTO_GhiChu = GhiChu;
        }
    }
}
