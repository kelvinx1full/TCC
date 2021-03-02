using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Unidade { get; set; }

        public decimal Custo { get; set; }
   
        public decimal Preco { get; set; }

        [ForeignKey("Fornecedor")]
        [Display(Name = "Fornecedor")]
        public int FornecedorFK { get; set; }

        public FornecedorModel Fornecedor { get; set; }


        
    }
}
