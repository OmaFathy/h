using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    [PrimaryKey("doc_id", "exam_id")]

    public class DoctorExam
    {
        [ForeignKey("Doctor")]
        public int doc_id { get; set; }
        [ForeignKey("exam")]
        public int exam_id { get; set; }
        public Doctor doc { get; set; }
        public Exam exam { get; set; }
    }
}
