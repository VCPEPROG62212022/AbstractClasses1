using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses1
{
    class ProductCompanys : ProductValues
    {
        private string vatNumber;
        public ProductCompanys(string Name, double Price, double Qty, string Number,string vatNumber) 
            : base(Name, Price, Qty, Number)
        {

            VatNumber = vatNumber;
        }

        public string VatNumber
        {
            get
            {
                return vatNumber;
            }
            set
            {
                vatNumber = value;
            }
        }
        
        public override string toString()
        {
            return base.toString() + " Company Vat number " + VatNumber;
        }
    }
}
