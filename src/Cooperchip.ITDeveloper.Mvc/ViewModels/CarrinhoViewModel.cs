using Cooperchip.ITDeveloper.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.ViewModels
{
    public class CarrinhoViewModel
    {
        public IList<Produto> Produtos { get; set; }

        [Required]
        [Display(Name = "Total do Carrinho")]
        [Range(100,4000, ErrorMessage ="O campo {0} deve estar entre {1} e {2} reais.")]
        public decimal TotalCarrinho { get; set; }

        [Required]
        [StringLength(80, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 5)]
        public string Mensagem { get; set; }
    }
}
