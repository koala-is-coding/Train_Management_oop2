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
    public partial class PaymentForm : Form
    {

        LogInTableMembers mem = new LogInTableMembers();
        UserBankRelatedInfo info = new UserBankRelatedInfo();
        FoodMenu menu = new FoodMenu();

        public PaymentForm()
        {
            InitializeComponent();
            //label1.Hide();
            //label3.Hide();
            //PaymentTotalAmountTF.Hide();
            //PaymentUIDTF.Hide();
            //PaymentMethodCB.Hide();
            //ConfirmPaymentBtn.Hide();


        }

        private void PaymentTotalAmountTF_TextChanged(object sender, EventArgs e)
        {



        }

        private void PaymentUIDTF_TextChanged(object sender, EventArgs e)
        {

        }



        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            menu.setTotalAmount(0);
            new FoodMenuForm().Show();
            this.Hide();
        }

        private void PaymentProcessBtn_Click(object sender, EventArgs e)
        {
            new UserBankRelatedInfoForm().Show();
            this.Hide();
        }

        private void PaymentUnameTF_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            PaymentUIDTF.Text = mem.GetThisuserID().ToString();
            //PaymentMethodCB.Text = info.GetUserPaymentMethod(mem.GetThisuserID());
            PaymentTotalAmountTF.Text = menu.GetTotalAmount(menu).ToString();
            if (info.IsBalanceSufficient(mem.GetThisuserID(), menu.GetTotalAmount(menu)))
            {
                SuffBalanceLbel.Text = "Your balance after payment will be BDT " + info.RemainingBalance(int.Parse(PaymentTotalAmountTF.Text));
                InsufficientbalLabel.Hide();
            }
            else
            {
                InsufficientbalLabel.Text = "You do not have enough balance , please add balance to your account";
                SuffBalanceLbel.Hide();
            }
        }

        private void ConfirmPaymentBtn_Click(object sender, EventArgs e)
        {
            if (PaymentbankPass.Text.Length <= 0 || PaymentMethodCB.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill up all the information");
            }
            else if (!info.passChecker(PaymentbankPass.Text))
            {
                MessageBox.Show("Invalid password");
            }
            else if (!info.IsBalanceSufficient(mem.GetThisuserID(), int.Parse(PaymentTotalAmountTF.Text)))
            {
                MessageBox.Show("Your balance is insufficient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!info.BankPaymentMethodMatch(mem.GetThisuserID(),PaymentMethodCB.SelectedItem.ToString()))
            {
                MessageBox.Show("Payment method not correct");
            }
            else
            {
                PaymentClass pay = new PaymentClass();
                pay.UId = mem.GetThisuserID();
              //  pay.method = PaymentMethodCB.Text;
                pay.totalAmount = menu.GetTotalAmount(menu);
                pay.method = PaymentMethodCB.SelectedItem.ToString();  
                if (pay.InsertPaymentDB(pay))
                {
                    info.UpdateBalanceAfterpayment(menu.GetTotalAmount(menu));
                    MessageBox.Show("Your payment is successful");
                    PaymentTotalAmountTF.Text = "0";

                }
                else
                {
                    MessageBox.Show("Payment process failed");
                }

            }
            
        }
    }
}
