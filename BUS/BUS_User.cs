using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_User : DAL_Connection
    {
        DAL_User dalus = new DAL_User();

        public bool them(DTO_User dtous)
        {
            return dalus.them(dtous);
        }
        public bool sua(DTO_User dtous)
        {
            return dalus.sua(dtous);
        }
        public bool xoa(int id)
        {
            return dalus.xoa(id);
        }

    }
}
