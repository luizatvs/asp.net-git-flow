using Microsoft.AspNetCore.Mvc;

namespace Atividade.Controllers
{
    public class CidadeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista de cidades";
            return View();
        }

        public IActionResult Detalhes()
        {
            ViewData["Title"] = "Detalhes da cidade";
            return View();
        }
    }
}
