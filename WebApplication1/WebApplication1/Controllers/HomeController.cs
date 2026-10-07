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

        public IActionResult Leonard()
        {
            var leonard_biodata = new List<Biodata>
            {
                new Biodata
                {
                    LastName = "Futol",
                    FirstName = "Leonard",
                    MiddleName = "Fungo",
                    StudentNumber = "2024-01101-MN-0",
                    CourseCode = "BSCS",
                    YearSection = "3-2",
                    BirthDate = "04-14-2006",
                    Age = "29",
                    Sex = 'M',
                    Street = "15 Ruben Jr. St., Richland 1 Subdivision",
                    Barangay = "Sauyo",
                    City = "Quezon City",
                    Province = "Metro Manila",
                    Region = "NCR",
                    ZipCode = "1116",
                    ContactNumber = "09944308226",
                    EmailAddress = "leonard.futol.14@gmail.com",
                    CivilStatus = "Single",
                    Citizenship = "Filipino",
                    Religion = "Roman Catholic",
                    Height = "170 cm",
                    Weight = "65 kg",
                    BloodType = "N/A",
                    HairColor = "Black",
                    EyeColor = "Brown",
                    FavoriteColor = "Blue",
                    FavoriteFood = "Dinakdakan"
                }
            };

            return View(leonard_biodata);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
