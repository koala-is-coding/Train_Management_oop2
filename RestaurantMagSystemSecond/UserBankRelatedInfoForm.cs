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
    public partial class UserBankRelatedInfoForm : Form
    {
        LogInTableMembers mem = new LogInTableMembers();
        UserBankRelatedInfo bankinfo = new UserBankRelatedInfo();
        public UserBankRelatedInfoForm()
        {
            InitializeComponent();
            CreateBankPanel.Hide();
            AddamountPanel.Hide();
        }

        private void UserBankRelatedInfoForm_Load(object sender, EventArgs e)
        {


            UIdlabel.Text = mem.GetThisuserID().ToString();
            bankinfo.SetThisUserBalance();
            BalanceLabel.Text = bankinfo.GetThisUserBalance().ToString();
            BankUidTF.Text = mem.GetThisuserID().ToString();
            //UpdateBankUIDTF.Text = mem.GetThisuserID().ToString();
        }

        private void bankUIdTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void UIdlabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            UserBankRelatedInfo bank = new UserBankRelatedInfo();
            if (PaymentMethodCB.SelectedIndex == -1 || BankPassTF.Text.Length <= 0 || AvailBalanceTF.Text.Length <= 0)
            {
                MessageBox.Show("Please fill out all the information");
            }
            else if (bank.DoesBankStatementExsits(int.Parse(UIdlabel.Text)))
            {
                MessageBox.Show("A bank account issued by this user already exists.Cannot create more than one account for an user");
            }
            else
            {

                bank.UserID = int.Parse(BankUidTF.Text);
                bank.Bankpass = BankPassTF.Text;
                bank.PaymentMethod = PaymentMethodCB.SelectedItem.ToString();
                bank.AvailableBalance = int.Parse(AvailBalanceTF.Text);
                bool flag = bank.CreateBankStatement(bank);
                if (flag)
                {
                    MessageBox.Show("Bank statment created");
                    BalanceLabel.Text = bankinfo.GetThisUserBalance().ToString();
                    BankPassTF.Text = "";
                    AvailBalanceTF.Text = "";


                }
                else { MessageBox.Show("Bank statement could not be created"); }
                PaymentMethodCB.SelectedIndex = -1;
                BankPassTF.Text = "";
                AvailBalanceTF.Text = "";
            }
        }

        private void UpdateBalBtn_Click(object sender, EventArgs e)
        {
            if (AddAmountTF.Text.Length <= 0)
            {
                MessageBox.Show("Please enter an amount");
            }
            else
            {
                UserBankRelatedInfo info = new UserBankRelatedInfo();
                User user = new User();
                bool flag = info.UpdateBankBalance(int.Parse(UIdlabel.Text), int.Parse(AddAmountTF.Text));
                if (flag == true)
                {
                    MessageBox.Show("User balance updated");
                    BalanceLabel.Text = info.GetThisUserBalance().ToString();
                }
                else { MessageBox.Show("ID not found,user ID might not be created"); }
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            new PaymentForm().Show();
            this.Hide();
        }

        private void NewBankBtn_Click(object sender, EventArgs e)
        {
            CreateBankPanel.Show();
            AddamountPanel.Hide();
        }

        private void UpdateBankBtn_Click(object sender, EventArgs e)
        {
            CreateBankPanel.Hide();
            AddamountPanel.Show();
        }
    }
}