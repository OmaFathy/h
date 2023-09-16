namespace ExamProject.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string Password { get; set; }
        public List<DoctorCourse> doc_cours { get; set; }
        public List<DoctorExam> doc_exam { get; set; }

    }
}
