using Microsoft.EntityFrameworkCore;

namespace AgendaConsultaAPI.Model
{
    public class _DbContext:DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public virtual DbSet<Consulta> Consultas { get; set; }
    }
}
