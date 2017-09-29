using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace WebApplication2.Controllers
{
    public class FibonaciiController : ApiController
    {
        [HttpPost]
        public int PostJsonString([FromBody] string text)
        {
            int number = int.Parse(text);
            int fibo = -1; 
            if( number >= 1 && number <= 100)
            {
                fibo = 1;
                int preFibo = 0;
                for (int i = 1; i<number; i++)
                {
                    fibo = fibo + preFibo;
                    preFibo = fibo - preFibo;
                }
            }
            return fibo;
        }    
    }
}
