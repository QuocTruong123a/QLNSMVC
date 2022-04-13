using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TTNhanVien
    {
        private int DTO_MaNV;
        private string DTO_HoTen;
        private int DTO_CMTND;
        private string DTO_NoiCap;
        private string DTO_GioiTinh;
        private string DTO_NoiSinh;
        private string DTO_NgaySinh;
        private string DTO_DCThuongTru;
        private string DTO_DCTamTru;
        private int DTO_SDT;
        private string DTO_DanToc;
        private string DTO_TonGiao;
        private string DTO_QuocTich;
        private string DTO_HocVan;
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
        public int _CMTND
        {
            get
            {
                return DTO_CMTND;
            }
            set
            {
                DTO_CMTND = value;
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
        public string _GioiTinh
        {
            get
            {
                return DTO_GioiTinh;
            }
            set
            {
                DTO_GioiTinh = value;
            }
        }
        public string _NoiSinh
        {
            get
            {
                return DTO_NoiSinh;
            }
            set
            {
                DTO_NoiSinh = value;
            }
        }
        public string _NgaySinh
        {
            get
            {
                return DTO_NgaySinh;
            }
            set
            {
                DTO_NgaySinh = value;
            }
        }
        public string _DCThuoungTru
        {
            get
            {
                return DTO_DCThuongTru;
            }
            set
            {
                DTO_DCThuongTru = value;
            }
        }
        public string _DCTamTru
        {
            get
            {
                return DTO_DCTamTru;
            }
            set
            {
                DTO_DCTamTru = value;
            }
        }
        public int _SDT {
            get
            {
                return DTO_SDT;
            }
            set
            {
                DTO_SDT = value;
            }
        }
        public string _DanToc
        {
            get
            {
                return DTO_DanToc;
            }
            set
            {
                DTO_DanToc = value;
            }
        }
        public string _TonGiao
        {
            get
            {
                return DTO_TonGiao;
            }
            set
            {
                DTO_TonGiao = value;
            }
        }
        public string _QuocTich
        {
            get
            {
                return DTO_QuocTich;
            }
            set
            {
                DTO_QuocTich = value;
            }
        }
        public string _HocVan
        {
            get
            {
                return DTO_HocVan;
            }
            set
            {
                DTO_HocVan = value;
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
        public DTO_TTNhanVien(int ManV, string HoTen, int CMTND, string NoiCap, string GioiTinh, string NoiSinh, string NgaySinh, string DCThuongTru, string DCTamTru, int SDT, string DanToc, string TonGiao, string QuocTich, string HocVan, string GhiChu)
        {
            this.DTO_MaNV = ManV;
            this.DTO_HoTen = HoTen;
            this.DTO_CMTND = CMTND;
            this.DTO_NoiCap = NoiCap;
            this.DTO_GioiTinh = GioiTinh;
            this.DTO_NoiSinh = NoiSinh;
            this.DTO_NgaySinh = NgaySinh;
            this.DTO_DCThuongTru = DCThuongTru;
            this.DTO_DCTamTru = DCTamTru;
            this.DTO_SDT = SDT;
            this.DTO_DanToc = DanToc;
            this.DTO_TonGiao = TonGiao;
            this.DTO_QuocTich = QuocTich;
            this.DTO_HocVan = HocVan;
            this.DTO_GhiChu = GhiChu;
        }
    }
}
