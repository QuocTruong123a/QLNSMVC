using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DTO_XetTL
    {
        private int DTO_MaNV;
        private string DTO_HoTen;
        private string DTO_ChucVu;
        private string DTO_LyDo;
        private string DTO_GhiChu;
        public int _MaNV
        {
            get
            {
                return DTO_MaNV;
            }
            set
            {
                DTO_MaNV = value;
            }
        }
        public string _HoTen
        {
            get
            {
                return DTO_HoTen;
            }
            set
            {
                DTO_HoTen = value;
            }
        }
        public string _ChucVu
        {
            get
            {
                return DTO_ChucVu;
            }
            set
            {
                DTO_ChucVu = value;
            }
        }
        public string _LyDo
        {
            get
            {
                return DTO_LyDo;
            }
            set
            {
                DTO_LyDo = value;
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
        public DTO_XetTL(int ManV, string HoTen, string ChucVu, string LyDo, string GhiChu)
        {
            this.DTO_MaNV = ManV;
            this.DTO_HoTen = HoTen;
            this.DTO_ChucVu = ChucVu;
            this.DTO_LyDo = LyDo;
            this.DTO_GhiChu = GhiChu;
        }
    }
}
