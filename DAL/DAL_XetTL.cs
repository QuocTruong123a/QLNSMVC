using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_XetTL : DAL_Connection
    {
        public bool Them(DTO_XetTL tl)
        {
            string sql = string.Format("insert into XetTL(MaNV, HoTen, ChucVu, LyDo, GiChu) values('{0}','{1}','{2}','{3}','{4}')",tl._MaNV,tl._HoTen,tl._ChucVu,tl._LyDo,tl._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_XetTL tl)
        {
            string sql = string.Format("update XetTL set( HoTen='{0}', ChucVu='{1}', LyDo='{2}', GiChu='{3}') where MaNV ='{4}' ", tl._HoTen, tl._ChucVu, tl._LyDo, tl._GhiChu, tl._MaNV);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from XetTL where MaNV ='{0}'",ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
