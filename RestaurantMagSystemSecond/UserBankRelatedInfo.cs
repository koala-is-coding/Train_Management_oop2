using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMagSystemSecond
{
    internal class UserBankRelatedInfo
    {
        DBFunctions f = new DBFunctions();

        public static int UserBal;
        public static int RemainingBalance1;
        public int UserID { get; set; }
        public string Bankpass { get; set; }
        public string PaymentMethod { get; set; }
        public int AvailableBalance { get; set; }

        public int GetThisUserBalance() { return UserBal; }
        public void SetThisUserBalance()
        {
            try
            {
                LogInTableMembers mem = new LogInTableMembers();
                int UID = mem.GetThisuserID();
                string query = "select AvailableBalance from UserBankrelatedInfo where UId ='{0}'";
                query = string.Format(query, UID);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    UserBal = int.Parse(reader["AvailableBalance"].ToString());
                    reader.Close();
                }
                else
                {
                    UserBal = 0;
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool CreateBankStatement(UserBankRelatedInfo info)
        {
            try
            {
                string query = "insert into UserBankrelatedInfo values('{0}','{1}','{2}','{3}')";
                query = string.Format(query, info.UserID, info.Bankpass, info.PaymentMethod, info.AvailableBalance);
                f.setdata(query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool UpdateBankBalance(int uid, int newamount)
        {
            try
            {
                //getting previous user balance

                //updating balance
                string query = "update UserBankRelatedInfo set AvailableBalance ='{0}' where uid='{1}'";
                query = string.Format(query, UserBal + newamount, uid);
                UserBal += newamount;
                f.setdata(query);

                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public bool DoesBankStatementExsits(int uid)
        {
            try
            {
                string query = "select * from UserBankRelatedInfo where UId ='{0}'";
                query = string.Format(query, uid);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    reader.Close();
                    return true;

                }
                else { reader.Close(); return false; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public string GetUserPaymentMethod(int uid)
        {
            try
            {
                string query = "select * from UserBankRelatedInfo where UId ='{0}'";
                query = string.Format(query, uid);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string storedPayMethod = reader["PaymentMethod"].ToString();
                    reader.Close();
                    return storedPayMethod;

                }
                else
                {
                    MessageBox.Show("Error occured in getpaymentmethod");
                    reader.Close();
                    return null;
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message); return null;
            }
        }
        public bool IsBalanceSufficient(int uid, int Totalamount)
        {
            try
            {
                SetThisUserBalance();
                GetThisUserBalance();
                if (UserBal >= Totalamount) { return true; }
                else { return false; }
            }
            catch (Exception ex) { return false; }
        }
        public int RemainingBalance(int totalamount)
        {
            SetThisUserBalance();
            RemainingBalance1 = GetThisUserBalance() - totalamount;
            return RemainingBalance1;
        }
        public bool passChecker(string pass)
        {
            try
            {
                LogInTableMembers mem = new LogInTableMembers();
                string query = "select * from UserBankRelatedInfo where BankPass='{0}'";
                query = string.Format(query, pass);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string storedPass = reader["BankPass"].ToString();
                    if (storedPass == pass) { reader.Close(); return true; } else { reader.Close(); return false; }
                }
                else { reader.Close(); return false; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public void UpdateBalanceAfterpayment(int totAmount)
        {
            try
            {
                RemainingBalance1 = RemainingBalance(totAmount);
                LogInTableMembers mem = new LogInTableMembers();
                string query = "update UserBankRelatedInfo set AvailableBalance = '{0}' where UId = '{1}'";
                query = string.Format(query, RemainingBalance1, mem.GetThisuserID());
                f.setdata(query);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public bool BankPaymentMethodMatch(int uid, string userpaymethod)
        {
            try
            {
                string query = "select * from UserBankRelatedInfo where UId='{0}'";
                query = string.Format(query, uid);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string storedmethod = reader["PaymentMethod"].ToString() ;
                    if (storedmethod == userpaymethod)
                    {
                        reader.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close(); return false;
                    }
                }
                else { return false; }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
        }
        public string ShowUserBankRelatedInfo()
        {
            //joining
            try
            {
                string query = "select UserInfos.UId,UserInfos.Uname,UserBankRelatedInfo.PaymentMethod,UserBankRelatedInfo.AvailableBalance from UserInfos inner join UserBankRelatedInfo on UserInfos.UId=UserBankRelatedInfo.UId";
                f.setdata(query);
                return query;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message); return null;   
            }
        }
    }
}