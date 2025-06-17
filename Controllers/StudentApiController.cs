using HelloWorld.Data;
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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<StudentInfoDto>> GetStudentInfos()
        {
            return Ok(StudentStore.StudentList);

        }
            
        [HttpGet("{id:int}",Name = "GetStudentInfosById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(StudentInfoDto))]
        public ActionResult<StudentInfoDto> GetStudentInfosById(int id)
        {
            if (id==0)
            {
                return BadRequest();
            }
            var student_data = StudentStore.StudentList.FirstOrDefault(u => u.Id == id);
            if (student_data== null)
            {
                return NotFound();
            }
            return Ok(student_data);

        }

        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<StudentInfoDto> CreateStudentInfo([FromBody] StudentInfoDto studentInfoDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (studentInfoDto == null)
            {
                return BadRequest(studentInfoDto);
            }
            if (studentInfoDto.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            studentInfoDto.Id = StudentStore.StudentList.OrderByDescending(u => u.Id).FirstOrDefault()?.Id + 1 ?? 1;
            StudentStore.StudentList.Add(studentInfoDto);

            return CreatedAtRoute("GetStudentInfosById",new { id = studentInfoDto.Id }, studentInfoDto);
        }

        /* [HttpPost()]
         [ProducesResponseType(StatusCodes.Status200OK)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
         [ProducesResponseType(StatusCodes.Status500InternalServerError)]
         public ActionResult<StudentInfo> CreateStudentInfo([FromBody] StudentInfo studentInfo)
         {
             if (studentInfo == null)
             {
                 return BadRequest(studentInfo);
             }
             if (studentInfo.Id > 0)
             {
                 return StatusCode(StatusCodes.Status500InternalServerError);
             }

             studentInfo.Id = StudentDbContext.StudentList.OrderByDescending(u => u.Id).FirstOrDefault().Id + 1;
             StudentDbContext.StudentList.Append(studentInfo);

             return Ok(studentInfo);
         }*/
    }

}
