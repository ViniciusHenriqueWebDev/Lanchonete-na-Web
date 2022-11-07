using LanchesWEB.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LanchesWEB.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;   
        }

        public IActionResult List()
        {
            ViewData["TItulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;
            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();
            var total = totalLanches;

            ViewBag.Total = "Total de Lanches: ";
            ViewBag.TotalLanches = totalLanches; 

            return View(lanches);
        }
    }
}
