using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Cashier
{
    class Item
    {
        private int id;
        public string title { get; set;}
        public int quantity { get; set; }
        public double price { get; set; }
        public double subtotal { get; set; }
        private string type;
        private int v;

        public Item(int id, string title, int quantity, double price, double subtotal, string type)
        {
            this.id = id;
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.subtotal = subtotal;
            this.type = type;
        }

        public Item(int v, string title, int quantity, string type, double price)
        {
            this.v = v;
            this.title = title;
            this.quantity = quantity;
            this.type = type;
            this.price = price;
        }

        public string getTitle()
        {
            return title;
        }
        public int getquantity()
        {
            return quantity;
        }
        public double getprice()
        {
            return price;
        }
        public double getSubTotal()
        {
            subtotal = price * quantity;
            return subtotal;
        }     
    }
}
