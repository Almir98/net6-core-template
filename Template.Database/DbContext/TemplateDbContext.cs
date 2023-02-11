using Microsoft.EntityFrameworkCore;
using Template.Model.Entities;

namespace Template.Database.DbContext
{
    public class TemplateDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options) { }

        public DbSet<TemplateEntity> TemplateTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
