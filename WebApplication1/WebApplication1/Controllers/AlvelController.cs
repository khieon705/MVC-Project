using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlvelController : Controller
    {
        public IActionResult Index()
        {
            var model = new UserProfile
            {
                LastName = "Conanan",
                FirstName = "Alvel",
                MiddleName = "Casinto",
                University = "Polytechnic University of the Philippines",
                StudentNumber = "2024-01924-MN-0",
                Degree = "BS Computer Science",
                BirthDate = "8/29/2006",
                Age = "20",
                Sex = 'M',
                Street = "Parkplace Exec. Village",
                Barangay = "San Isidro",
                City = "Cainta",
                Province = "Rizal",
                Region = "CALABARZON (Region IV-A)",
                ZipCode = "1900",
                ContactNumber = "09695254746",
                EmailAddress = "rjconanan303@gmail.com",
                CivilStatus = "Single",
                Nationality = "Filipino",
                Religion = "Baptist",
                Height = "175 cm",
                Weight = "80 kg",
                BloodType = "O+",
                HairColor = "Black",
                EyeColor = "Dark Brown",
                FavoriteColor = "Black",
                ImageUrl = "/images/profilepic.jpg"
            };

            return View(model);
        }
    }
}