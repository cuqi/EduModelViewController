using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EduMVC.Models;

namespace EduMVC.Data
{
    public class EduMVCContext : DbContext
    {
        public EduMVCContext (DbContextOptions<EduMVCContext> options)
            : base(options)
        {
        }

        public DbSet<EduMVC.Models.Course> Course { get; set; }

        public DbSet<EduMVC.Models.Student> Student { get; set; }

        public DbSet<EduMVC.Models.Teacher> Teacher { get; set; }

        public DbSet<EduMVC.Models.Enrollment> Enrollment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Enrollment>()
                .HasOne<Student>(p => p.Student)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.StudentId);
            //.HasPrincipalKey(p => p.Id);

            builder.Entity<Enrollment>()
                .HasOne<Course>(p => p.Course)
                .WithMany(p => p.Students)
                .HasForeignKey(p => p.CourseId);
            //.HasPrincipalKey(p => p.Id);

            builder.Entity<Course>()
                .HasOne<Teacher>(p => p.FirstTeacher)
                .WithMany(p => p.Professor)
                .HasForeignKey(p => p.FirstTeacherId);
            //.HasPrincipalKey(p => p.Id);

            builder.Entity<Course>()
                .HasOne<Teacher>(p => p.SecondTeacher)
                .WithMany(p => p.Assistant)
                .HasForeignKey(p => p.SecondTeacherId);
            //.HasPrincipalKey(p => p.Id);
        }

    }
}
