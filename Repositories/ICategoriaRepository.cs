using CardapioWeb.Models;

namespace CardapioWeb.Repositories

    // ICategoriaRepository.cr criaregras para o arquivo repository
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
    }
}
