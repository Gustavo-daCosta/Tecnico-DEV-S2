using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codefirst.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique = true)] // Especifica que o Email é único
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Usuário deve ter um Email")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "O Usuário deve ter uma Senha")]
        [StringLength(60, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 a 60 caracteres")]
        public string Senha { get; set; } = null!;

        [ForeignKey("TipoUsuario")]
        [Required(ErrorMessage = "O Usuário deve ter um Tipo de Usuário")]
        public virtual TipoUsuario? IdTipoUsuarioNavigation { get; set; }
    }
}
