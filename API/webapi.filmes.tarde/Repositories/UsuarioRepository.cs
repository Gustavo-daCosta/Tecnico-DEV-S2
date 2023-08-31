using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    /// <summary>
    /// Classe referente a implementação das propriedades e métodos da classe Usuario
    /// </summary>
    public class UsuarioRepository : IUsuarioRepository
    {
        /// <summary>
        /// String de conexão com o banco de dados que recebe os seguintes parâmetros:
        /// Data Source: Nome do servidor do banco
        /// Initial Catalog: Nome do banco de dados
        /// Autenticação:
        ///     - Windows: Integrated Security = True
        ///     - SqlServer: User Id = sa; Pwd = Senha
        /// </summary>
        private string StringConexao = "Data Source = NOTE11-S14; Initial Catalog = Filmes_Tarde; User Id = sa; Pwd = Senai@134";

        /// <summary>
        /// Método para validar login de um Usuário
        /// </summary>
        /// <param name="email">E-mail do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <returns></returns>
        public UsuarioDomain Login(string email, string password)
        {
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryValidate = "SELECT IdUsuario, Nome, Email, Senha FROM Usuario WHERE Email LIKE @Email";
                SqlDataReader reader;

                using (SqlCommand cmd = new SqlCommand(queryValidate, con))
                {
                    cmd.Parameters.AddWithValue("@Email", email.ToLower());

                    con.Open();
                    cmd.ExecuteNonQuery();

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UsuarioDomain usuario = new UsuarioDomain()
                        {
                            IdUsuario = Convert.ToInt32(reader[0]),
                            Nome = reader[1].ToString(),
                            Email = reader[2].ToString(),
                            Senha = reader[3].ToString(),
                        };
                        return usuario;
                    }
                }
            }
            return null;
        }
    }
}
