using System.Data.SqlClient;

namespace RestaurantMagSystemSecond
{
    public partial class LogIn : Form
    {
        DBFunctions f;
        public LogIn()
        {
            InitializeComponent();
            f = new DBFunctions();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInNameTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            new UserCreation().Show();
            this.Hide();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (LogInNameTF.Text.Length <= 0 || LogInPassTF.Text.Length <= 0)
            {
                MessageBox.Show("Fields cannot be empty", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string name = LogInNameTF.Text;
                    string pass = LogInPassTF.Text;
                    string query = "select * from LogInTable where name ='{0}'";
                    query = string.Format(query, name);
                    SqlDataReader reader = f.ReadData(query);
                    if (reader.Read())
                    {
                        string storedpass = reader["pass"].ToString();
                        if (storedpass == pass)
                        {
                           // MessageBox.Show("LogIn successful");
                            try
                            {
                                if (reader["role"].ToString() == "User")
                                {
                                    Admin a = new Admin();
                                    if (a.UserActivision(name) == false)//user is activated
                                    {
                                        new MainPage().Show();
                                        this.Hide();
                                        reader.Close();
                                        //setting userID explicitly??
                                    LogInTableMembers mem = new LogInTableMembers();
                                        mem.SetThisUserID(name);

                                    }
                                    else
                                    {
                                        MessageBox.Show("User is not yet activated by any Admins");reader.Close();
                                    }
                                }else if(reader["role"].ToString() == "Admin")
                                {
                                    new AdminFunctions().Show();
                                    this.Hide();
                                    reader.Close();
                                }
                            }catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid password");
                            reader.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid name");
                        reader.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new PassManagement().Show();
            this.Hide();
        }
    }
}
