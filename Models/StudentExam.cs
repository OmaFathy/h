using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace ExamProject.Models

{
    [PrimaryKey("std_id", "exam_id")]

    public class StudentExam
    {
        [ForeignKey("Student")]

        public int std_id { get; set; }
        [ForeignKey("Exam")]

        public int exam_id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal grade { get; set; }
        // Navigation Property
        public Student std { get; set; }
        public Exam exam { get; set; }
       

    }
}
