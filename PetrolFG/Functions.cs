using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolFG
{
    internal class Functions
    {
        protected SqlConnection GetConnection() 
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gount\Documents\PetrolFG.mdf;Integrated Security=True;Connect Timeout=30";
            return con;
        }
        //Function to display data from database
        public DataSet ShowData(string Query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = Query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
        //Function to insert into the database
        public void SetData(string Query,string msg) 
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = Query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg, "information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
