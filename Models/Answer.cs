using System.ComponentModel.DataAnnotations.Schema;

namespace ExamProject.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Answer_text { get; set; }
        
        public bool IsTrueAnswer { get; set; }
        [ForeignKey("Question")]

        public int question_id { get; set; }
        public Question question { get; set; }
    }
}
