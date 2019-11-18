using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShowMoreSample.Models;

namespace ShowMoreSample.Controllers
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

        public IActionResult Part(int start, int length)
        {
            var model = GetData().Skip(start).Take(length).ToList();
            return View(model);
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

        private List<(string FirstName, string Surname)> GetData()
        {

            var data = new[] {
    new { FirstName = "Emmanuel", Surname = "Frye" },
    new { FirstName = "Thaddeus", Surname = "Roman" },
    new { FirstName = "Honorato", Surname = "Ballard" },
    new { FirstName = "Tyler", Surname = "Briggs" },
    new { FirstName = "Brian", Surname = "Mccall" },
    new { FirstName = "Cooper", Surname = "Wright" },
    new { FirstName = "Kane", Surname = "Holden" },
    new { FirstName = "Hakeem", Surname = "Greer" },
    new { FirstName = "Mannix", Surname = "Taylor" },
    new { FirstName = "Erich", Surname = "Parks" },
    new { FirstName = "Amos", Surname = "Hyde" },
    new { FirstName = "Martin", Surname = "Mclaughlin" },
    new { FirstName = "Russell", Surname = "Higgins" },
    new { FirstName = "Marsden", Surname = "Mathis" },
    new { FirstName = "Harlan", Surname = "Rodriquez" },
    new { FirstName = "Benjamin", Surname = "Parrish" },
    new { FirstName = "Daniel", Surname = "Davenport" },
    new { FirstName = "Dante", Surname = "Stewart" },
    new { FirstName = "Kennedy", Surname = "Carroll" },
    new { FirstName = "Keith", Surname = "Wilkerson" },
    new { FirstName = "Acton", Surname = "Estes" },
    new { FirstName = "Mohammad", Surname = "Conner" },
    new { FirstName = "Wallace", Surname = "Sellers" },
    new { FirstName = "Tate", Surname = "Vazquez" },
    new { FirstName = "Nathan", Surname = "Cantrell" },
    new { FirstName = "Gage", Surname = "Greer" },
    new { FirstName = "Nicholas", Surname = "Pitts" },
    new { FirstName = "Evan", Surname = "Kennedy" },
    new { FirstName = "Ivan", Surname = "Oneill" },
    new { FirstName = "Raphael", Surname = "Cortez" },
    new { FirstName = "Randall", Surname = "Mack" },
    new { FirstName = "Prescott", Surname = "Gibbs" },
    new { FirstName = "Alec", Surname = "Poole" },
    new { FirstName = "Bert", Surname = "Kane" },
    new { FirstName = "Jin", Surname = "Hawkins" },
    new { FirstName = "Evan", Surname = "Dickson" },
    new { FirstName = "Bruno", Surname = "Hicks" },
    new { FirstName = "Nero", Surname = "Fox" },
    new { FirstName = "Herrod", Surname = "Walter" },
    new { FirstName = "Lyle", Surname = "Dickerson" },
    new { FirstName = "Tiger", Surname = "Ellison" },
    new { FirstName = "Ulric", Surname = "Marshall" },
    new { FirstName = "Chase", Surname = "Zamora" },
    new { FirstName = "Timon", Surname = "Manning" },
    new { FirstName = "Phelan", Surname = "Farmer" },
    new { FirstName = "Ryder", Surname = "Mcfadden" },
    new { FirstName = "Jarrod", Surname = "Austin" },
    new { FirstName = "Hilel", Surname = "Townsend" },
    new { FirstName = "Lucius", Surname = "Tyler" },
    new { FirstName = "Boris", Surname = "Walls" },
    new { FirstName = "Gary", Surname = "Valdez" },
    new { FirstName = "Forrest", Surname = "Roth" },
    new { FirstName = "Knox", Surname = "Smith" },
    new { FirstName = "Marshall", Surname = "Gay" },
    new { FirstName = "Austin", Surname = "Clarke" },
    new { FirstName = "Stone", Surname = "Taylor" },
    new { FirstName = "Christopher", Surname = "White" },
    new { FirstName = "Vance", Surname = "Sargent" },
    new { FirstName = "Cody", Surname = "Bartlett" },
    new { FirstName = "Alvin", Surname = "Wade" },
    new { FirstName = "Raja", Surname = "Goff" },
    new { FirstName = "Francis", Surname = "Acevedo" },
    new { FirstName = "Keaton", Surname = "Beard" },
    new { FirstName = "Warren", Surname = "Williams" },
    new { FirstName = "Lev", Surname = "Gardner" },
    new { FirstName = "Ulric", Surname = "Soto" },
    new { FirstName = "Ulric", Surname = "Barker" },
    new { FirstName = "Colton", Surname = "Manning" },
    new { FirstName = "Barry", Surname = "Harrington" },
    new { FirstName = "Tucker", Surname = "Hughes" },
    new { FirstName = "Ezra", Surname = "Yang" },
    new { FirstName = "Nathan", Surname = "Landry" },
    new { FirstName = "Erich", Surname = "Jefferson" },
    new { FirstName = "Steel", Surname = "Carter" },
    new { FirstName = "Cadman", Surname = "Burris" },
    new { FirstName = "Kennedy", Surname = "Richmond" },
    new { FirstName = "Acton", Surname = "Hernandez" },
    new { FirstName = "Kato", Surname = "Gould" },
    new { FirstName = "Scott", Surname = "Hampton" },
    new { FirstName = "Leroy", Surname = "Lindsey" },
    new { FirstName = "Demetrius", Surname = "Finch" },
    new { FirstName = "Honorato", Surname = "Owen" },
    new { FirstName = "Donovan", Surname = "Macias" },
    new { FirstName = "Yasir", Surname = "Mcmahon" },
    new { FirstName = "Ross", Surname = "Michael" },
    new { FirstName = "Zeus", Surname = "Boyle" },
    new { FirstName = "Lawrence", Surname = "House" },
    new { FirstName = "Ian", Surname = "Mann" },
    new { FirstName = "Vance", Surname = "Craft" },
    new { FirstName = "Tanek", Surname = "Sanford" },
    new { FirstName = "Malik", Surname = "Conrad" },
    new { FirstName = "Theodore", Surname = "Bullock" },
    new { FirstName = "Nehru", Surname = "Oneil" },
    new { FirstName = "Anthony", Surname = "Kirk" },
    new { FirstName = "Lance", Surname = "Wells" },
    new { FirstName = "Tanner", Surname = "Tate" },
    new { FirstName = "Callum", Surname = "Wise" },
    new { FirstName = "Chester", Surname = "Cabrera" },
    new { FirstName = "Charles", Surname = "Bentley" },
    new { FirstName = "Carson", Surname = "Hooper" }
};
            var list = data.Select(x => (x.FirstName, x.Surname)).ToList();
            return list;

        }
        

    }
}
