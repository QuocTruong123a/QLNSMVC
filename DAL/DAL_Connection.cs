using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_Connection
    {
        public string strconnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLLNV;Integrated Security=True";
        
        SqlConnection sqlcon;
        SqlCommand sqlcom;
        //SqlDataAdapter sqlda;
        //SqlDataReader sqldr;
        //DataSet ds = new DataSet();

         void ketnoi()
        {
            sqlcon = new SqlConnection(strconnect);
            sqlcon.Open();
        }

         void ngatketnoi()
        {
            sqlcon.Close();
        }

        public void thucthiketnoi(string strsql)
        {
            ketnoi();
            sqlcom = new SqlCommand(strsql, sqlcon);
            sqlcom.ExecuteNonQuery();
            ngatketnoi();
        }
        //.....
        // datebase....dategridview...kiem tra sql...loadcombox...loaddatetime....
        //......
        //public void loaddatagridview(DataGridView dg, string strselect)
        //{
        //    ds.Clear();
        //    sqlda = new SqlDataAdapter(strselect, strconnect);
        //    sqlda.Fill(ds, "tenbang");
        //    dg.DataSource = ds.Tables[0];
        //}

        //public void loaddatagridview1(DataGridView dg, DataSet ds1, string strselect)
        //{
        //    ds1.Clear();
        //    sqlda = new SqlDataAdapter(strselect, strconnect);
        //    sqlda.Fill(ds1, "tenbang");
        //    dg.DataSource = ds1.Tables[0];
        //}

        //public void loadcombobox(ComboBox cb, string strselect, byte chiso)
        //{
        //    ketnoi();
        //    sqlcom = new SqlCommand(strselect, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        cb.Items.Add(sqldr[chiso].ToString());
        //    }
        //    ngatketnoi();
        //}

        //public void loadtextbox(TextBox cb, string strselect)
        //{
        //    ketnoi();
        //    sqlcom = new SqlCommand(strselect, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        cb.Text = sqldr[0].ToString();
        //    }
        //    ngatketnoi();
        //}

        //public void loaddatetime(DateTimePicker cb, string strselect, byte chiso)
        //{
        //    ketnoi();
        //    sqlcom = new SqlCommand(strselect, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        cb.Text = sqldr[chiso].ToString();
        //    }
        //    ngatketnoi();
        //}

        //public void loadtextboxchiso(TextBox cb, string strselect, byte chiso)
        //{
        //    ketnoi();
        //    sqlcom = new SqlCommand(strselect, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        cb.Text = sqldr[chiso].ToString();
        //    }
        //    ngatketnoi();
        //}

        //public string getdata(string dauvao, string strsql)
        //{
        //    string strketqua = "";
        //    ketnoi();
        //    sqlcom = new SqlCommand(strsql, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
        //            strketqua = sqldr[1].ToString();
        //    }
        //    ngatketnoi();
        //    return strketqua;
        //}

        //public bool kt(string dauvao, string strsql, string chiso)
        //{
        //    bool ok = false;
        //    ketnoi();
        //    sqlcom = new SqlCommand(strsql, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        if (sqldr[chiso].ToString().ToLower() == dauvao.ToLower())
        //            ok = true;
        //    }
        //    ngatketnoi();
        //    return ok;
        //}
        //public bool thang(string dauvao, string thang, string strsql)
        //{
        //    bool th = false;
        //    ketnoi();
        //    sqlcom = new SqlCommand(strsql, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
        //            if (sqldr[thang].ToString().ToLower() == dauvao.ToLower())
        //                th = true;
        //    }

        //    ngatketnoi();
        //    return th;
        //}
        //public string thu(string dauvao, string strsql)
        //{
        //    string strketqua = "";
        //    ketnoi();
        //    sqlcom = new SqlCommand(strsql, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
        //            strketqua = sqldr[0].ToString();
        //    }
        //    ngatketnoi();
        //    return strketqua;
        //}

        //public bool kttrungkhoa(string dauvao, string strsql)
        //{
        //    bool yes = false;
        //    ketnoi();
        //    sqlcom = new SqlCommand(strsql, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        if (sqldr[0].ToString().ToLower() == dauvao.ToLower())
        //            yes = true;
        //    }
        //    ngatketnoi();
        //    return yes;
        //}

        //public void loatextbox(TextBox tb, string strselect, byte chiso)
        //{
        //    ketnoi();
        //    sqlcom = new SqlCommand(strselect, sqlcon);
        //    sqldr = sqlcom.ExecuteReader();
        //    while (sqldr.Read())
        //    {
        //        tb.Lines[0] = (sqldr[chiso].ToString());
        //    }
        //    ngatketnoi();
        //}
        //public static SqlConnection Con;
        //public static string GetFieldValues(string sql)
        //{
        //    Con = new SqlConnection();
        //    Con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNS;Integrated Security=True";
        //    Con.Open();                  //Mở kết nối
        //    string ten = "";
        //    SqlCommand cmd = new SqlCommand(sql, Con);
        //    SqlDataReader reader;
        //    reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //        ten = reader.GetValue(0).ToString();
        //    reader.Close();
        //    return ten;
        //}
    }
}
