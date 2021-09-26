using AdvWorksDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvWorksDAL
{
    public class AdvWorksDataAccessLayer
    {
        string conStr = ConfigurationManager.ConnectionStrings["AdvConStr"].ConnectionString;
        public List<ProductDTO> FetchAllProducts()
        {
            try
            {
                List<ProductDTO> lstProducts = new List<ProductDTO>();

                SqlConnection conObj = new SqlConnection();
                conObj.ConnectionString = conStr;

                SqlCommand queryObj = new SqlCommand();
                queryObj.CommandText = @"SELECT [Name],ProductNumber,Color,ListPrice,DaysToManufacture FROM Production.Product";
                queryObj.CommandType = System.Data.CommandType.Text;
                queryObj.Connection = conObj;

                conObj.Open();
                SqlDataReader drProduct = queryObj.ExecuteReader();
                while(drProduct.Read())
                {
                    lstProducts.Add(new ProductDTO()
                    {
                        ProdName = drProduct["Name"].ToString(),
                        ProdNumber = drProduct["ProductNumber"].ToString(),
                        ProdColor = drProduct["Color"].ToString(),
                        ProdPrice = Convert.ToDecimal(drProduct["ListPrice"]),
                        ProdDaysToManuf = Convert.ToInt32(drProduct["DaysToManufacture"])
                    });
                }
                return lstProducts;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
