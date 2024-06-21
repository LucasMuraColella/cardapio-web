using CardapioWeb.Context;
using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public class ProdutoRepository : IProdutoRepository // vai herdar caracteristicas do IProdutoRepository
    {
        private readonly AppDBContext _dbContext; // classe responsável por manupular a conexão com o BD

        public ProdutoRepository(AppDBContext dbContext) // criando a utilização para conexão com o banco de dados
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _dbContext.Produtos.ToList(); // busca tudo que há na tabela produtos, ToList converte em uma lista
        }

        public Produto GetById(int id)
        {
            return _dbContext.Produtos.FirstOrDefault(p => p.Id == id); // ele vai buscar dentro da tabela produtos o primeiro registro que o id for igual o atributo
        }

        public IEnumerable<Produto> GetByPreferido()
        {
            return _dbContext.Produtos.Where(p => p.Produto_Preferido).ToList(); // ele vai buscar um produto que esteja marcado como preferido
        }
    }
}

// tudo que tem _ antes da classe ela é global