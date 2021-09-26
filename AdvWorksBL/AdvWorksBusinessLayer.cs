using AdvWorksDAL;
using AdvWorksDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvWorksBL
{
    public class AdvWorksBusinessLayer
    {
        AdvWorksDataAccessLayer dalObj = new AdvWorksDataAccessLayer();
        public List<ProductDTO> GetAllProducts()
        {
            return dalObj.FetchAllProducts();
        }
    }
}
