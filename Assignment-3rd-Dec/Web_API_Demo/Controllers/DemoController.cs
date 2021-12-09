using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Demo.Controllers
{
    public class DemoController : ApiController
    {
        public string get() {
            return "Welcome to API";
        }
        //public List<string> Get(int n) { 
        //    List<string> datalist = new List<string>();
        //    datalist.Add("Data - 1");

        //    return datalist;
        //}
    }
}
