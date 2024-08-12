﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyKeyBox.Modules.BackOffice.Core.Entities;
using MyKeyBox.Shared.Infrastructure.Persistence;

namespace MyKeyBox.Modules.BackOffice.Core.DAL;

internal class BackOfficeDbContext:DbContext,IUnitOfWork
{
    public DbSet<DealerShipOffice>Dealership { get; set; }

    public BackOfficeDbContext(DbContextOptions<BackOfficeDbContext> options) : base(options)
    { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("back_office");
        builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }

    public async Task<bool> SaveChangesAsync()
    {
        var result=await base.SaveChangesAsync();
        return result > 0 ? true : false; 
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