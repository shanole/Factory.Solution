using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    public FactoryContext(DbContextOptions options) : base(options) { }
    public DbSet<Engineer> Engineers {get; set;}
    public DbSet<Machine> Machines {get; set;}
    public DbSet<EngineerMachine> EngineerMachine {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}