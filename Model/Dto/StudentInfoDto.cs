using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Model.Dto
{
    public class StudentInfoDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "StudentName is required.")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "StudentEmail is required.")]
        public string StudentEmail { get; set; }

        [Required(ErrorMessage = "Roll_No is required.")]
        public string Roll_No { get; set; }
    }
}
