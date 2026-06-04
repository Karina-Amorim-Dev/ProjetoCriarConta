using ProjCriarConta.Models;

namespace ProjCriarConta.Interfaces
{
    public interface IProdutoRepositorio
    {
        IEnumerable<ProdutoViewModel> ListarTodos();
       // ProdutoViewModel ObterPorId(int id);
       // void CadastrarProduto(ProdutoViewModel produto);
       // void EditarProduto(ProdutoViewModel produto);
       // void ExcluirProduto(int id);
    }
}
