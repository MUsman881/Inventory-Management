using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Electornics_Project
{
    public class repo
    {
        SqlConnection con = new SqlConnection(@"Data source =localhost;initial catalog=POS;integrated security=true;");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public DataSet getdata(string query)
        {
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd.CommandText, con);
            ds = new DataSet();
            da.Fill(ds, "0");
            return ds;
        }
        public int savedata(string qu)
        {
            con.Open();
            cmd = new SqlCommand(qu, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}
