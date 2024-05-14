using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace SuperMaket_project
{
    class connection
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\الجامعة\مستوى ثالث\projects c# forms\SuperMaket_project\DBSPMKT.mdf;Integrated Security = True;");

        public void delete(string sql) { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public SqlDataAdapter command(string sql)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
           
           return new SqlDataAdapter(cmd);
            
        }
        public void update(string sql)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
