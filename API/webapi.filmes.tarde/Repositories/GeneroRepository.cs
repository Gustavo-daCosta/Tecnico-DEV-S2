using System.Data.SqlClient;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;

namespace webapi.filmes.tarde.Repositories
{
    public class GeneroRepository : IGeneroRepository
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
        public void AtualizarIdCorpo(GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public void AtualizarIdUrl(int id, GeneroDomain genero)
        {
            throw new NotImplementedException();
        }

        public GeneroDomain BuscarPorId(int id)
        {
            GeneroDomain? generoBuscado;
            bool objetoEncontrado = false;

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string queryFindById = "SELECT IdGenero, Nome FROM Genero";
                SqlDataReader reader;
                con.Open();


                using (SqlCommand command = new SqlCommand(queryFindById, con))
                {
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        if (Convert.ToInt32(reader[0]) == id)
                        {
                            generoBuscado = new GeneroDomain()
                            {
                                IdGenero = Convert.ToInt32(reader[0]),
                                Nome = reader[1].ToString(),
                            };
                            objetoEncontrado = true;
                            break;
                        } else
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
            }
            return generoBuscado;
        }

        public void Cadastrar(GeneroDomain novoGenero)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Listar todos os objetos do tipo Gênero
        /// </summary>
        /// <returns>Lista de objetos do tipo Gênero</returns>
        public List<GeneroDomain> ListarTodos()
        {
            // Cria uma lista de gêneros onde os gêneros serão armazenados
            List<GeneroDomain> listaGeneros = new List<GeneroDomain>();

            // Declara a SqlConnection passando a string de conexão como parâmetro
            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                // Declara a instrução a ser executada
                string querySelectAll = "SELECT IdGenero, Nome FROM Genero";

                // Abre a conexão com o banco de dados
                con.Open();

                // Declara o SqlDataReader para percorrer(ler) a tabela no banco de dados
                SqlDataReader rdr;

                // Declara o SqlCommand passando a query que será executada e a conexão
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    // Executa a query e armazena os dados no rdr
                    rdr = cmd.ExecuteReader();

                    // Enquanto houver registros para serem lidos no rdr, o laço se repetirá
                    while (rdr.Read())
                    {
                        GeneroDomain genero = new GeneroDomain()
                        {
                            // Atribui a propriedade IdGenero o valor da primeira coluna da tabela
                            IdGenero = Convert.ToInt32(rdr[0]),
                            Nome = rdr["Nome"].ToString(),
                        };
                        listaGeneros.Add(genero);
                    }
                }
            }
            return listaGeneros;
        }
    }
}
