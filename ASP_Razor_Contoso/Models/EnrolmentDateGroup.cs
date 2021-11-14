using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_Razor_Contoso.Models
{
    public class EnrolmentDateGroup
    {
        [DataType(DataType.Date)]
        public Nullable<DateTime> EnrolmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}