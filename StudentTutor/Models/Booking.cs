using System;
using System.Collections.Generic;

namespace StudentTutor.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ScheduleStartDate { get; set; }
        public DateTime ScheduleEndDate { get; set; }
        public string ThemeColor { get; set; }
        public bool Archived { get; set; }
        public string Location { get; set; }
        public int? SeniorStudentId { get; set; }
        public int? StudentId { get; set; }
    }
}
