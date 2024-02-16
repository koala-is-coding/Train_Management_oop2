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
    public partial class FoodMenuForm : Form
    {
        int seconds, minutes, hours;
        public FoodMenuForm()
        {
            InitializeComponent();
            EntreePanel.Show();
            DrinkPanel.Show();
            DessertsPanel.Show();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            new MainPage().Show();
            this.Hide();
        }

        private void EntreePanelBtn_Click(object sender, EventArgs e)
        {
            EntreePanel.Show();
            // DrinkPanel.Hide();
            //DessertsPanel.Hide();
        }

        private void DrinksPanel_Click(object sender, EventArgs e)
        {
            DrinkPanel.Show();
            // EntreePanel.Hide();
            //DessertsPanel.Hide();
        }

        private void DessertsBtn_Click(object sender, EventArgs e)
        {
            DessertsPanel.Show();
            // EntreePanel.Hide();
            //DrinkPanel.Hide();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void RiceNSalmonCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("RicenSalmon", int.Parse(RiceNSalmonCB.SelectedItem.ToString())));
        }

        private void SteakCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("SteakDish", int.Parse(SteakCB.SelectedItem.ToString())));
        }

        private void ChickenBowlCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("ChickenBowl", int.Parse(ChickenBowlCB.SelectedItem.ToString())));
        }

        private void ThaiSoupCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("ThaiSoup", int.Parse(ThaiSoupCB.SelectedItem.ToString())));
        }

        private void OreoShakeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("OreoShake", int.Parse(OreoShakeCB.SelectedItem.ToString())));
        }

        private void StrawberryShakeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("StrawberryMilkShake", int.Parse(StrawberryShakeCB.SelectedItem.ToString())));
        }

        private void SoftDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("SoftDrinks", int.Parse(SoftDCB.SelectedItem.ToString())));
        }

        private void HotCoffeeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("HotCoffee", int.Parse(HotCoffeeCB.SelectedItem.ToString())));
        }

        private void RedVCakeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("RedVelvetCake", int.Parse(RedVCakeCB.SelectedItem.ToString())));
        }

        private void CreamnCokkiesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("CreamNCookies", int.Parse(CreamnCokkiesCB.SelectedItem.ToString())));
        }

        private void CottonCDCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("CottonCandyDrink", int.Parse(CottonCDCB.SelectedItem.ToString())));
        }

        private void BananaSCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenu fm = new FoodMenu();
            FoodItemListRTB.AppendText(fm.FoodItemRTBTextSetter("BananaShake", int.Parse(BananaSCB.SelectedItem.ToString())));
        }

        private void TotalAmountBtn_Click(object sender, EventArgs e)
        {
            if (FoodItemListRTB.Text.Length <= 0)
            {
                MessageBox.Show("You haven't selected any item");
            }
            else
            {
                FoodMenu fm = new FoodMenu();
                FoodItemListRTB.AppendText("    -----------------------------" + "\n");
                FoodItemListRTB.AppendText("Total amount : " + fm.GetTotalAmount(fm).ToString() + "\n");
            }
        }

        private void GoToPaymentBtn_Click(object sender, EventArgs e)
        {
            new PaymentForm().Show();
            this.Hide();
        }

        private void FoodItemListRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void FoodMenuForm_Load(object sender, EventArgs e)
        {
            seconds = 60;
            minutes = 1;
            hours = 4;
            timer1.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CountdownTimerLbl.Text = hours.ToString()+":"+minutes.ToString()+":"+seconds--.ToString();
           
            if (seconds < 0)
            {
                minutes--.ToString();   
                seconds = 59;
                CountdownTimerLbl.Text = hours.ToString() + ":" + minutes.ToString() + ":" + seconds--.ToString();

            }
            else if(minutes < 0)
            {
                hours--.ToString();
                minutes = 59;
                seconds = 59;
                CountdownTimerLbl.Text = hours.ToString() + ":" + minutes.ToString() + ":" + seconds--.ToString();

            }

        }
    }
}
