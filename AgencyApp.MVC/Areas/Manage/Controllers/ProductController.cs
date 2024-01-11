using AgencyApp.Business.Services.Interfaces;
using AgencyApp.Business.ViewModels.ProductVMs;
using AgencyApp.DAL.Context;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgencyApp.MVC_.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class ProductController : Controller
    {
        private readonly IProductServices _service;
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public ProductController(IProductServices service, AppDbContext db,IMapper mapper)
        {
            _service = service;
            _db = db;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _db.Products.Where(f => !f.IsDeleted).ToListAsync();
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateVM vm)
        {
            await _service.Create(vm);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var product = await _service.GetById(id);
            var updated = _mapper.Map<ProductUpdateVM>(product);
            return View(updated);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ProductUpdateVM vm)
        {
            await _service.Update(vm);
            return RedirectToAction("Index");
        }
    }
}
