using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentCourse.Data;
using WebApplication1.Model;

namespace StudentCourse.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentCourse.Data.StudentCourseContext _context;

        public IndexModel(StudentCourse.Data.StudentCourseContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
