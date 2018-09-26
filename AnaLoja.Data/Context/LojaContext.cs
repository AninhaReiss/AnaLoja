using System.Data.Entity.ModelConfiguration.Conventions;
using AnaLoja.Data.Entities;
using System.Data.Entity;

namespace AnaLoja.Data.Context
{
    public class LojaContext : DbContext
    {
        public LojaContext()
            : base("loja_desenv")
        {

        }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().MapToStoredProcedures();
        }
    }
}