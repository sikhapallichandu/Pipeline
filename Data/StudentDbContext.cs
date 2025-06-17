using HelloWorld.Model;
using HelloWorld.Model.Dto;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HelloWorld.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        // Example DbSet for a Student entity (uncomment and customize as needed)
        public DbSet<StudentInfo> StudentsInfo { get; set; }


        public static IReadOnlyList<StudentInfo> StudentList { get; } = new List<StudentInfo>
    {
        new StudentInfo { Id = 1, StudentName = "Test1", StudentEmail = "Test1@gmail.com", Roll_No = "TEST1" },
        new StudentInfo { Id = 2, StudentName = "Test2", StudentEmail = "Test2@gmail.com", Roll_No = "TEST2" }
    };



    }
}
