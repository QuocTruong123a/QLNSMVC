using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_SoBH : DAL_Connection
    {
        public bool Them(DTO_SoBH bh)
        {
            string sql = string.Format("insert into SoBH(MaSBH, MaNV, NgayCap, NoiCap, GhiChu) values('{0}','{1}','{2}','{3}','{4}')",bh._MaSoBH,bh._MaNV,bh._NgayCap,bh._NoiCap,bh._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_SoBH bh)
        {
            string sql = string.Format("update SoBH set MaNV='{0}', NgayCap='{1}', NoiCap='{2}', GhiChu='{3}' where MaSBH ='{4}'",bh._MaNV, bh._NgayCap, bh._NoiCap, bh._GhiChu,bh._MaSoBH);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from SoBH where MaSBH ='{0}'",ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
