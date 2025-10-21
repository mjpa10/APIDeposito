using APIDeposito.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDeposito.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ItemVenda> ItenVendas { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Venda> Vendas { get; set; }
    
}
