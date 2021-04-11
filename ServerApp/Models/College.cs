namespace ServerApp.Models
{
    public class College
    {
        public string CollegeName { get; set; }
        public List<Courses> curriculum { get; set; }
        public List<Enrollment>  registry { get; set; }
    }
}