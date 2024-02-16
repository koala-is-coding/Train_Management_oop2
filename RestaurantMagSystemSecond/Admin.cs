using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMagSystemSecond
{
    internal class Admin
    {
        public List<string> UserNames = new List<string>();
        DBFunctions f = new DBFunctions();
        public string Adname { get; set; }
        public string Adpass { get; set; }
        public string role { get; set; }
        public string WorkField { get; set; }

        public bool AddAdmin(Admin a)
        {
            try
            {
                string query = "insert into Admin values('{0}','{1}','{2}','{3}')";
                query = string.Format(query, a.Adname, a.Adpass, a.role, a.WorkField);
                f.setdata(query);
                string query2 = "insert into LogInTable values('{0}','{1}','{2}')";
                query2 = string.Format(query2, a.Adname, a.Adpass, a.role);
                f.setdata(query2);
                // MessageBox.Show("Admin added successfully");
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }


        public string showAdmins()
        {
            string query2 = "select * from Admin";
            return query2;
        }
        public void UserListInsertion()
        {
            // List<string> UserNames = new List<string>();
            try
            {
                User u = new User();
                string query = u.GetUserNames();
                SqlDataReader reader = f.ReadData(query);
                while (reader.Read())
                {
                    string unames = reader["Uname"].ToString();
                    UserNames.Add(unames);
                }
                AdminFunctions adminFunctions = new AdminFunctions(UserNames);
                reader.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool UserActivision(string Val)//will return true if user status is deactivated
        {
            try
            {
                // Console.WriteLine("value of val is" + Val);
                string query = "select * from UserInfos where Uname='{0}'";
                query = string.Format(query, Val);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string status = reader["UStatus"].ToString();
                    if (status == "Deactivated")
                    {
                        reader.Close();
                        return true;
                        // reader.Close();
                        /*string query2 = "update UserInfos set UStatus='{0}' where Uname = '{1}'";
                        query2 = string.Format (query2, "Activated",Val);
                        f.setdata(query2);
                        MessageBox.Show("User status activated");*/

                    }
                    else
                    {
                        //MessageBox.Show("User is already activated");
                        reader.Close();
                        return false;

                    }
                }
                else
                {
                    MessageBox.Show("Data not found");
                    reader.Close();
                    return false;

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteAdmin(int AdId)
        {
            try
            {
                string query = "delete from Admin where AdId='{0}'";
                query = string.Format(query, AdId);
                f.setdata(query);
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message); return false;
            }
        }
        public string GetAdminName(int adid)
        {
            try {
                string query = "select * from Admin where AdId='{0}'";
                query = string.Format(query, adid);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string adname = reader["AdName"].ToString();
                    reader.Close();
                    return adname;
                }
                else
                {
                    reader.Close() ;    return null;
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message);return null; ; }

    }


    }

}
