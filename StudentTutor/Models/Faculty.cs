using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentTutor.Models
{
    public class Faculty
    {
        [Key]
        public int FacultyId { get; set; }
        [DisplayName("Faculty"),Required]
        public string FacultyName { get; set; }
    }
}
