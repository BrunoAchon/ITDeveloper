using Cooperchip.ITDeveloper.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Route("")] // possibilita chamar a pagina pelo statup routes sem quebar a rota
    [Route("dashboard")] // possibilita chamar a mesma pagina criando uma rota diferente (amigável)
    [Route("api/[controller]")] // serve para chamar por apis
    public class HomeController : Controller
    {
        [Route("")] // possibilita chamar a pagina pelo statup routes sem quebar a rota
        [Route("pagina-inicial")] // possibilita chamar a mesma pagina criando uma rota diferente (amigável)
        public IActionResult Index()
        {
            return View();
        }

        [Route("quem-somos")]
        [Route("sobre-nos")] // sempre nomear a ultima rota com o nome mais expressivo, serve para o a exibição na barra de navegação (SEO)
        [Route("sobre/{id:guid}/{paciente}/{categoria?}")]
        public IActionResult About(Guid id, string paciente, string categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")] // ao chamar pelos menus, o sistema irá exibir sempre a ultima rota
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("icone")]
        public IActionResult Icons()
        {
            return View();
        }

        [Route("erro")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
