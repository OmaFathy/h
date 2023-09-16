using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models

{
    [PrimaryKey("std_id", "course_id")]
    public class StudentCourse
    {
        [ForeignKey("Student")]
        public int std_id { get; set; }
        [ForeignKey("Course")]
        public int course_id { get;set; }
        // Navigation Property
        public Student std { get; set; }
        public Course course { get; set; }
    }
}
