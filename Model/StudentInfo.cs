﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Model
{
    public class StudentInfo
    {
        [Key]
        public int Id { get; set; }
        public  string? StudentName { get; set; }
        public string? StudentEmail { get; set; }
        public string? Roll_No { get; set; }

        public DateTime CreatedDate { get; set; }
    }   
}
