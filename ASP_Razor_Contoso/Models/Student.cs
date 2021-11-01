using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_Contoso.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [DisplayName("Last Name"), Required, StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("First Name"), Required, StringLength(20)]
        public string FirstName { get; set; }

        [DisplayName("Enrolment Date"), DataType(DataType.Date)]
        public DateTime EnrolmentDate { get; set; }

        // Relationships or navigation properties
        public virtual ICollection<Enrolment> Enrolments { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
