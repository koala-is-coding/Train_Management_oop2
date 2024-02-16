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
    public partial class PassManagement : Form
    {
        DBFunctions f;
        public PassManagement()
        {
            InitializeComponent();
            f = new DBFunctions();
            label2.Hide();
            NewpassTF.Hide();
            ConfirmBtn.Hide();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (NameTF.Text.Length <= 0)
            {
                MessageBox.Show("Field cannot be empty");
            }
            else
            {
                LogInTableMembers LImember = new LogInTableMembers();
                LImember.Name = NameTF.Text;
                string query = "select * from LogInTable where name ='{0}'";
                query = string.Format(query, LImember.Name);
                SqlDataReader reader = f.ReadData(query);
                if (reader.Read())
                {
                    string storedpass = reader["pass"].ToString();
                    DialogResult d = MessageBox.Show("Your password is \"" + storedpass + "\" . Would you like to reset it now?", "Your pass", MessageBoxButtons.YesNo);
                    if (d == DialogResult.Yes)
                    {
                        label2.Show();
                        NewpassTF.Show();
                        ConfirmBtn.Show();
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        new LogIn().Show();
                        this.Hide();
                    }
                }

            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (NewpassTF.Text == "")
            {
                MessageBox.Show("Password field cannot be empty");
            }
            else
            {
                try
                {
                    string pass = NewpassTF.Text;
                    string query = "UPDATE LogInTable set pass ='{0}' where name ='{1}'";
                    query = string.Format(query, pass, NameTF.Text);
                    f.setdata(query);
                    string query2 = "UPDATE UserInfos set Upass ='{0}' where Uname ='{1}'";
                    f.setdata(query2);
                    MessageBox.Show("Updation successful");

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
