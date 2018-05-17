using Microsoft.EntityFrameworkCore;
using ConceptosService2.Domain;

namespace ConceptosService2.Persistence
{
    public class ConceptosContext : DbContext
    {
        public ConceptosContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Concepto> Conceptos;
    }
}