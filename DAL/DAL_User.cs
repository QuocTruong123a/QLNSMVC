using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
   public class DAL_User:DAL_Connection
    {
        public bool them(DTO_User us)
        {
            string sql = string.Format("insert into Users(Id,Name,Pass,Quyen,TenQuyen,NgayTao) values('{0}',N'{1}','{2}',N'{3}',N'{4}','{5}')",us._Id, us._UserName,us._Pass,us._Quyen,us._TenQuyen,us._NgayTao);
            thucthiketnoi(sql);
            return true;
        }
        public bool sua(DTO_User us)
        {
            string sql = string.Format("UPDATE Users SET Name = '{0}', Pass = '{1}', Quyen = '{2}', TenQuyen = N'{3}',NgayTao ='{4}' WHERE Id ={5} ", us._UserName,us._Pass, us._Quyen, us._TenQuyen,us._NgayTao,us._Id);
            thucthiketnoi(sql);
            return true;
        }
        public bool xoa(int ID)
        {
            string sql = string.Format("DELETE FROM Users WHERE Id = {0}", ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
