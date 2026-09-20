namespace GestorOS.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public DateTime DataRegister { get; set; } = DateTime.Now;

        public ICollection<OrdemServico> Ordens { get; set; } = new List<OrdemServico>();
    }
}
