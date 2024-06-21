using CardapioWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace CardapioWeb.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options) { } // fazer a comunicação com o banco

        public DbSet<Categoria> Categorias { get; set; } // vai fazer a conexão e manter a comunicação com o banco de dados da tabela categoria

        public DbSet<Produto> Produtos { get; set; } // vai fazer a conexão e manter a comunicação com o banco de dados da tabela produto
    }
}

// AppDBContext = ele vai manter a comunicação com o banco