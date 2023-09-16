using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class Question
    {
        public int Id { get; set; } 
        public string  Title { get; set; }
        [ForeignKey("exam")]
        public int Exam_id { get; set; }
        public Exam exam { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
