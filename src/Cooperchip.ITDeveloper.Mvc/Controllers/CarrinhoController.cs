using Cooperchip.ITDeveloper.Domain.Entities;
using Cooperchip.ITDeveloper.Mvc.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult index()
        {
            var produtos = new List<Produto>();
            for (int i = 1; i < 11; i++)
            {
                var n = i < 10 ? "0" + i : i + ""; // comando if reduzido (se i < 10 irá incluir um zero na frente para ajustar 2 cadas)
                produtos.Add(new Produto
                {
                    Nome = "Prod-" + n,
                    Estoque = 3,
                    Validade = DateTime.Now,
                    Valor = 1.13M * i
                });
            }

            var model = new CarrinhoViewModel
            {
                Produtos = produtos,
                TotalCarrinho = 13.27M,
                Mensagem = "Ah!"

                //TotalCarrinho = produtos.Sum(p => p.Valor),
                //Mensagem = "Obrigado por comprar conosco"
            };
            //return View(model);
            return RedirectToAction("Checkout", model);
        }

        public IActionResult Checkout(CarrinhoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                if (ModelState.ErrorCount > 0)
                {
                    ViewData["semerro"] = "Ops!";
                    ModelState.AddModelError(key: "erro", errorMessage: "O modelo está inválido.");
                }
            }
            else
            {
                ViewData["semerro"] = "Modelo Ok!";
            }

            return View();
        }
    }
}
