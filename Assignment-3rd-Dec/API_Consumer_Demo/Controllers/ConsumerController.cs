using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace API_Consumer_Demo.Controllers
{
    public class ConsumerController : Controller
    {
        // GET: Consumer
        public ActionResult Index()
        {
            using (var client = new HttpClient()) {
                
                client.BaseAddress = new Uri("https://localhost:44377/api/Demo");
                
                var result = client.GetAsync("Demo");
                
                result.Wait();
                
                var res = result.Result;

                if (res.IsSuccessStatusCode) {
                    var data = res.Content.ReadAsAsync(typeof(string));
                    data.Wait();
                    string s = data.Result as string;
                    ViewData["response"] = s;
                }
                else
                {
                    ViewData["response"] = "Error calling API";
                }
            }
                return View();
        }
    }
}