using System.ComponentModel.DataAnnotations;

namespace GestorOS.Models
{
    public class CategoriaServico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da categoria é obrigatorio.")]
        [StringLength(80)]
        [Display(Name = "Categoria")]
        public string Name { get; set; }
        [StringLength(200)]
        [Display(Name = "Descrição")]
        public string? Descrition { get; set; }

        public ICollection<OrdemServico> Ordens{ get; set; } = new List<OrdemServico>();
    }
}
