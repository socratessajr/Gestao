using Gestao.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Gestao.Repository.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {   }

        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Insumo> Insumos { get; set; }
        //public DbSet<ItemInsumo> ItensInsumos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos);
            modelBuilder.Entity<ItemPedido>()
                .HasOne(p => p.Pedido)
                .WithMany(c => c.Itens);
            modelBuilder.Entity<ItemPedido>()
                .HasOne(p => p.Produto)
                .WithMany(c => c.ItensPedidos);
            modelBuilder.Entity<Pagamento>()
                .HasOne(p => p.Pedido)
                .WithMany(p => p.Pagamentos);
        }
    }
}