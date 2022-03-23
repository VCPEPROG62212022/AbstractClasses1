using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses1
{
    public abstract class Products
    {
        private string productName;
        private double productPrice;
        private double productQty;
        public abstract string toString();

        public Products(String Name,double Price,double Qty)
        {
            ProductName = Name;
            ProductPrice = Price;
            ProductQty = Qty;
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }
        public double ProductQty
        {
            get
            {
                return productQty;
            }
            set
            {
                productQty = value;
            }
        }


    }
}
