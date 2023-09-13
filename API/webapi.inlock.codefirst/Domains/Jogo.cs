using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codefirst.Domains
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome do Jogo é obrigatório!")]
        public string Nome { get; set; } = null!;

        [Column(TypeName = "VARCHAR(250)")]
        [Required(ErrorMessage = "A Descrição do Jogo é obrigatória!")]
        public string Descricao { get; set; } = null!;

        [Column(TypeName = "DATETIME")]
        [Required(ErrorMessage = "A Data de Lançamento do Jogo é obrigatória!")]
        public DateTime DataLancamento { get; set; }

        [Column(TypeName = "Decimal(4, 2)")]
        [Required(ErrorMessage = "O Valor do Jogo é obrigatório!")]
        public decimal Valor { get; set; }

        [ForeignKey("IdEstudio")]
        [Required(ErrorMessage = "O Jogo deve possuir um Estúdio")]
        public virtual Estudio? IdEstudioNavigation { get; set; }
    }
}
