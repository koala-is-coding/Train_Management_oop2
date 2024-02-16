using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMagSystemSecond
{
    internal class User
    {
        DBFunctions f = new DBFunctions();
        public string Uname { get; set; }
        public string Upass { get; set; }
        public string UMno { get; set; }
        public string UCity { get; set; }
        public string URole { get; set; }
        public string UStatus { get; set; }
        public string ULoc { get; set; }

        public string ShowUsers()
        {
            string query = "select * from UserInfos";
            return query;
        }
        public string GetUserNames()
        {
            string query = "select Uname from UserInfos";
            return query;
        }
        public int getUserID(string uname)
        {

            try
            {
                string query = "select * from UserInfos where Uname ='{0}'";
                query = string.Format(query, uname);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    int UserId = int.Parse(reader["UId"].ToString());
                    return UserId;
                }
                else
                {
                    MessageBox.Show("Invalid user");
                    return -1;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        /* public int storedUserID()
         {

         }*/
        public string GetUserMobileNum(string username)
        {
            try
            {
                string query = "select * from UserInfos where Uname = '{0}'";
                query = string.Format(query, username);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string storedMno = reader["UMno"].ToString();
                    reader.Close();
                    return storedMno;

                }
                else
                {
                    MessageBox.Show("No contact number was found associated with this username");
                    reader.Close();
                    return null;

                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public bool UpdateUser(User user)
        {
            try
            {
                string query = "update UserInfos set Uname ='{0}',Upass ='{1}',UMno ='{2}',UCity ='{3}',ULoc ='{4}' where Uname ='{5}'";
                query = string.Format(query, user.Uname, user.Upass, user.UMno, user.UCity, user.ULoc, user.Uname);
                f.setdata(query);
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DoesUnameExists(string uname)
        {
            try
            {
                string query = "select Uname from UserInfos where Uname ='{0}'";
                query = string.Format(query, uname);
                SqlDataReader r = f.ReadData(query);
                if (r.Read())
                {
                    r.Close();
                    return true;
                }
                else
                {
                    r.Close(); return false;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool InsertUserName(User u)
        {
            string query = "insert into userInfos values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            query = string.Format(query, u.Uname, u.Upass, u.UMno, u.UCity, u.UStatus, u.URole, u.ULoc);
            f.setdata(query);
            return true;
        }
        public bool DeleteUser(int uid)
        {
            try
            {
                string query = "delete from userinfos where UId='{0}'";
                query = string.Format(query, uid);
                f.setdata(query);
                return true;
            } catch (Exception ex) {  MessageBox.Show(ex.Message); return false; }
        }
        public string GetUserName(int uid)
        {
            try
            {
                string query = "select Uname from UserInfos where UId='{0}'";
                query = string.Format(query, uid);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string uname = reader["Uname"].ToString();
                    reader.Close();
                    return uname;

                }
                else { reader.Close(); return null; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
        }

    }

}
