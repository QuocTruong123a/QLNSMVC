using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_CongLVNVCT : DAL_Connection
    {
        DAL_CongLVNVCT dalct = new DAL_CongLVNVCT();

        public bool Them(DTO_CongLamViecNhanVienCT dtoct)
        {
            return dalct.Them(dtoct);
        }
        public bool Sua(DTO_CongLamViecNhanVienCT dtoct)
        {
            return dalct.Sua(dtoct);
        }
        public bool Xoa(string nvct)
        {
            return dalct.Xoa(nvct);
        }

    }
}
