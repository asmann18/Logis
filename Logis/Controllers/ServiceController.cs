using Logis.DAL;
using Logis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Logis.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ProductDbContext _dbContext;

        public ServiceController(ProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Detail(int id)
        {
            Service service=_dbContext.Services.FirstOrDefault(x=>x.Id == id); 
            return View(service);
        }
    }
}
