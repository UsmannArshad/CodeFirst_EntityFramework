using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CodeFirst_EntityFramework
{
    public partial class CMSContext : DbContext
    {
        public CMSContext()
        {
        }

        public CMSContext(DbContextOptions<CMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AssignedCourse> AssignedCourses { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CMS");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssignedCourse>(entity =>
            {
                entity.HasOne(d => d.AssignedCourseNavigation)
                    .WithMany(p => p.AssignedCourses)
                    .HasPrincipalKey(p => p.CourseId)
                    .HasForeignKey(d => d.AssignedCourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignedCourses_Courses");

                entity.HasOne(d => d.StudentRollnumberNavigation)
                    .WithMany(p => p.AssignedCourses)
                    .HasPrincipalKey(p => p.StudentRollno)
                    .HasForeignKey(d => d.StudentRollnumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AssignedCourses_Students");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasIndex(e => e.CourseId, "UQ__Courses__C92D71A688AB2994")
                    .IsUnique();

                entity.Property(e => e.CourseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.StudentRollno, "UQ__Students__7A342DE1A073BE4E")
                    .IsUnique();

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
