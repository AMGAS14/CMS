using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace ServerApp.Models
{
    public class Teacher
    {
        public int teacherId { get; set; }
        public string TName { get; set; }
        public date birthday { get; set; }
        public int salary { get; set; }
        public List<Subject> getSubjects { get; set; }
    }
}