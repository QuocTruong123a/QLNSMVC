using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_CongLVNVCT : DAL_Connection
    {
        public bool Them(DTO_CongLamViecNhanVienCT ct)
        {
            string sql = string.Format("insert into CongLamViecNVCT(MaNV, LuongCB, TienTroCap, HoTen, SoNgayCong, SoNgayNghi, Thang, Nam, SoGioLamTangCa, Luong, GhiChu) values('{0}','{1}','{2}',N'{3}','{4}','{5}','{6}','{7}','{8}','{9}',N'{10}')", ct._MaNV, ct._LuongCB, ct._TienTroCap, ct._HoTen, ct._SoNgayCong, ct._SoNgayNghi, ct._Thang, ct._Nam, ct._TangCa, ct._Luong, ct._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_CongLamViecNhanVienCT ct)
        {
            string sql = string.Format("update CongLamViecNVCT set LuongCB='{0}', TienTroCap='{1}', HoTen=N'{2}', SoNgayCong='{3}', SoNgayNghi='{4}', Thang='{5}', Nam='{6}', SoGioLamTangCa='{7}', Luong='{8}', GhiChu=N'{9}' where MaNV='{10}'",ct._LuongCB, ct._TienTroCap, ct._HoTen, ct._SoNgayCong, ct._SoNgayNghi, ct._Thang, ct._Nam, ct._TangCa, ct._Luong, ct._GhiChu, ct._MaNV);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from CongLamViecNVCT where MaNV = '{0}' ", ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
