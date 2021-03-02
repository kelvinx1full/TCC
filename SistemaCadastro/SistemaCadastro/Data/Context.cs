using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaCadastro.Models;

namespace SistemaCadastro.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<SistemaCadastro.Models.FornecedorModel> FornecedorModel { get; set; }

        public DbSet<SistemaCadastro.Models.ProdutoModel> ProdutoModel { get; set; }
    }
}
