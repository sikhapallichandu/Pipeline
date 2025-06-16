using HelloWorld.Model;
using HelloWorld.Model.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    //[Route("api/[controller")]
    [Route("api/StudentApi")]
    [ApiController]
    public class StudentApiController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentInfoDto> GetStudentInfos()
        {
            return new List<StudentInfoDto>
            {
                new StudentInfoDto {Id = 1,StudentName="Test1",StudentEmail="Test1@gmail.com",Roll_No="TEST1"},
                new StudentInfoDto {Id = 2,StudentName="Test2",StudentEmail="Test2@gmail.com",Roll_No="TEST2"}
            };

        }
    }
}
