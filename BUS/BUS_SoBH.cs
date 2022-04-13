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
    public class BUS_SoBH :DAL_Connection
    {
        DAL_SoBH dalbh = new DAL_SoBH();
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        public bool Them(DTO_SoBH dtobh) 
        {
            return dalbh.Them(dtobh);
        }
        public bool Sua(DTO_SoBH dtobh)
        {
            return dalbh.Sua(dtobh);
        }
        public bool Xoa(string bh)
        {
            return dalbh.Xoa(bh);
        }
        public string tangma()
        {
            string sql = @"select * from SoBH";
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = strconnect;
            sqlda = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "BH001";

            }
            else
            {
                int k;
                ma = "BH";
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
