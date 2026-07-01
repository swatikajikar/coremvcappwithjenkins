using Microsoft.AspNetCore.Mvc;

namespace CoreMVCAppWithJenkins.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
    }
}
