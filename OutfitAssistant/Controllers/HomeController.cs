using Microsoft.AspNetCore.Mvc;
using OutfitAssistant.Data;
using OutfitAssistant.Models;
using System.Diagnostics;

namespace OutfitAssistant.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();
            return View(products);
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        
    }
}