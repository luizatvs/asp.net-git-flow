using Atividade.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Atividade.Controllers
{
    public class PaisController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista de paises";
            return View();
        }

        public IActionResult Detalhes()
        {
            ViewData["Title"] = "Detalhes de paises";
            return View();
        }
    }
}
