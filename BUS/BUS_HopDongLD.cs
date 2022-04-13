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
    public class BUS_HopDongLD : DAL_Connection
    {
        DAL_HopDongLD dalld = new DAL_HopDongLD();
        SqlConnection sqlcon;
        SqlDataAdapter sqlda;
        public bool Them(DTO_HopDongLD dtold)
        {
            return dalld.Them(dtold);
        }
        public bool Sua(DTO_HopDongLD dtold)
        {
            return dalld.Sua(dtold);
        }
        public bool Xoa(string ld)
        {
            return dalld.Xoa(ld);
        }
        public string tangma()
        {
            string sql = @"select MaNV from HopDongLD ";
            sqlcon = new SqlConnection();
            sqlcon.ConnectionString = strconnect;
            sqlda = new SqlDataAdapter(sql, sqlcon);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
            string ma = "";
            if (dt.Rows.Count <= 0)
            {
                ma = "001";

            }
            else
            {
                int k;
                ma = "";
                k = Int32.Parse(dt.Rows[dt.Rows.Count -1 ][0].ToString());
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
