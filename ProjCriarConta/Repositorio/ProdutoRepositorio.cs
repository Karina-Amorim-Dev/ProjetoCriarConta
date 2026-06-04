using MySql.Data.MySqlClient;
using ProjCriarConta.Interfaces;
using ProjCriarConta.Models;

namespace ProjCriarConta.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly string _connectionString;

        public ProdutoRepositorio(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("Conexao");
        }

        //METODO LISTAR TODOS

        public IEnumerable<ProdutoViewModel> ListarTodos()
        {
            var lista = new List<ProdutoViewModel>();

            using var conn = new MySqlConnection(_connectionString);

            conn.Open();

            var cmd = new MySqlCommand("SELECT * FROM tb_produtos", conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new ProdutoViewModel 
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString()!,
                });

            }

            return lista;
        }
    }
}
