using GestorOS.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorOS.Date
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Cliente> Clientes { get; set; } = null;
        public DbSet<OrdemServico> OrdemServico { get; set; } = null;
        public DbSet<CategoriaServico> CategoriaServico { get; set; } = null;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrdemServico>()
                .HasOne(o => o.Cliente)
                .WithMany(c => c.Ordens)
                .HasForeignKey(o => o.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<OrdemServico>()
                .HasOne(o => o.CategoriaServico)
                .WithMany(c => c.Ordens)
                .HasForeignKey(o => o.CategoriaServiceId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<CategoriaServico>().HasData(
                new CategoriaServico { Id = 1, Name = "Manutenção", Descrition = "Reparos e manutenção geral"},
                new CategoriaServico { Id = 2, Name = "Instalação", Descrition = "Instalação de equipamentos e sistemas"},
                new CategoriaServico { Id = 3, Name = "Consultoria", Descrition = "Consultoria técnica e suporte"}
                );
        }

    }
}
