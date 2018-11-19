using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using usingAPI.Models;

namespace usingAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> About()
        {
            //ViewData["Message"] = "Your application description page.";

            HttpClient client = new HttpClient();
            List<Character> characters = new List<Character>();
            RootObject rootObject = null;
  
            bool next = true;
            string url = "https://swapi.co/api/people/?page=1";

            while (next)
            {
                

                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    rootObject = await response.Content.ReadAsAsync<RootObject>();

                    foreach (Character character in rootObject.Characters)
                    {
                        Character character1 = new Character
                        {
                            Name = character.Name,
                            Height = character.Height,
                            Mass = character.Mass,
                            Hair_color = character.Hair_color
                        };
                        characters.Add(character1);
                    }

                    // to exit while loop, because there aren't more pages 
                    if(rootObject.Next == null)
                    {
                        next = false;
                    }else
                    //go to the next page
                    {
                       url = rootObject.Next;
                    }

                }
            }
           //to pass it to the view About
            return View(characters);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
    }
}
