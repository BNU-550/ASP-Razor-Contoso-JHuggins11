using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_Contoso.Models
{
    public enum Grades
    {
        A, B, C, D, F
    }

    public class Enrolment
    {
        public int EnrolmentID { get; set; }
        public string CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Nullable<Grades> Grade { get; set; }

        // Navigation properties
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
