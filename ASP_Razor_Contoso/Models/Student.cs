using System;
using System.Collections.Generic;

namespace ASP_Razor_Contoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrolmentDate { get; set; }

        // Relationships or navigation properties
        public virtual ICollection<Enrolment> Enrolments { get; set; }
    }
}
