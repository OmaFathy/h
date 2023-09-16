using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ExamProject.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string ExamCode { get; set; }
        public DateTime ExamDate { get; set; }
        public DateTime ExamBegin { get; set; }
        public DateTime ExamEnd { get; set; }
        public decimal TotalMark { get; set; }
        public decimal MinimumMarks { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<Question> Questions { get; set; }
        public List<DoctorExam> DoctorExams { get; set; }
    }
}