using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cooperchip.ITDeveloper.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            this.ProdutoId = Guid.NewGuid();
        }

        [Key]
        [Display(Name = "Id do Produto" )]
        public Guid ProdutoId { get; set; }

        [Display(Name = "Id do Produto")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [StringLength(80,ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength =2)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        [Range(0,4000, ErrorMessage = "O campo {0} deve estar entre {1} e {2} reais.")]
        public decimal Valor { get; set; }

        public int Estoque { get; set; }

        [Display(Name = "Data de validade" , Description = "Selecione uma data atual ou passada para o cadastro!")]
        [DataType(DataType.Date, ErrorMessage = "Data inválida"), DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Validade { get; set; }
        public bool EmEstoque { get; set; } = true;

    }
}
