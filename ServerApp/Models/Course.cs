namespace ServerApp.Models
{
    public class Course
    {
        public int courseId { get; set; }
        public string CName { get; set; }
        public List<Subject> curriculum { get; set; }
    }
}