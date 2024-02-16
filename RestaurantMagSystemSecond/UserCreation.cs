using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMagSystemSecond
{
    public partial class UserCreation : Form
    {
        DBFunctions f;
        public UserCreation()
        {
            InitializeComponent();
            f = new DBFunctions();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (UNameTF.Text.Length <= 0 || UPassTF.Text.Length <= 0 || UMnoTF.Text.Length <= 0 || UCityCB.SelectedIndex == -1 || ULocTF.Text.Length <= 0)
            {
                MessageBox.Show("Please fill out all the information");
            }
            else if (UPassTF.Text.Length < 8)
            {
                MessageBox.Show("Password needs to be at least 8 characters long");
            }
            else if (UMnoTF.Text.Length != 11)
            {
                MessageBox.Show("Please enter a valid mobile number");
            }
            else
            {
                try
                {
                    User u = new User();
                    u.Uname = UNameTF.Text;
                    u.Upass = UPassTF.Text;
                    u.UMno = UMnoTF.Text;
                    u.UCity = UCityCB.SelectedItem.ToString();
                    u.UStatus = UStatusCB.Text;
                    u.URole = RoleCB.Text;
                    u.ULoc = ULocTF.Text;

                    bool flag1=u.InsertUserName(u);
                   
                    /* string query = "insert into UserInfos values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                     query = string.Format(query, u.Uname, u.Upass, u.UMno, u.UCity, u.UStatus, u.URole, u.ULoc);
                     f.setdata(query);*/
                    LogInTableMembers mem = new LogInTableMembers();
                    mem.Name = UNameTF.Text;
                    mem.Pass = UPassTF.Text;
                    mem.Role = RoleCB.Text;
                     bool flag=mem.insertLogInTableMembers(mem);
                    if (flag)
                    {
                        MessageBox.Show("Your account has been successfully created");
                    }
                    else { MessageBox.Show("LogInTable Insertaion error"); }
                    /*string query2 = "insert into LogInTable values('{0}','{1}','{2}')";
                    query2 = string.Format(query2, u.Uname, u.Upass, u.URole);
                    f.setdata(query2);  */
                    UNameTF.Text = "";
                    UPassTF.Text = "";
                    UMnoTF.Text = "";
                    UCityCB.Text = "City";
                    ULocTF.Text = "";

                    //storing userID
                     


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
    }
}
