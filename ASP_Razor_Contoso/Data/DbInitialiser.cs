using ASP_Razor_Contoso.Models;
using System;
using System.Linq;

namespace ASP_Razor_Contoso.Data
{
    public static class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
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

            var courses = new Course[]
            {
                new Course{CourseID=1050,Title="Computing",Credits=3},
                new Course{CourseID=4022,Title="Law",Credits=3},
                new Course{CourseID=4041,Title="Accounting and Finance",Credits=3},
                new Course{CourseID=1045,Title="Medical Science",Credits=4},
                new Course{CourseID=3141,Title="Psychology",Credits=4},
                new Course{CourseID=2021,Title="Aviation",Credits=3},
                new Course{CourseID=2042,Title="3D Animation",Credits=4}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

            var enrollments = new Enrolment[]
            {
                new Enrolment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrolment{StudentID=1,CourseID=4022,Grade=Grades.C},
                new Enrolment{StudentID=1,CourseID=4041,Grade=Grades.B},
                new Enrolment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrolment{StudentID=2,CourseID=3141,Grade=Grades.F},
                new Enrolment{StudentID=2,CourseID=2021,Grade=Grades.F},
                new Enrolment{StudentID=3,CourseID=1050},
                new Enrolment{StudentID=4,CourseID=1050},
                new Enrolment{StudentID=4,CourseID=4022,Grade=Grades.F},
                new Enrolment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrolment{StudentID=6,CourseID=1045},
                new Enrolment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrolments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
