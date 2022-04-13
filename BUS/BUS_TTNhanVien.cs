using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_TTNhanVien :DAL_Connection
    {
        DAL_TTNhanVien dalnv = new DAL_TTNhanVien();

        public bool Them(DTO_TTNhanVien dtonv)
        {
            return dalnv.Them(dtonv);
        }
        public bool Sua(DTO_TTNhanVien dtonv)
        {
            return dalnv.Sua(dtonv);
        }
        public bool Xoa(string nv)
        {
            return dalnv.Xoa(nv);
        }
    }
}
