using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityAspMvcFirst.Models;

public partial class SubbudbContext : DbContext
{
    public SubbudbContext()
    {
    }

    public SubbudbContext(DbContextOptions<SubbudbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Student> Students { get; set; }
    public virtual DbSet<LoginUser> LoginUsers { get; set; }
    public virtual DbSet<Admins> Admins { get; set; } // renamed from Adminss


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B9969EAEFB6");

            entity.ToTable("Student");

            entity.HasIndex(e => e.Email, "UQ__Student__A9D10534F978CED7").IsUnique();

            // Make StudentId generated on add (identity) so DB issues the value.
            entity.Property(e => e.StudentId).ValueGeneratedOnAdd();
            entity.Property(e => e.DateOfAdmission).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Department).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);
        });

        modelBuilder.Entity<Admins>(e => e.ToTable("Admins"));

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
