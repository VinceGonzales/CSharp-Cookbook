using BusinessObjects;
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
            IHero hero = repository.GetHero(1);
            return View(hero);
        }
    }
}