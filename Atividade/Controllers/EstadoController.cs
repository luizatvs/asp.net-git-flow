using Microsoft.AspNetCore.Mvc;

namespace Atividade.Controllers
{
    public class EstadoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista de estados";
            return View();
        }

        public IActionResult Detalhes()
        {
            ViewData["Title"] = "Detalhes de estados";
            return View();
        }
    }
}
