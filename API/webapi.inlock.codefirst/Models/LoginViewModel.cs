using System.ComponentModel.DataAnnotations;

namespace webapi.inlock.codefirst.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email obrigatório!")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Senha obrigatória!")]
        public string Senha { get; set; } = null!;
    }
}
