using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro.Models
{
    public class FornecedorModel
    {
        [Key]
        public int FornecedorId { get; set; }

        public string NomeFantasia { get; set; }

        public string Cnpj { get; set; }

        public string Endereco { get; set; }

        public string Email { get; set; }

        public ICollection<ProdutoModel> Produtos { get; set; }
       

    }
}
