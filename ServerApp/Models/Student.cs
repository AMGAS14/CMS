using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace ServerApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string SName { get; set; }
        public date birthday { get; set; }  
        public List<Grades> getGrades { get; set; }
    }
}