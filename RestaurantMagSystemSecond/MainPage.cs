using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMagSystemSecond
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            MakeAResPanel.Hide();
            UpdateUserInfoPanel.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            User u = new User();
            LogInTableMembers mem = new LogInTableMembers();
            int uid=mem.GetThisuserID();
            UNameTF.Text = u.GetUserName(uid);
            
        }

        private void MakeResbtn_Click(object sender, EventArgs e)
        {
            MakeAResPanel.Show();
            UpdateUserInfoPanel.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (UNameTF.Text.Length <= 0)
            {
                MessageBox.Show("Username cannot be empty");
                checkBox1.Checked = false;
            }
            else
            {
                User u = new User();
                ContactnoTF.Text = u.GetUserMobileNum(UNameTF.Text);
            }
        }

        private void ConFirmResBtn_Click(object sender, EventArgs e)
        {
            if (UNameTF.Text.Length <= 0 || ContactnoTF.Text.Length <= 0 || GuestNumTF.Text.Length <= 0 || ResPreferenceCB.SelectedIndex == -1 || ResDurationTF.Text.Length <= 0)
            {
                MessageBox.Show("Please fill out all the information");
            }
            else
            {
                Reservations res = new Reservations();
                res.Uname = UNameTF.Text;
                res.UContactNo = ContactnoTF.Text;
                res.NoOfguests = int.Parse(GuestNumTF.Text);
                res.resdate = ResDatDTP.Text;
                res.Preference = ResPreferenceCB.SelectedItem.ToString();
                res.ResDuration = int.Parse(ResDurationTF.Text);
                bool flag = res.AddReservation(res);
                if (flag == true)
                {
                    MessageBox.Show("Your reservation is booked and will be updated by the admins");
                }
                else
                {
                    MessageBox.Show("Unknown error occured");
                }

            }

        }

        private void UpdateUserInfoBtn_Click(object sender, EventArgs e)
        {
            UpdateUserInfoPanel.Show();
            MakeAResPanel.Hide();
        }

        private void UpdateuserBtn_Click(object sender, EventArgs e)
        {
            if (UpUserNameTF.Text.Length <= 0 || UpPassTF.Text.Length <= 0 || UpMnoTF.Text.Length <= 0 || UpCityCB.SelectedIndex == -1 || UpLocTF.Text.Length <= 0)
            {
                MessageBox.Show("Please fill out all the information");
            }
            else if (UpMnoTF.Text.Length != 11)
            {
                MessageBox.Show("Please enter a valid mobile number");
            }
            else if (UpPassTF.Text.Length < 8)
            {
                MessageBox.Show("Passwords need to be atleast 8 characters long");
            }
            else
            {
                User u = new User();
                LogInTableMembers mem = new LogInTableMembers();
                u.Uname = UpUserNameTF.Text;
                u.Upass = UpPassTF.Text;
                u.UMno = UpMnoTF.Text;
                u.UCity = UpCityCB.SelectedItem.ToString();
                u.ULoc = UpLocTF.Text;
                bool flag = u.UpdateUser(u);
                if (flag)
                {
                    MessageBox.Show("User Info updated successfully");
                    bool flag2 = mem.UpdateUsersOnMainpage(UpUserNameTF.Text,UpPassTF.Text);
                    if (!flag2) { MessageBox.Show("Updation on logintable unsuccessful"); }
                }
                else
                {
                    MessageBox.Show("Unknown error occured");
                }
            }
        }

        private void OnlineOrderBtn_Click(object sender, EventArgs e)
        {
            new FoodMenuForm().Show();
            this.Hide();
        }

        private void RetunBtn_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void CheckReservationBtn_Click(object sender, EventArgs e)
        {
            LogInTableMembers mem = new LogInTableMembers();
           Reservations res = new Reservations();
           int uid= mem.GetThisuserID();
            bool flag=res.IsResConfirmedByAdmins(uid);
            if (flag)
            {

            }
            else
            {
              //  notifyIcon1.Text="Your reservation is not yet confirmed";
                notifyIcon1.ShowBalloonTip(3000, "Notification Title", "Reservation not confirmed", ToolTipIcon.Info);
            }
            

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
