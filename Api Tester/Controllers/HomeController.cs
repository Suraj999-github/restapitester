using Api_Tester.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Api_Tester.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult CallApi(string BaseUrl,string JsonVal,string ApiToken,string ApiUser)
        {           
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var json = jss.Deserialize<dynamic>(JsonVal);
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            using (var apiClient = new HttpClient(clientHandler))
            {
                string requestedData = JsonConvert.SerializeObject(json);
                var jbdContent = new StringContent(
                JsonConvert.SerializeObject(json),
                Encoding.UTF8,
                "application/json");
                 apiClient.DefaultRequestHeaders.Add("APIToken", ApiToken);
                apiClient.DefaultRequestHeaders.Add("APIUser", ApiUser);
                try
                {
                    HttpResponseMessage sendResponse = apiClient.PostAsync(BaseUrl, jbdContent).Result;
                    if (sendResponse.IsSuccessStatusCode)
                    {
                       
                        var result = sendResponse.Content.ReadAsStringAsync().Result;
                        JavaScriptSerializer js = new JavaScriptSerializer();
                        dynamic blogObject = js.Deserialize<dynamic>(result);
                        return Json(blogObject);
                    }
                    else
                    {
                       
                        var Message = ((int)sendResponse.StatusCode, sendResponse.ReasonPhrase).ToString();
                        return Json(Message);
                    }
                }
                catch (HttpRequestException e)
                {
                   
                     var Message = e.Message.ToString();
                    return Json(Message);

                }
            }            
        }
    }
}
