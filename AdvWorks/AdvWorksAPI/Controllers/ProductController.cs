using AdvWorksBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AdvWorksAPI.Controllers
{
    public class ProductController : ApiController
    {
        AdvWorksBusinessLayer blObj;

        [HttpGet]
        public HttpResponseMessage GetProducts()
        {
            try
            {
                blObj = new AdvWorksBusinessLayer();
                var result = blObj.GetAllProducts();
                if (result != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent, "No products found");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Something went wrong");
            }
        }
    }
}
