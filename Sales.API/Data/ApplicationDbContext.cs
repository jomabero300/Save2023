﻿using Microsoft.EntityFrameworkCore;
using Sales.Shared.Entities;

namespace Sales.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>()
            .HasIndex(x => x.Name)
            .IsUnique();
    }
}