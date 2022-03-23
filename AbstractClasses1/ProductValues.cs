using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses1
{
    class ProductValues : Products
    {
        private String custNumber;
        public ProductValues(string Name, double Price, double Qty,String Number) 
            :base(Name, Price, Qty)
        {
            CustNumber = Number;
        }
        public string CustNumber
        {
            get
            {
                return custNumber;
            }
            set
            {
                custNumber = value;
            }
        }
        public override string toString()
        {
            return "Customer No :"+CustNumber+" Product Name :" + this.ProductName 
                + " price :R" + this.ProductPrice+ " qty:" + this.ProductQty;
        }
    }
}
