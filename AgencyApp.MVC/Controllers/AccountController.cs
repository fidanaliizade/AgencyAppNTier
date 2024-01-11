using Microsoft.AspNetCore.Mvc;

namespace AgencyApp.MVC_.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Register()
		{
			return View();
		}
		public IActionResult Login()
		{
			return View();
		}
	}
}
