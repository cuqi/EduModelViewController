using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EduMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EduMVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EduMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EduMVCContext>>())) 
            {
                // Look for 
                if (context.Course.Any() || context.Teacher.Any() || context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course { /*Id = 1,*/ Title = "Math 1",          Credits = 7, Semester = 1, Programme = "ALL",               EducationLevel = "8", FirstTeacherId = 1, SecondTeacherId = 2 },
                    new Course { /*Id = 2,*/ Title = "Physics 1",       Credits = 7, Semester = 1, Programme = "All",               EducationLevel = "7", FirstTeacherId = 3, SecondTeacherId = 4 },
                    new Course { /*Id = 3,*/ Title = "Java Dev",        Credits = 5, Semester = 2, Programme = "Computer Science",  EducationLevel = "9", FirstTeacherId = 5, SecondTeacherId = 7 },
                    new Course { /*Id = 4,*/ Title = "C# Course",       Credits = 5, Semester = 3, Programme = "Computer Science",  EducationLevel = "8", FirstTeacherId = 7, SecondTeacherId = 5 },
                    new Course { /*Id = 5,*/ Title = "Electronics 1",   Credits = 7, Semester = 4, Programme = "Hardware",          EducationLevel = "2", FirstTeacherId = 8, SecondTeacherId = 4 },
                    new Course { /*Id = 6,*/ Title = "Ethical Hacking", Credits = 6, Semester = 7, Programme = "All",               EducationLevel = "2", FirstTeacherId = 1, SecondTeacherId = 2 }
                );
                context.SaveChanges();

                context.Teacher.AddRange(
                    new Teacher { /*Id = 1,*/ FirstName = "Aneta",      LastName = "Buchkovska",        AcademicRank = "Professor",     Degree = "PhD", HireDate = DateTime.Parse("2017-1-1"), OfficeNumber = "1001" },
                    new Teacher { /*Id = 2,*/ FirstName = "Sanja",      LastName = "Atanasovska",       AcademicRank = "Alumni",        Degree = "PhD", HireDate = DateTime.Parse("2017-1-2"), OfficeNumber = "1002" },
                    new Teacher { /*Id = 3,*/ FirstName = "Margarita",  LastName = "Ginovska",          AcademicRank = "Professor",     Degree = "PhD", HireDate = DateTime.Parse("2017-1-3"), OfficeNumber = "1003" },
                    new Teacher { /*Id = 4,*/ FirstName = "Lihnida",    LastName = "Stojanovska",       AcademicRank = "Professor",     Degree = "PhD", HireDate = DateTime.Parse("2017-1-4"), OfficeNumber = "1004" },
                    new Teacher { /*Id = 5,*/ FirstName = "Daniel",     LastName = "Denkovski",         AcademicRank = "Professor",     Degree = "PhD", HireDate = DateTime.Parse("2017-1-5"), OfficeNumber = "1005" },
                    new Teacher { /*Id = 6,*/ FirstName = "X",          LastName = "Y",                 AcademicRank = "?",             Degree = "?",   HireDate = DateTime.Parse("2017-1-6"), OfficeNumber = "1006" },
                    new Teacher { /*Id = 7,*/ FirstName = "Bojana",     LastName = "Neznam",            AcademicRank = "Alumni",        Degree = "MS",  HireDate = DateTime.Parse("2017-1-7"), OfficeNumber = "1007" },
                    new Teacher { /*Id = 8,*/ FirstName = "Tomislav",   LastName = "Kartalov",          AcademicRank = "Gospod",        Degree = "BOG", HireDate = DateTime.Parse("2017-1-8"), OfficeNumber = "1008" }
                );
                context.SaveChanges();

                context.Student.AddRange(
                    new Student { /*Id = 1,*/ StudentId = "101", FirstName = "Vladimir",    LastName = "Krstikj",   EnrollmentDate = DateTime.Parse("2017-2-1"), AcquiredCredits = 200, CurrentSemestar = 6, EducationLevel = "Diploma" },
                    new Student { /*Id = 2,*/ StudentId = "102", FirstName = "Stojan",      LastName = "Nebiten",   EnrollmentDate = DateTime.Parse("2017-2-2"), AcquiredCredits = 105, CurrentSemestar = 4, EducationLevel = "Diploma" },
                    new Student { /*Id = 3,*/ StudentId = "103", FirstName = "Blabla",      LastName = "Yeye",      EnrollmentDate = DateTime.Parse("2017-2-3"), AcquiredCredits = 140, CurrentSemestar = 2, EducationLevel = "Diploma" },
                    new Student { /*Id = 1,*/ StudentId = "104", FirstName = "Marko",       LastName = "Chovekot",  EnrollmentDate = DateTime.Parse("2017-2-4"), AcquiredCredits = 50,  CurrentSemestar = 2, EducationLevel = "Diploma" },
                    new Student { /*Id = 1,*/ StudentId = "105", FirstName = "Student5",    LastName = "Okey",      EnrollmentDate = DateTime.Parse("2017-2-5"), AcquiredCredits = 75,  CurrentSemestar = 4, EducationLevel = "Diploma" }
                );
                context.SaveChanges();

                context.Enrollment.AddRange(
                    new Enrollment { /*Id = 1,*/ CourseId = 1, StudentId = 101, Semester = "1", Year = 2017, Grade = 5, SeminalUrl = "www.google.com", ProjectUrl = "www.google.com", ExamPoints = 40, SeminalPoints = 20, ProjectPoints = 10, AdditionalPoints = 5, FinishDate = DateTime.Parse("2017-3-1") },
                    new Enrollment { /*Id = 2,*/ CourseId = 2, StudentId = 102, Semester = "2", Year = 2017, Grade = 4, SeminalUrl = "www.google.com", ProjectUrl = "www.google.com", ExamPoints = 50, SeminalPoints = 10, ProjectPoints = 15, AdditionalPoints = 2, FinishDate = DateTime.Parse("2017-3-2") },
                    new Enrollment { /*Id = 3,*/ CourseId = 3, StudentId = 103, Semester = "3", Year = 2017, Grade = 4, SeminalUrl = "www.google.com", ProjectUrl = "www.google.com", ExamPoints = 30, SeminalPoints = 20, ProjectPoints = 15, AdditionalPoints = 3, FinishDate = DateTime.Parse("2017-3-3") }
                );
                context.SaveChanges();
            }
        }
    }
        
}
