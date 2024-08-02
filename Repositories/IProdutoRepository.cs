using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll(); // Método que retorna/busca todos os itens da lista
        IEnumerable<Produto> GetByPreferido(); // Cria uma lista de produtos pela definição preferidos
        Produto GetById(int id); // Buscar um registro específio de registro através do ID
    }
}
// define o que o produto deve ter de método