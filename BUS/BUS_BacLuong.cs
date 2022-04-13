using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BUS
{
    public class BUS_BacLuong :DAL_Connection
    {
        DAL_BacLuong dalbl = new DAL_BacLuong();

        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        public bool Them(DTO_BacLuong dtobl)
        {
            return dalbl.Them(dtobl);
        }
        public bool Sua(DTO_BacLuong dtobl)
        {
            return dalbl.Sua(dtobl);
        }
        public bool Xoa(string bl)
        {
            return dalbl.Xoa(bl);
        }
        public string tangma()
        {
            string sql = @"select * from BacLuong";
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = strconnect;
            sqlda = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "BL001";

            }
            else
            {
                int k;
                ma = "BL";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 3));
                k = k + 1;
                if (k < 10)
                {
                    ma = ma + "00";
                }
                else if (k < 100)
                {
                    ma = ma + "0";
                }

                ma = (ma + k).ToString();
            }

            return ma;
        }
    }
}
