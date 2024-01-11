using AgencyApp.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgencyApp.MVC_.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _db;

		public HomeController(AppDbContext db)
        {
			_db = db;
		}
        public async Task<IActionResult> Index()
		{
			return View(await _db.Products.ToListAsync());
		}
	}
}
