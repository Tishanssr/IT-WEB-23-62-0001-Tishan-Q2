using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace StudentCourse.Data
{
    public class StudentCourseContext : DbContext
    {
        public StudentCourseContext (DbContextOptions<StudentCourseContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Model.Course> Course { get; set; } = default!;
        public DbSet<WebApplication1.Model.Student> Student { get; set; } = default!;
    }
}
