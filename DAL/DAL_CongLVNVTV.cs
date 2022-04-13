using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_CongLVNVTV : DAL_Connection
    {
        public bool Them(DTO_CongLamViecNhanVienTV TV)
        {
            string sql = string.Format("insert into CongLamViecNVTV(MaNV, TenNV, LuongCB, Thang, Nam, SoNgayCong, SoNgayNghi, SoGioLamThem, TroCap, Luong, GhiChu) values('{0}', N'{1}', '{2}', '{3}', '{4}','{5}', '{6}', '{7}', '{8}', '{9}',N'{10}')", TV._MaNV, TV._TenNV, TV._LuongCB, TV._Thang, TV._Nam, TV._SoNgayCong, TV._SoNgayNghi, TV._TangCa,TV._TroCap, TV._Luong, TV._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_CongLamViecNhanVienTV TV)
        {
            string sql = string.Format("update CongLamViecNVTV set TenNV=N'{0}', LuongCB ='{1}', Thang='{2}', Nam='{3}', SoNgayCong='{4}', SoNgayNghi='{5}', SoGioLamThem='{6}', TroCap='{7}', Luong='{8}', GhiChu='{9}' where  MaNV='{10}'",  TV._TenNV, TV._LuongCB, TV._Thang, TV._Nam, TV._SoNgayCong, TV._SoNgayNghi, TV._TangCa, TV._TroCap, TV._Luong, TV._GhiChu, TV._MaNV);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string MaNV)
        {
            string sql = string.Format("delete from CongLamViecNVTV where MaNV='{0}' ", MaNV);
            thucthiketnoi(sql);
            return true;
        }
    }
}
