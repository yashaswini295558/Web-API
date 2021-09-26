using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvWorksDTO
{
    public class ProductDTO
    {
        public string ProdName { set; get; }
        public string ProdNumber { get; set; }
        public string ProdColor{ get; set; }
        public decimal ProdPrice { get; set; }
        public int ProdDaysToManuf { get; set; }
    }
}
