using System.ComponentModel.DataAnnotations;

namespace webapi.filmes.tarde.Domains
{   
    /// <summary>
    /// Classe que representa a entidade Usuario
    /// </summary>
    public class UsuarioDomain
    {
        /// <summary>
        /// Propriedade que representa o Id do Usuário
        /// </summary>
        public int IdUsuario { get; set; }
        /// <summary>
        /// Propriedade que representa o Nome do Usuário
        /// </summary>
        [Required(ErrorMessage = "Obrigatoriamente o usuário deve ter um nome")]
        public string Nome { get; set; }
        /// <summary>
        /// Propriedade que representa o E-mail do Usuário
        /// </summary>
        [Required(ErrorMessage = "Obrigatoriamente o usuário deve ter um e-mail")]
        public string Email { get; set; }
        /// <summary>
        /// Propriedade que representa a Senha do Usuário
        /// </summary>
        [Required(ErrorMessage = "Obrigatoriamente o usuário deve ter uma senha")]
        public string Senha { get; set; }
        /// <summary>
        /// Propriedade que representa o Tipo de permissão do usuário, sendo:
        /// False = Usuário Comum
        /// True = Usuário Administrador
        /// </summary>
        public bool Permissao { get; set; }
    }
}
