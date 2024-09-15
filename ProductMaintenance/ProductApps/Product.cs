using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private decimal price;
        private int quantity;
        private decimal totalPayment;
        private decimal delivery;
        private decimal wrapping;
        private decimal gst;

        private decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }


        public decimal Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        public decimal Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        public decimal GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(decimal price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total after delivery is added
        public void calDelivery()
        {
            Delivery = TotalPayment + 25;
        }

        //Calculate the total after wrapping is added
        public void calWrapping()
        {
            Wrapping = Delivery + 5;
        }

        //Calculate the total after gst is added
        public void calGst()
        {
            decimal GST_RATE = 1.1M;
            GST = Wrapping * GST_RATE;
        }
    }
}
