using Academy.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Context
{
    public class AcademyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var conStr = "Data Source=WIN-EFS54O4O7OC\\SQLEXPRESS;Initial Catalog=AcademyContext;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            builder.UseSqlServer(conStr);
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            model.Entity<Department>()
                .HasIndex(n => n.Name)
                .IsUnique();

            model.Entity<Faculty>()
              .HasIndex(n => n.Name)
              .IsUnique();

            model.Entity<Group>()
           .HasIndex(n => n.Name)
           .IsUnique();

            model.Entity<Subject>()
       .HasIndex(n => n.Name)
       .IsUnique();
        }

        DbSet<Curator>? Curators { get; set; }
        DbSet<Department>? Department { get; set; }
        DbSet<Faculty>? Faculties { get; set; }
        DbSet<Group>? Groups { get; set; }
        DbSet<GroupCurator>? GroupCurators { get; set; }
        DbSet<GroupLecture>? GroupLectures { get; set; }
        DbSet<GroupStudent>? GroupStudents { get; set; }
        DbSet<Lecture>? Lectures { get; set; }
        DbSet<Student>? Students { get; set; }
        DbSet<Subject>? Subjects { get; set; }
        DbSet<Teacher>? Teachers { get; set; }

    }
}
