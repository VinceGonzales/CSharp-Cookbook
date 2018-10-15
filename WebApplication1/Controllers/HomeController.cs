using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository repository;

        public HomeController(IRepository repo)
        {
            this.repository = repo;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}