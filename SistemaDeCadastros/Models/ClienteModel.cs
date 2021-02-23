using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCC_VISUAL_1._0.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do usuário é obrigatório", AllowEmptyStrings = false)]
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Endereço { get; set; }

    }
}
