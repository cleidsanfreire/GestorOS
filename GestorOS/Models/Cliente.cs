using System.ComponentModel.DataAnnotations;

namespace GestorOS.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(120)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "Digite um e-mail válido.")]
        [StringLength(150)]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Phone(ErrorMessage = "Digite um telefone válido.")]
        [StringLength(200)]
        [Display(Name = "Telefone")]
        public string? Telefone { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data de Registro")]
        public DateTime DataRegister { get; set; } = DateTime.Now;

        public ICollection<OrdemServico> Ordens { get; set; } = new List<OrdemServico>();
    }
}
