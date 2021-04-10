namespace ServerApp.Models
{
    public class Subject
    {
        public int subjectId { get; set; }
        public string SName { get; set; }
        public Teacher schoolTeacher { get; set; }
        public List<Student> schoolars { get; set; }
    }
}