using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace RestaurantMagSystemSecond
{
    internal class DBFunctions
    {
        private SqlCommand Cmd;
        private SqlConnection Con;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private SqlDataReader Reader;
        private string ConStr;
        public DBFunctions()
        {
            ConStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\User\Documents\RestaurantMagSysSecond.mdf; Integrated Security = True; Connect Timeout = 30;";
            Con = new SqlConnection(ConStr);
            Cmd = new SqlCommand();
            //  Reader = new SqlDataReader();
            Cmd.Connection = Con;
        }
        public SqlDataReader ReadData(string query)
        {
            Cmd = new SqlCommand(query, Con);
            if (Con.State == ConnectionState.Closed) { Con.Open(); }
            Reader = Cmd.ExecuteReader();
            return Reader;
            Con.Close();
        }
        public DataTable getdata(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConStr);
            Sda.Fill(dt);
            return dt;
        }
        public int setdata(string Query)
        {
            int count = 0;
            if (Con.State == ConnectionState.Closed) { Con.Open(); }
            Cmd.CommandText = Query;
            count = Cmd.ExecuteNonQuery();
            Con.Close();
            return count;

        }
        
    }
}

