using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;




namespace StudentTutor.Models
{
    public class Student
    {
        [Key]
        public string StudentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public virtual Course Course {get; set;}
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
    }
}
