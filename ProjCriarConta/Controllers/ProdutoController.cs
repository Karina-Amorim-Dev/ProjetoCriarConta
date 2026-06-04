using Microsoft.AspNetCore.Mvc;
using ProjCriarConta.Interfaces;
using ProjCriarConta.Repositorio;

namespace ProjCriarConta.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult Index()
        {
            var produtos = _produtoRepositorio.ListarTodos();
            return View(produtos);
        }
    }
}
