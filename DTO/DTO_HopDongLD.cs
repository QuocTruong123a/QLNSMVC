using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_HopDongLD
    {
        private string DTO_MaPhong;
        private int DTO_MaNV;
        private string DTO_HoTen;
        private string DTO_MaTroCap;
        private string DTO_MaLuong;
        private string DTO_GioiTinh;
        private string DTO_TTHonNhan;
        private int DTO_SLCon;
        private string DTO_ChucVu;
        private string DTO_LoaiHD;
        private string DTO_ThoiGian;
        private string DTO_NgayBD;
        private string DTO_NgayKT;
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
        public string _MaLuong
        {
            get
            {
                return DTO_MaLuong;
            }
            set
            {
                DTO_MaLuong = value;
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
        public string _TTHonNhan
        {
            get
            {
                return DTO_TTHonNhan;
            }
            set
            {
                DTO_TTHonNhan = value;
            }
        }
        public int _SLCon
        {
            get
            {
                return DTO_SLCon;
            }
            set
            {
                DTO_SLCon = value;
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
        public string _LoaiHD
        {
            get
            {
                return DTO_LoaiHD;
            }
            set
            {
                DTO_LoaiHD = value;
            }
        }
        public string _ThoiGian
        {
            get
            {
                return DTO_ThoiGian;
            }
            set
            {
                DTO_ThoiGian = value;
            }
        }
        public string _NgayBD
        {
            get
            {
                return DTO_NgayBD;
            }
            set
            {
                DTO_NgayBD = value;
            }
        }
        public string _NgayKT
        {
            get
            {
                return DTO_NgayKT;
            }
            set
            {
                DTO_NgayKT = value;
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
        public DTO_HopDongLD(string MaPhong, int MaNV, string HoTen,string MaTroCap, string MaLuong, string GioiTinh, string TTHonNhan, int SLCon, string ChucVu, string LoaiHD, string ThoiGian, string NgayBD, string NgayKT, string GhiChu)
        {
            this.DTO_MaPhong = MaPhong;
            this.DTO_MaNV = MaNV;
            this.DTO_HoTen = HoTen;
            this.DTO_MaTroCap = MaTroCap;
            this.DTO_MaLuong = MaLuong;
            this.DTO_GioiTinh = GioiTinh;
            this.DTO_TTHonNhan = TTHonNhan;
            this.DTO_SLCon = SLCon;
            this.DTO_ChucVu = ChucVu;
            this.DTO_LoaiHD = LoaiHD;
            this.DTO_ThoiGian = ThoiGian;
            this.DTO_NgayBD = NgayBD;
            this.DTO_NgayKT = NgayKT;
            this.DTO_GhiChu = GhiChu;
        }
    }
}
