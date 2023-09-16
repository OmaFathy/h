using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    [PrimaryKey("doc_id", "course_id")]

    public class DoctorCourse
    {
        [ForeignKey("Doctor")]

        public int doc_id { get; set; }
     
        [ForeignKey("Course")]

        public int course_id { get; set; }
        public Doctor doc { get; set; }
        public Course course { get; set; }

    }
}
