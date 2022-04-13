using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_PhongBan : DAL_Connection
    {
        public bool Them(DTO_PhongBan pb)
        {
            string sql = string.Format("insert into PhongBan(MaPhong, TenPhong, GhiChu) values('{0}',N'{1}','{2}')",pb._MaPhong,pb._TenPhong,pb._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_PhongBan pb)
        {
            string sql = string.Format("update PhongBan set TenPhong=N'{0}', GhiChu='{1}' where MaPhong ='{2}'", pb._TenPhong, pb._GhiChu,pb._MaPhong);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from PhongBan where MaPhong ='{0}'",ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
