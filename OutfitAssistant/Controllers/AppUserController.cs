using Microsoft.AspNetCore.Mvc;
using OutfitAssistant.Data;
using OutfitAssistant.Models;

namespace OutfitAssistant.Controllers
{
    public class AppUserController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AppUserController(ApplicationDbContext context) {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Personalization(int Id)
        {
            AppUser user = _context.AppUsers.FirstOrDefault(c=>c.ID == Id);
            return View(user);
        }
    }
}
