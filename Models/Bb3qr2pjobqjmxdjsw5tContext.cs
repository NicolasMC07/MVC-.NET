using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace CrudMVC.Models;

public partial class Bb3qr2pjobqjmxdjsw5tContext : DbContext
{
    public Bb3qr2pjobqjmxdjsw5tContext()
    {
    }

    public Bb3qr2pjobqjmxdjsw5tContext(DbContextOptions<Bb3qr2pjobqjmxdjsw5tContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=bb3qr2pjobqjmxdjsw5t-mysql.services.clever-cloud.com;port=3306;database=bb3qr2pjobqjmxdjsw5t;user=uathrxifcdqhpaif;password=8kEntp13Q4RLWjEGlUlF", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.15-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(20)
                .HasColumnName("documentNumber");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Typedocument)
                .HasMaxLength(20)
                .HasColumnName("typedocument");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
