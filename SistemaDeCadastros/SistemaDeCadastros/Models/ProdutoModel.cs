using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TCC_VISUAL_1._0.Models
{
    public class ProdutoModel
    {
        [Key]
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string Unidade { get; set; }

        [Column(TypeName = "decimal 18,2")]
        public decimal Custo { get; set; }

        [Column(TypeName = "decimal 18,2")]
        public decimal Preco { get; set; }

        
    }
}
