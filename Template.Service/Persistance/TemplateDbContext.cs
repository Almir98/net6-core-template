namespace Template.Infrastructure.Persistance
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options) { }

        public DbSet<TemplateEntity1> TemplateTable1 { get; set; }
        public DbSet<TemplateEntity2> TemplateTable2 { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
