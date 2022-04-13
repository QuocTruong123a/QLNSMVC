using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SoBH
    {
        private string DTO_MaSoBH;
        private int DTO_MaNV;
        private string DTO_NgayCap;
        private string DTO_NoiCap;
        private string DTO_GhiChu;
        public string _MaSoBH
        {
            get
            {
                return DTO_MaSoBH;
            }
            set
            {
                DTO_MaSoBH = value;
            }
        }
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
        public string _NgayCap
        {
            get
            {
                return DTO_NgayCap;
            }
            set
            {
                DTO_NgayCap = value;
            }
        }
        public string _NoiCap
        {
            get
            {
                return DTO_NoiCap;
            }
            set
            {
                DTO_NoiCap = value;
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
        public DTO_SoBH(string MaSoBH, int ManV, string NgayCap, string NoiCap, string GhiChu)
        {
            this.DTO_MaSoBH = MaSoBH;
            this.DTO_MaNV = ManV;
            this.DTO_NgayCap = NgayCap;
            this.DTO_NoiCap = NoiCap;
            this.DTO_GhiChu = GhiChu;
        }
    }
}
