using LabAssignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabAssignment1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            SignUpViewModel _SignUpViewModel = new SignUpViewModel();

            return View(_SignUpViewModel);
        }

        [HttpGet]
        public IActionResult ChangeCityByCountry(int countryId)
        {
            SignUpViewModel _SignUpViewModel = new SignUpViewModel();

            return Json(_SignUpViewModel.getCitybyCountryId(countryId));
        }

    }
}
