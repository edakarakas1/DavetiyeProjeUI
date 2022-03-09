using DavetiyeApiUygulama.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeApiUygulama.Controllers
{
    public class HomeController : Controller
    {//davetiyeUI


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DavetiyeFormu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DavetiyeFormu(Davetiye davetiye)
        {
            var client = new HttpClient();
            var jsondavetiye = JsonConvert.SerializeObject(davetiye);
            StringContent content = new StringContent(jsondavetiye, Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:44369/api/Davetiyes", content);
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                return View("Tesekkurler", davetiye);
            }
            return View(ModelState);
        }
        public IActionResult Liste()
        {
            List<Davetiye> davetliler = new List<Davetiye>();
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:44369/api/Davetiyes");
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                var davet = read.Result;
                davetliler = JsonConvert.DeserializeObject<List<Davetiye>>(davet);
            }
            return View(davetliler);
        }
        public IActionResult GetAllDavetiye(bool durum = true)//katılanlar
        {
            List<Davetiye> gelenler = new List<Davetiye>();
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:44369/api/Davetiyes/Gelenler?b=" + durum);
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var read = result.Content.ReadAsStringAsync();
                var gelen = read.Result;
                gelenler = JsonConvert.DeserializeObject<List<Davetiye>>(gelen);
            }
            return View(gelenler);
        }
    }
}
