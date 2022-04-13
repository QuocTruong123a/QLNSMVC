using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_XetTL :DAL_Connection
    {
        DAL_XetTL daltl = new DAL_XetTL();

        public bool Them(DTO_XetTL dtotl)
        {
            return daltl.Them(dtotl);
        }
        public bool Sua(DTO_XetTL dtotl)
        {
            return daltl.Sua(dtotl);
        }
        public bool Xoa(string tl)
        {
            return daltl.Xoa(tl);
        }
    }
}
