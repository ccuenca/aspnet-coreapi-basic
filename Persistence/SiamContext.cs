using ConceptosService2.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace ConceptosService2.Persistence
{
    public partial class SiamContext : DbContext
    {
        public virtual DbSet<prcConceptos_Model> Conceptos { get; set; }

        public SiamContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<prcConceptos_Model>(entity =>
            {
                entity.HasKey(e => e.conNumero);
            });
            
        }
    }
}
