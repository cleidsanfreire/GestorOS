using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace GestorOS.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Descrição é obrigatorio.")]
        [StringLength(200)]
        [Display(Name = "Descrição")]
        public string Descrition { get; set; }
        [StringLength(200)]
        [Display(Name = "Observações")]
        public string? Observation { get; set; }
        [Required]
        [Display(Name = "Data de Abertura")]
        [DataType(DataType.Date)]
        public DateTime DateOpen { get; set; } = DateTime.Now;
        [Display(Name = "Data de Conclusão")]
        [DataType(DataType.Date)]
        public DateTime? DateFinish { get; set; }

        [Display(Name = "Status")]
        public StatusOrdem Status { get; set; }
        [Required(ErrorMessage = "Informe o valor do serviço.")]
        [Display(Name = "Valor (R$)")]
        [Range(0, 999999.99, ErrorMessage = "O Valor deve estar entre 0 e 999.999,99")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Value { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public CategoriaServico? CategoriaServico { get; set; }

        public int? CategoriaServiceId { get; set; }
    }
}
