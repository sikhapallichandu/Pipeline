
using HelloWorld.Model.Dto;

namespace HelloWorld.Data
{
    public static class StudentStore
    {
        public static List<StudentInfoDto> StudentList { get; set; } = new List<StudentInfoDto>
        {
            new StudentInfoDto { Id = 1, StudentName = "Test1", StudentEmail = "Test1@gmail.com", Roll_No = "TEST1" },
            new StudentInfoDto { Id = 2, StudentName = "Test2", StudentEmail = "Test2@gmail.com", Roll_No = "TEST2" }
        };
    }
}