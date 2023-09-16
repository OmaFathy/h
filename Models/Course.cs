namespace ExamProject.Models
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public int prep_no { get; set; }
        public List<StudentCourse> std_crs { get; set; }
        public List<DoctorCourse> doc_cours { get; set; }

        public List<Exam> Exams { get; set;}
    }
}
