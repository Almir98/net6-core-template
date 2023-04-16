namespace Template.Domain.Persistance;

public class TemplateDbContext : DbContext
{
    public TemplateDbContext()
    {
    }

    public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options) { }

    public virtual DbSet<TemplateEntity1> TemplateTable1 { get; set; }
    public virtual DbSet<TemplateEntity2> TemplateTable2 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=TemplateDb;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }

    /// <summary>
    /// Use this method for FluentAPI configuration.
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}