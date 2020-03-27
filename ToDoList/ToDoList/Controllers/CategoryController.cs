using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class CategoryController : Controller
    {
        // GET
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        
    }
}