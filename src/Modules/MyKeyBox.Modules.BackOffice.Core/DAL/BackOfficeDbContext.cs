using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyKeyBox.Modules.BackOffice.Core.Entities;

namespace MyKeyBox.Modules.BackOffice.Core.DAL;

public class BackOfficeDbContext:DbContext
{
    public DbSet<DealerShipOffice>Dealership { get; set; }

    public BackOfficeDbContext(DbContextOptions<BackOfficeDbContext> options) : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("back_office");
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
    public class Factory:IDesignTimeDbContextFactory<BackOfficeDbContext>
    {
        public BackOfficeDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<BackOfficeDbContext>();
            var connectionString = config["SSMS:connectionString"];
            optionsBuilder.UseSqlServer(connectionString);
            return new BackOfficeDbContext(optionsBuilder.Options);
        }
    }
}