using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Kent()
        {
            var KentID = new CardViewModel
            {
                LastName = "ESCOREL",
                FirstName = "KENT ANDREW",
                Address = new Address
                {
                    AddressLine1 = "BLK 6 Lot 1 Fercon St. Ext.",
                    AddressLine2 = "",
                    Barangay = "Tandang Sora",
                    City = "Quezon City",
                    Region = "NCR",
                    PostalCode = "1116",
                    Country = "Philippines"
                },
                Sex = Sex.Male,
                Skills = new List<string> { "Java", "Spring Boot" },
                DateOfBirth = new DateOnly(2006, 1, 18),
                Email = "kentescorel@gmail.com",
                CardNumber = "2024-01105-M-0",
                School = "PUP - Sta. Mesa",
                Program = "BS Computer Science",
                CivilStatus = "Single",
                Phone = "0932-249-3619",
                PictureUrl = "/wwwroot/images/card/ID_Pic.jpg",
                ProjectQRUrl = "/wwwroot/images/card/CollabWiseQR.png"
            };
            return View(KentID);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
