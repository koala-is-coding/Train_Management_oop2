using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMagSystemSecond
{
    internal class Reservations
    {
        List<string> reservations = new List<string>();
        List<(int, int)> resStartEndTime = new List<(int, int)>();
        DBFunctions f = new DBFunctions();
        public string Uname { set; get; }
        public string UContactNo { set; get; }
        public int NoOfguests { set; get; }
        public string resdate { set; get; }
        // public string ResTime { set; get; }
        public string Preference { set; get; }
        public int Tableno { set; get; }
        public int ResDuration { set; get; }
        public int ResStarttime { set; get; }
        public int ResEndtime { set; get; }

        public bool AddReservation(Reservations res)
        {
            try
            {
                string query = "insert into Reservations(Uname,UMno,NoOfGuests,ResDate,Preference,ResDuration) values('{0}','{1}','{2}','{3}','{4}','{5}')";
                query = string.Format(query, res.Uname, res.UContactNo, res.NoOfguests, res.resdate, res.Preference, res.ResDuration);
                f.setdata(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public List<string> GetPendingReservations()
        {
            string query = "select * from Reservations";
            SqlDataReader reader = f.ReadData(query);
            while (reader.Read())
            {
                string resnames = reader["Uname"].ToString();
                reservations.Add(resnames);
            }
            reader.Close();
            return reservations;
        }
        public void PopulateReservationList()
        {

        }
        /* public bool ResEgligibilty(int startT, int endT)
         {

         }*/
        public string getReservationDate(string resDate)
        {
            try
            {
                string query = "select * from Reservations where Uname ='{0}'";
                query = string.Format(query, resDate);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string storedResDate = reader["ResDate"].ToString();
                    reader.Close();
                    return storedResDate;
                }
                else
                {
                    reader.Close();
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public int GetUserID(string username)
        {
            try
            {
                string query = "select ResID from Reservations where Uname ='{0}'";
                query = string.Format(query, username);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    int resid = int.Parse(reader["ResID"].ToString());
                    reader.Close();
                    return resid;
                }
                else { reader.Close(); return 0; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return 0; }
        }
        public bool DateConflict(int ResID, string resdate)
        {
            try
            {
                string query = "select * from Reservations where ResID <> '{0}'";
                query = string.Format (query, ResID);
                SqlDataReader reader = f.ReadData(query);
                while (reader.Read())
                {
                   // MessageBox.Show(resdate);
                    if ((reader["ResDate"].ToString() == resdate))
                    {
                        reader.Close();
                        return true;

                    }
                    else { reader.Close(); return false; }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            // return false;
        }
        public bool TimeConflict(int sTime, int eTime)
        {
            try
            {
                string query = "select ResStartTime, ResEndTime from Reservations";
                SqlDataReader reader = f.ReadData(query);
                while (reader.Read()) 
                {
                    if (int.Parse(reader["ResStartTime"].ToString())<eTime  && int.Parse(reader["ResEndTime"].ToString()) > sTime)
                    {
                        reader.Close() ;
                        return true;
                    }
                    else 
                    {
                        reader.Close(); return false;
                    }
                }
                return false;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
       
        }
        public string showReservations()
        {
            string query = "select * from Reservations";
            return query;
        }
        public bool UpdateResByAdmins(Reservations res,int ResId)
        {
            try
            {
                string query = "Update Reservations set ResStartTime='{0}',ResEndTime='{1}',Tableno='{2}' where ResID ='{3}'";
                query = string.Format(query, res.ResStarttime, res.ResEndtime, res.Tableno, ResId);
                f.setdata(query);
                return true;
            }catch(Exception ex) {  MessageBox.Show(ex.Message);return false; }
        }
        public bool IsResConfirmedByAdmins(int uid)
        {
            User u = new User();
            string Uname=u.GetUserName(uid);
           
            try
            {
                string query = "select * from Reservations where Uname='{0}'";
                query = string.Format (query, Uname);   
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read()) {
                    if (reader["tableno"].ToString() != null) { reader.Close(); return true; }
                    else {reader.Close(); return false;}
                }
                else { reader.Close(); return false;}   
            }catch(Exception ex) { MessageBox.Show(ex.Message); return false; }
        }

    }

}