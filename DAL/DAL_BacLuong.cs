using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ClassLibrary2;
namespace DAL
{
    public class DAL_BacLuong : DAL_Connection
    {
        public bool Them(DTO_BacLuong bl)
        {
            string sql = string.Format("insert into BacLuong(MaLuong, LCB, NgayTao) values('{0}','{1}','{2}')", bl._MaLuong, bl._LCB, bl._NgayTao);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_BacLuong bl) 
        {
            string sql = string.Format("update BacLuong set LCB = '{0}', NgayTao = '{1}' where MaLuong ='{2}'", bl._LCB, bl._NgayTao, bl._MaLuong);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from BacLuong where MaLuong ='{0}'", ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
