using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_HopDongLD : DAL_Connection
    {
        public bool Them(DTO_HopDongLD ld)
        {
            string sql = string.Format("insert into HopDongLD(MaPhong, MaNV, HovaTen, MaTroCap, MaLuong, GioiTinh, TTHonNhan, SlCon, ChucVu, LoaiHD, ThoiGian, NgayBD, NgayKT, GhiChu ) values('{0}','{1}',N'{2}','{3}','{4}',N'{5}',N'{6}','{7}',N'{8}',N'{9}',N'{10}','{11}','{12}',N'{13}')", ld._MaPhong, ld._MaNV, ld._HoTen, ld._MaTroCap, ld._MaLuong, ld._GioiTinh, ld._TTHonNhan, ld._SLCon, ld._ChucVu, ld._LoaiHD, ld._ThoiGian, ld._NgayBD, ld._NgayKT, ld._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_HopDongLD ld)
        {
            string sql = string.Format("update HopDongLD  set MaPhong='{0}', HovaTen=N'{1}', MaTroCap='{2}', MaLuong='{3}', GioiTinh=N'{4}', TTHonNhan=N'{5}', SlCon='{6}', ChucVu=N'{7}', LoaiHD=N'{8}', ThoiGian=N'{9}', NgayBD='{10}', NgayKT='{11}', GhiChu=N'{12}' where MaNV='{13}' ", ld._MaPhong, ld._HoTen, ld._MaTroCap , ld._MaLuong, ld._GioiTinh, ld._TTHonNhan, ld._SLCon, ld._ChucVu, ld._LoaiHD, ld._ThoiGian, ld._NgayBD, ld._NgayKT, ld._GhiChu, ld._MaNV);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from HopDongLD where MaNV='{0}' ", ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
