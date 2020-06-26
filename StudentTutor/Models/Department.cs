using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentTutor.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public string DepartmentName { get; set; }
    }
}
