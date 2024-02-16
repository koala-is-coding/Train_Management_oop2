using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMagSystemSecond
{
    internal class FoodMenu
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int price { get; set; }

        public Dictionary<string,int> FoodNameandPrices = new Dictionary<string, int>() {
            {"RicenSalmon" , 140 },
            {"SteakDish",1300 },
            {"ChickenBowl",300 },
            {"ThaiSoup",230 },
            {"OreoShake",145 },
            {"StrawberryMilkShake",375 },
            {"SoftDrinks",70 },
            {"HotCoffee",225 },
            {"RedVelvetCake",155 },
            {"CreamNCookies",100 },
            {"CottonCandyDrink",210 },
            {"BananaShake",185 }
        };

        static public int TotalAmount;

        public string FoodItemRTBTextSetter(string itemname, int quantity)
        {
            if (FoodNameandPrices.ContainsKey(itemname))
            {
                string text = itemname + "*" + quantity +" units " +"=" + (quantity * FoodNameandPrices[itemname])+"\n";
                TotalAmount = TotalAmount + (quantity * FoodNameandPrices[itemname]);
                return text;
            }
            else
            {
                MessageBox.Show("Fooditem does not contain in the list");
                return null;
            }
        }
        public string GetMenuTable()
        {
            string query = "select * from Menu";
            return query;
        }
        public int GetTotalAmount(FoodMenu fm)
        {
            return TotalAmount;
        }
        //only for setting the totalamount to 0 after we returned from payment table
        public void setTotalAmount(int amount)
        {
            TotalAmount = amount;
        }

        public string ShowMenu()
        {
            string query = "select * from Menu";
            return query;
        }
    }
    
    
}
