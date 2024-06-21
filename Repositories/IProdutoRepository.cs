using CardapioWeb.Models;

namespace CardapioWeb.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll(); // Ele vai buscar todos os itens
        IEnumerable<Produto> GetByPreferido(); // Ele vai fazer uma lista de produtos pela definição preferido
        Produto GetById(int id); // Ele vai buscar um registro específico da tabela produtos através do ID
    }
}

// I antes do nome da interface é pra indicar que é interface
// IEnumerable é um método que retorna listas