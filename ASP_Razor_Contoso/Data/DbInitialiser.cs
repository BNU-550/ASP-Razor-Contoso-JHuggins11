using ASP_Razor_Contoso.Models;
using System;
using System.Linq;

namespace ASP_Razor_Contoso.Data
{
    public static class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            AddStudents(context);
            AddCourses(context);
            AddEnrolments(context);
            AddModules(context);   
        }

        private static void AddStudents(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Steve",LastName="Taylor",EnrolmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Mark",LastName="Wayne",EnrolmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Sarah",LastName="Lane",EnrolmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Melissa",LastName="Rayn",EnrolmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Rachel",LastName="Bright",EnrolmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Aaron",LastName="Perte",EnrolmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Harry",LastName="Morow",EnrolmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Liz",LastName="Price",EnrolmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        private static void AddCourses(ApplicationDbContext context)
        {
            // Look for any courses.
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            var courses = new Course[]
            {
                new Course{CourseID=1050, CourseCode="BT1CTC1", Title="Computing"},
                new Course{CourseID=4022, CourseCode="BL1LAW1", Title="Law"},
                new Course{CourseID=4041, CourseCode="BF1AFC1", Title="Accounting and Finance"},
                new Course{CourseID=1045, CourseCode="BS1MSC1", Title="Medical Science"},
                new Course{CourseID=3141, CourseCode="BS1PSC1", Title="Psychology"},
                new Course{CourseID=2021, CourseCode="BA1AVI1", Title="Aviation"},
                new Course{CourseID=2042, CourseCode="BG1ANI1", Title="3D Animation"}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }

        private static void AddEnrolments(ApplicationDbContext context)
        {
            // Look for any enrollments.
            if (context.Enrolments.Any())
            {
                return;   // DB has been seeded
            }

            var enrolments = new Enrolment[]
            {
                new Enrolment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrolment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrolment{StudentID=3,CourseID=1050},
                new Enrolment{StudentID=4,CourseID=1050},
                new Enrolment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrolment{StudentID=6,CourseID=1045},
                new Enrolment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrolments.AddRange(enrolments);
            context.SaveChanges();
        }

        private static void AddModules(ApplicationDbContext context)
        {
            // Look for any modules.
            if (context.Modules.Any())
            {
                return;   // DB has been seeded
            }

            var modules = new Module[]
            {
                new Module { ModuleID = "CO550", Title = "Web Applications" },
                new Module { ModuleID = "CO556", Title = "Network Systems" },
                new Module { ModuleID = "CO558", Title = "Database Development" },
                new Module { ModuleID = "CO567", Title = "Object-oriented " +
                "Systems Development" }
            };

            context.Modules.AddRange(modules);
            context.SaveChanges();
        }
    }
}
