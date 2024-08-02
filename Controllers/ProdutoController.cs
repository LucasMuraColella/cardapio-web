using CardapioWeb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CardapioWeb.Controllers // Responsável por um tipo de roteamento
{
    public class ProdutoController : Controller // Herança é com os dois pontos :
    {
        private readonly IProdutoRepository _produtoRepository; // Toda vez que a controller for usada prepara o repository

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IActionResult ListarProdutos() { // Método para listar os produtos, todo método de controller tem ActionResult porque resulta em uma ação, sempre terá um retorno 
            var produtos = _produtoRepository.GetAll(); // GetAll para trazer todos os registros que encontrar no banco / vai guardar os métodos buscados
            return View(produtos);
        }
    }
}
