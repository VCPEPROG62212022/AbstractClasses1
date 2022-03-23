using System;

namespace AbstractClasses1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductValues p = new ProductValues("Bread",12,8,"1022");
            //p.ProductName = "Bread";
            //p.ProductPrice = 12;
            //p.ProductQty = 5;
            Console.WriteLine(p.toString());



            ProductCompanys Com = new ProductCompanys("Bread", 12, 8, "1022","098765432");
            //p.ProductName = "Bread";
            //p.ProductPrice = 12;
            //p.ProductQty = 5;
            Console.WriteLine(Com.toString());
        }
    }
}
