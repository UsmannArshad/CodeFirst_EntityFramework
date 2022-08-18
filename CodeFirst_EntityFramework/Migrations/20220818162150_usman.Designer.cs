﻿// <auto-generated />
using CodeFirst_EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirst_EntityFramework.Migrations
{
    [DbContext(typeof(CMSContext))]
    [Migration("20220818162150_usman")]
    partial class usman
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirst_EntityFramework.AssignedCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssignedCourseId")
                        .HasColumnType("int");

                    b.Property<int>("StudentRollnumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignedCourseId");

                    b.HasIndex("StudentRollnumber");

                    b.ToTable("AssignedCourses");
                });

            modelBuilder.Entity("CodeFirst_EntityFramework.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("CreditHours")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CourseId" }, "UQ__Courses__C92D71A688AB2994")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CodeFirst_EntityFramework.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("StudentRollno")
                        .HasColumnType("int");

                    b.Property<int>("marks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "StudentRollno" }, "UQ__Students__7A342DE1A073BE4E")
                        .IsUnique();

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodeFirst_EntityFramework.AssignedCourse", b =>
                {
                    b.HasOne("CodeFirst_EntityFramework.Course", "AssignedCourseNavigation")
                        .WithMany("AssignedCourses")
                        .HasForeignKey("AssignedCourseId")
                        .HasPrincipalKey("CourseId")
                        .IsRequired()
                        .HasConstraintName("FK_AssignedCourses_Courses");

                    b.HasOne("CodeFirst_EntityFramework.Student", "StudentRollnumberNavigation")
                        .WithMany("AssignedCourses")
                        .HasForeignKey("StudentRollnumber")
                        .HasPrincipalKey("StudentRollno")
                        .IsRequired()
                        .HasConstraintName("FK_AssignedCourses_Students");

                    b.Navigation("AssignedCourseNavigation");

                    b.Navigation("StudentRollnumberNavigation");
                });

            modelBuilder.Entity("CodeFirst_EntityFramework.Course", b =>
                {
                    b.Navigation("AssignedCourses");
                });

            modelBuilder.Entity("CodeFirst_EntityFramework.Student", b =>
                {
                    b.Navigation("AssignedCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
