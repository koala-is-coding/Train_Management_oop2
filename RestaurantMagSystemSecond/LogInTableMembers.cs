using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMagSystemSecond
{
    internal class LogInTableMembers
    {
        DBFunctions f = new DBFunctions();
        static public int ThisUserID;
        public string Name {  get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }
    public string ShowLogInTable()
        {
            string query = "select * from LogInTable";
            return query;
        }
       public int GetThisuserID()
        {
             return ThisUserID;
        }
        public void SetThisUserID(string LogInname)
        {
            User user = new User();
            ThisUserID= user.getUserID(LogInname);

        }
       public bool insertLogInTableMembers(LogInTableMembers mem)
        {
            string query = "insert into LogInTable values('{0}','{1}','{2}')";
            query = string.Format(query, mem.Name, mem.Pass, mem.Role);
            f.setdata(query);
            return true;
        }
        public bool deleteLogIntableUsers(int uid)
        {
            try
            {
                User u = new User();
               string uname= u.GetUserName(uid);
                string query = "delete from LogInTable where name='{0}'";

                query = string.Format(query,uname);
                f.setdata(query);
                return true;
              
            } catch(Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public bool deleteLogIntableAdmins(int adid)
        {
            try
            {
                Admin a = new Admin();
                string adname = a.GetAdminName(adid);
                string query = "delete from LogInTable where name='{0}'";
                query = string.Format(query,adname);
                f.setdata(query);
                return true;
            }catch(Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public bool UpdateUsersOnMainpage(string uname,string pass)
        {
            try
            {
                string query = "update LogInTable set name='{0}',pass='{1}' where name='{2}'";
                query = string.Format(query,uname,pass,uname);
                f.setdata(query);
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);return false;
            }
        }
    }   
}
