using AdvWorksBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvWorksUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AdvWorksBusinessLayer blObj = new AdvWorksBusinessLayer();
            var products = blObj.GetAllProducts();
            foreach(var prod in products)
            {
                Console.WriteLine(prod.ProdName + "|" + prod.ProdNumber + "|" + prod.ProdColor + "|" + prod.ProdPrice + "|" + prod.ProdDaysToManuf);
            }
            Console.WriteLine("Total number of products = " + products.Count);
        }
    }
}
