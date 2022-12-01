using Microsoft.AspNetCore.Mvc;

namespace SistemaDeTarefas.Controllers
{
    public class TarefasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
