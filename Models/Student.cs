using  ExamProject.Context;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ExamProject.Models
{

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
        public int section_no {get; set; }
       
        public int prep_no { get; set; }
        public List<StudentCourse> std_crs { get; set; }
        public List<StudentExam> std_exam { get; set; }

    }

}
