using Logis.DAL;
using Logis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logis.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductDbContext _dbContext;

        public HomeController(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<Service> services = _dbContext.Services.ToList();
            return View(services);
        }
    }
}
