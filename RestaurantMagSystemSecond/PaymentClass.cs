using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMagSystemSecond
{
    internal class PaymentClass
    {
        DBFunctions f = new DBFunctions();
        public int UId { get; set; }
        public string method { get; set; }
        public int totalAmount { get; set; }
        public bool InsertPaymentDB(PaymentClass p)
        {
            try
            {
                string query = "insert into  Payment  values('{0}','{1}','{2}')";
                query = string.Format(query, p.UId, p.method,p.totalAmount);
                f.setdata(query);   
                return true;
            } catch (Exception ex) { MessageBox.Show(ex.Message);return false; }

        }
        public string ShowPayment()
        {
            string query = "select * from Payment";
            return query;
        }
    }
}