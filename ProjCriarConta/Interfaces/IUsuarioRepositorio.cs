using ProjCriarConta.Models;
using System.Runtime.CompilerServices;

namespace ProjCriarConta.Interfaces
{
    public interface IUsuarioRepositorio
    {
        LoginViewModel? Validar(string email, string senha);
        void CriarConta(LoginViewModel usuario);
    }

}
