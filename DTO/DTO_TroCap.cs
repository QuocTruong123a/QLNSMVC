using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TroCap
    {
        private string DTO_MaTroCap;
        private int DTO_PCCV;
        private int DTO_PCDL;
        private int DTO_PCTTro;
        private int DTO_PCCon;
        private int DTO_PCKhac;
        private string DTO_Tong;
        private string DTO_GhiChu;
        public string _MaTroCap
        {
            get
            {
                return DTO_MaTroCap;
            }
            set
            {
                DTO_MaTroCap = value;
            }
        }
        public int _PCCV
        {
            get
            {
                return DTO_PCCV;
            }
            set
            {
                DTO_PCCV = value;
            }
        }
        public int _PCDL
        {
            get
            {
                return DTO_PCDL;
            }
            set
            {
                DTO_PCDL = value;
            }
        }
        public int _PCTTro
        {
            get
            {
                return DTO_PCTTro;
            }
            set
            {
                DTO_PCTTro = value;
            }
        }
        public int _PCCon
        {
            get
            {
                return DTO_PCCon;
            }
            set
            {
                DTO_PCCon = value;
            }
        }
        public int _PCKhac
        {
            get
            {
                return DTO_PCKhac;
            }
            set
            {
                DTO_PCKhac = value;
            }
        }
        public string _Tong
        {
            get
            {
                return DTO_Tong;
            }
            set
            {
                DTO_Tong = value;
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
        public DTO_TroCap(string MaTroCap, int PCCV, int PCDL, int PCTTro, int PCCon, int PCKhac,string Tong, string GhiChu)
        {
            this.DTO_MaTroCap = MaTroCap;
            this.DTO_PCCV = PCCV;
            this.DTO_PCDL = PCDL;
            this.DTO_PCTTro = PCTTro;
            this.DTO_PCCon = PCCon;
            this.DTO_PCKhac = PCKhac;
            this.DTO_Tong = Tong;
            this.DTO_GhiChu = GhiChu;
        }
    }
}
