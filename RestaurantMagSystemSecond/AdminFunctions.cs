using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMagSystemSecond
{
    public partial class AdminFunctions : Form
    {
        DBFunctions f;

        public AdminFunctions()
        {
            InitializeComponent();
            f = new DBFunctions();
            UserActivationPanel.Hide();
            UpdateUserPanel.Hide();
            AddAdminPanel.Hide();
            ManageReservationsPanel.Hide();
            DeleteAdPanel.Hide();
        }
        public AdminFunctions(List<string> names)
        {
            InitializeComponent();
            f = new DBFunctions();
            AllUsersCB.Items.AddRange(names.ToArray());
        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowUsersBtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            string Usrs = u.ShowUsers();
            ShowTablesDGV.DataSource = f.getdata(Usrs);
        }

        private void AllUsersCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowAdminsBtn_Click(object sender, EventArgs e)
        {
            //  ShowTablesDGV.DataSource
            Admin a = new Admin();
            a.UserListInsertion();
            string Admins = a.showAdmins();
            ShowTablesDGV.DataSource = f.getdata(Admins);

        }

        private void LoadUsersBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> usernames = new List<string>();
                string query = "select * from UserInfos";
                SqlDataReader reader = f.ReadData(query);
                while (reader.Read())
                {
                    string uname = reader["Uname"].ToString();
                    usernames.Add(uname);
                }
                AllUsersCB.Items.AddRange(usernames.ToArray());
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            LoadUsersBtn.Enabled = false;
        }

        private void ActivateuserBtn_Click(object sender, EventArgs e)
        {
            UserActivationPanel.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateUsersBtn_Click(object sender, EventArgs e)
        {
            UpdateUserPanel.Show();
            UserActivationPanel.Hide();
            AddAdminPanel.Hide();
        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            if (UpNameTF.Text.Length <= 0 || UpMnoTF.Text.Length <= 0 || UpCityCB.SelectedIndex == -1 || UpLocTF.Text.Length <= 0)
            {
                MessageBox.Show("Please fill out all the information");
            }
            else if (UpMnoTF.Text.Length != 11)
            {
                MessageBox.Show("Please enter a valid mobile number");
            }
            else
            {
                try
                {
                    User u = new User();
                    u.Uname = UpNameTF.Text;
                    u.UMno = UpMnoTF.Text;
                    u.UCity = UpCityCB.SelectedItem.ToString();
                    u.ULoc = UpLocTF.Text;
                    string query = "update UserInfos set Uname='{0}',UMno ='{1}',UCity ='{2}',ULoc ='{3}' where Uname ='{4}'";
                    query = string.Format(query, u.Uname, u.UMno, u.UCity, u.ULoc, u.Uname);
                    f.setdata(query);
                    MessageBox.Show("User infor updated");
                    string query2 = "update LogInTable set name ='{0}' where name ='{1}'";
                    query2 = string.Format(query2, u.Uname, u.Uname);
                    f.setdata(query2);
                    UpNameTF.Text = "";
                    UpMnoTF.Text = "";
                    UpCityCB.Text = "City";
                    UpLocTF.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowLogInTableBtn_Click(object sender, EventArgs e)
        {
            LogInTableMembers l = new LogInTableMembers();
            string members = l.ShowLogInTable();
            ShowTablesDGV.DataSource = f.getdata(members);
        }

        private void ActivateBtn_Click(object sender, EventArgs e)
        {
            if (AllUsersCB.SelectedIndex == -1)
            {
                MessageBox.Show("No user selected");
            }
            else
            {
                try
                {
                    Admin a = new Admin();
                    bool status = a.UserActivision(AllUsersCB.SelectedItem.ToString());
                    if (status == true)
                    {
                        string query2 = "update UserInfos set UStatus='{0}' where Uname = '{1}'";
                        query2 = string.Format(query2, "Activated", AllUsersCB.SelectedItem.ToString());
                        f.setdata(query2);
                        MessageBox.Show("User status activated");

                    }
                    else
                    {
                        MessageBox.Show("User already activated");
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            UserActivationPanel.Hide();
            UpdateUserPanel.Hide();
            AddAdminPanel.Show();
            if (AddAdminnameTF.Text.Length <= 0 || AddAdminPassTF.Text.Length <= 0 || AddAdminWorkFieldTF.Text.Length <= 0)
            {
                MessageBox.Show("Please fill out all the information");
            }
            else
            {
                Admin admin = new Admin();
                admin.Adname = AddAdminnameTF.Text;
                admin.Adpass = AddAdminPassTF.Text;
                admin.role = AdRoleCB.Text;
                admin.WorkField = AddAdminWorkFieldTF.Text;
                bool flag = admin.AddAdmin(admin);
                if (flag == true)
                {
                    MessageBox.Show("Admin added successfully");
                }
                else
                {
                    MessageBox.Show("Unknown error occured");
                }
            }
        }
        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void AddAdmin_Click(object sender, EventArgs e)
        {
            UserActivationPanel.Hide();
            UpdateUserPanel.Hide();
            AddAdminPanel.Show();
        }

        private void ManageReserBtn_Click(object sender, EventArgs e)
        {
            ManageReservationsPanel.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoaadResBtn_Click(object sender, EventArgs e)
        {
            Reservations rev = new Reservations();
            List<string> pendingrevs = rev.GetPendingReservations();
            PendingResCB.Items.AddRange(pendingrevs.ToArray());
            LoaadResBtn.Enabled = false;
        }

        /*private void ConfirmAppointBtn_Click(object sender, EventArgs e)
        {
            if (PendingResCB.SelectedIndex == -1 || StartTimeTF.Text.Length <= 0 || EndTimeTF.Text.Length <= 0 || TableNoCB.SelectedIndex == -1)
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else
                    {
               Reservations res = new Reservations();
               if (res.DateConflict() == true)
               {
                   Reservations res = new Reservations();
                   res.ResStarttime = int.Parse(StartTimeTF.Text);
                   res.ResEndtime = int.Parse(EndTimeTF.Text);
                   bool flag = res.ResEgligibilty(res.ResStarttime, res.ResEndtime);
               } else { }
                    }
        }*/

        private void PendingResCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getres date
            Reservations res = new Reservations();
            string resdate = res.getReservationDate(PendingResCB.SelectedItem.ToString());
            if (resdate != null)
            {
                ResDateTF.Text = resdate;
            }
        }

        private void ConfirmAppointBtn_Click(object sender, EventArgs e)
        {
            if (PendingResCB.SelectedIndex == -1 || StartTimeTF.Text.Length <= 0 || EndTimeTF.Text.Length <= 0 || TableNoCB.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all informations");
            }
            else
            {
                Reservations res = new Reservations();
                int ResId = res.GetUserID(PendingResCB.SelectedItem.ToString());
                res.ResStarttime = int.Parse(StartTimeTF.Text);
                res.ResEndtime = int.Parse(EndTimeTF.Text);
                res.Tableno = int.Parse(TableNoCB.SelectedItem.ToString());

                if (res.DateConflict(ResId, ResDateTF.Text) == true)
                {
                    if (res.TimeConflict(int.Parse(StartTimeTF.Text), int.Parse(EndTimeTF.Text)) == true)
                    {
                        MessageBox.Show("Time conflicts,please select a different time range");
                    }
                    else
                    {
                        // MessageBox.Show("Time does not conflict");
                        bool flag = res.UpdateResByAdmins(res, ResId);
                        if (flag)
                        {
                            MessageBox.Show("Reservation confirmed");
                        }
                        else
                        {
                            MessageBox.Show("Reservation could not be confirmed");
                        }

                    }
                }
                else
                {
                    // MessageBox.Show("Reservation date does not conflict");
                    bool flag = res.UpdateResByAdmins(res, ResId);
                    if (flag)
                    {
                        MessageBox.Show("Reservation confirmed");
                    }
                    else
                    {
                        MessageBox.Show("Reservation could not be confirmed");
                    }

                }
            }
        }

        private void ResDateTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayMenuBtn_Click(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            string menu = fm.ShowMenu();
            ShowTablesDGV.DataSource = f.getdata(menu);

        }

        private void ShowPaymentBtn_Click(object sender, EventArgs e)
        {
            PaymentClass paymentClass = new PaymentClass();
            string pay = paymentClass.ShowPayment();
            ShowTablesDGV.DataSource = f.getdata(pay);
        }

        private void ShowResBtn_Click(object sender, EventArgs e)
        {
            Reservations res = new Reservations();
            string ress = res.showReservations();
            ShowTablesDGV.DataSource = f.getdata(ress);
        }

        private void DltAdBtn_Click(object sender, EventArgs e)
        {
            if (DltAdTF.Text.Length <= 0) { MessageBox.Show("Please enter admin ID"); }
            else
            {
                Admin ad = new Admin();
                bool flag = ad.DeleteAdmin(int.Parse(DltAdTF.Text));
                if (flag)
                {
                    MessageBox.Show("Admin deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInTableMembers mem = new LogInTableMembers();
                    bool flag2 = mem.deleteLogIntableAdmins(int.Parse(DltAdTF.Text));
                    if (flag2)
                    {
                        MessageBox.Show("Admin deleted from login table members");
                    }
                    else
                    {
                        MessageBox.Show("Could not delete  Admin from login table members");
                    }
                    DltAdTF.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Admin could not be deleted");
                    DltAdTF.Text = string.Empty;
                }
            }
        }

        private void DltAdminBtn_Click(object sender, EventArgs e)
        {
            DeleteAdPanel.Show();
        }

        private void DltUserBtn_Click(object sender, EventArgs e)
        {
            DeleteUserPanel.Show();
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (DltUserTF.Text.Length <= 0) { MessageBox.Show("Please enter user ID"); }
            else
            {
                User u = new User();
                bool flag = u.DeleteUser(int.Parse(DltUserTF.Text));
                if (flag)
                {
                    MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInTableMembers mem = new LogInTableMembers();
                    bool flag2 = mem.deleteLogIntableUsers(int.Parse(DltUserTF.Text));
                    if (flag2)
                    {
                        MessageBox.Show("User deleted from login table members");
                    }
                    else
                    {
                        MessageBox.Show("Could not delete  user  from login table members");
                    }
                    DltUserTF.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("User could not be deleted");
                    DltUserTF.Text = string.Empty;
                }
            }
        }

        private void ShowUserBankRelatedBtn_Click(object sender, EventArgs e)
        {
            UserBankRelatedInfo bankinfo = new UserBankRelatedInfo();
            string InnerJoin =bankinfo.ShowUserBankRelatedInfo();
            ShowTablesDGV.DataSource = f.getdata(InnerJoin);
        }
    }
}
        

       

