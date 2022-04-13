using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_TroCap : DAL_Connection
    {
        public bool Them(DTO_TroCap tc)
        {
            string sql = string.Format("insert into TroCap(MaTroCap, PCCV, PCDL, PCTTro, PCCon, PCKhac,Tong, GhiChu) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",tc._MaTroCap,tc._PCCV,tc._PCDL,tc._PCTTro,tc._PCCon,tc._PCKhac,tc._Tong,tc._GhiChu);
            thucthiketnoi(sql);
            return true;
        }
        public bool Sua(DTO_TroCap tc)
        {
            string sql = string.Format("update TroCap set PCCV='{0}', PCDL='{1}', PCTTro='{2}', PCCon='{3}', PCKhac='{4}',Tong ='{5}', GhiChu='{6}' where MaTroCap='{7}'", tc._PCCV, tc._PCDL, tc._PCTTro, tc._PCCon, tc._PCKhac,tc._Tong, tc._GhiChu, tc._MaTroCap);
            thucthiketnoi(sql);
            return true;
        }
        public bool Xoa(string ID)
        {
            string sql = string.Format("delete from TroCap where MaTroCap='{0}'",ID);
            thucthiketnoi(sql);
            return true;
        }
    }
}
