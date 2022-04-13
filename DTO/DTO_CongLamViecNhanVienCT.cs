using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CongLamViecNhanVienCT
    {
        private int DTO_MaNV;
        private int DTO_LuongCB;
        private int DTO_TienTroCap;
        private string DTO_HoTen;
        private int DTO_SoNgayCong;
        private int DTO_SoNgayNghi;
        private int DTO_Thang;
        private int DTO_Nam;
        private int DTO_TangCa;
        private int DTO_Luong;
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
        public int _LuongCB
        {
            get
            {
                return DTO_LuongCB;
            }
            set
            {
                DTO_LuongCB = value;
            }
        }
        public int _TienTroCap
        {
            get
            {
                return DTO_TienTroCap;
            }
            set
            {
                DTO_TienTroCap = value;
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
        public int _SoNgayCong
        {
            get
            {
                return DTO_SoNgayCong;
            }
            set
            {
                DTO_SoNgayCong = value;
            }
        }
        public int _SoNgayNghi
        {
            get
            {
                return DTO_SoNgayNghi;
            }
            set
            {
                DTO_SoNgayNghi = value;
            }
        }
        public int _Thang
        {
            get
            {
                return DTO_Thang;
            }
            set
            {
                DTO_Thang = value;
            }
        }
        public int _Nam
        {
            get
            {
                return DTO_Nam;
            }
            set
            {
                DTO_Nam = value;
            }
        }
        public int _TangCa
        {
            get
            {
                return DTO_TangCa;
            }
            set
            {
                DTO_TangCa = value;
            }
        }
        public int _Luong
        {
            get
            {
                return DTO_Luong;
            }
            set
            {
                DTO_Luong = value;
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

        public DTO_CongLamViecNhanVienCT(int MaNV, int LuongCB, int TienTroCap, string HoTen, int SoNgayCong, int SoNgayNghi, int Thang, int Nam, int SoGioTangCa, int Luong, string GhiChu)
        {
            this.DTO_MaNV = MaNV;
            this.DTO_LuongCB = LuongCB;
            this.DTO_TienTroCap = TienTroCap;
            this.DTO_HoTen = HoTen;
            this.DTO_SoNgayCong = SoNgayCong;
            this.DTO_SoNgayNghi = SoNgayNghi;
            this.DTO_Thang = Thang;
            this.DTO_Nam = Nam;
            this.DTO_TangCa = SoGioTangCa;
            this.DTO_Luong = Luong;
            this.DTO_GhiChu = GhiChu;
        }
    }
}
