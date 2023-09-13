﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codefirst.Domains
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Usuário deve ter um Email")]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Usuário deve ter uma Senha")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 a 20 caracteres")]
        public string Senha { get; set; } = null!;

        [ForeignKey("TipoUsuario")]
        [Required(ErrorMessage = "O Usuário deve ter um Tipo de Usuário")]
        public virtual TipoUsuario? IdTipoUsuarioNavigation { get; set; }
    }
}