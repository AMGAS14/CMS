using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace ServerApp.Models
{
    public class Student
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public dateTime birthday { get; set; }  
        public List<Grades> getGrades { get; set; }
    }
}