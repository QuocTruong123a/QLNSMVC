using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace BUS
{
    public class BUS_Functions : DAL_Connection
    {
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();
        void ketnoi()
        {
            sqlcon = new SqlConnection(strconnect);
            sqlcon.Open();
        }

        void ngatketnoi()
        {
            sqlcon.Close();
        }

        public void loaddatagridview(DataGridView dg, string strselect)
        {
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, strconnect);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
        }

        public void loaddatagridview1(DataGridView dg, DataSet ds1, string strselect)
        {
            ds1.Clear();
            sqlda = new SqlDataAdapter(strselect, strconnect);
            sqlda.Fill(ds1, "tenbang");
            dg.DataSource = ds1.Tables[0];
        }

        public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Items.Add(sqldr[chiso].ToString());
            }
            ngatketnoi();
        }
       
        public void loadtextbox(TextBox cb, string strselect)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[0].ToString();
            }
            ngatketnoi();
        }

 

        public void loadtextboxchiso(TextBox cb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[chiso].ToString();
            }
            ngatketnoi();
        }


        public bool kttrungkhoa(string dauvao, string strsql)
        {
            bool yes = false;
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
                    yes = true;
            }
            ngatketnoi();
            return yes;
        }

        public void loatextbox(TextBox tb, string strselect, byte chiso)
        {
            ketnoi();
            sqlcom = new SqlCommand(strselect, sqlcon);
            sqldr = sqlcom.ExecuteReader();
            while (sqldr.Read())
            {
                tb.Lines[0] = (sqldr[chiso].ToString());
            }
            ngatketnoi();
        }
        public void cheack(string select)
        {
            ketnoi();
            sqlcom = new SqlCommand(select, sqlcon);
            ngatketnoi();
        }
        public string login(string sql)
        {
            ketnoi();
            string ten = "";
            sqlcom = new SqlCommand(sql, sqlcon);
            SqlDataReader reader;
            reader = sqlcom.ExecuteReader();
            while (reader.Read())
                ten = reader.GetValue(0).ToString();
            reader.Close();
            return ten;
        }

    }
}
