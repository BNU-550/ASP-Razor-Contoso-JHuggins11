using ASP_Razor_Contoso.Models;
using ASP_Razor_Contoso.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Razor_Contoso.Pages
{
    public class AboutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public AboutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<EnrolmentDateGroup> Students { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<EnrolmentDateGroup> data =
                from student in _context.Students
                group student by student.EnrolmentDate into dateGroup
                select new EnrolmentDateGroup()
                {
                    EnrolmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };

            Students = await data.AsNoTracking().ToListAsync();
        }
    }
}