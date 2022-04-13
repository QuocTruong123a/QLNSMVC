using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_CongLVNVTV : DAL_Connection
    {
        DAL_CongLVNVTV daltv = new DAL_CongLVNVTV();
        public bool Them(DTO_CongLamViecNhanVienTV dtotv)
        {
            return daltv.Them(dtotv);
        }
        public bool Sua(DTO_CongLamViecNhanVienTV dtotv)
        {
            return daltv.Sua(dtotv);
        }
        public bool Xoa(string nvtv)
        {
            return daltv.Xoa(nvtv);
        }
    }
}
