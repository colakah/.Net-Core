using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreExample.Business.Contracts;

namespace NetCoreExample.Controllers
{
    //[Produces("application/json")]
    //[Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IBusinessEngine _businessEngine;
        public ProductController(IBusinessEngine businessEngine)
        {
            _businessEngine = businessEngine;
        }

        [HttpGet]
        public IEnumerable<object> GetAll()
        {

            return new List<string> { "Product1", "Product2", "Product3" };
        }
        [HttpGet]
        public List<int> GetRandomNumber()
        {

            Random rnd = new Random();
            int FirstValue = rnd.Next();
            int SecondValue = rnd.Next();
            int ThirdValue = rnd.Next();


            return new List<int>{FirstValue ,SecondValue,ThirdValue};
        }
        [HttpGet]
        public string Get()
        {

            return _businessEngine.Get();
        }
    }
}