using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Models
{
    public class resourceModel
    {
        myTestDBContext myTestDB = new myTestDBContext();
        public int id { get; set; }
        public int resourceId { get; set; }
        public string title { get; set; }
        public string groupId { get; set; }
        public int roomNumber { get; set; }
        public string GradeName { get; set; }
        public string Description { get; set; }
        public string StaffMemberName { get; set; }
        public string StaffMemberSurname { get; set; }
        public int phonenumber { get; set; }
        public string email { get; set; }
        public DateTime dateOfBirth { get; set; }

        //schedule Model
        public int staffMemberId { get; set; }
        public int classRoomId { get; set; }
        public int scheduleId { get; set; }
        public DateTime scheduleStartDate { get; set; }
        public DateTime? scheduleEndDate { get; set; }
        public string ThemeColor { get; set; }
        public List<resourceModel> GetResources()
        {

            //Tempory holder for resrouces
            List<resourceModel> resList = new List<resourceModel>();
            var resources = myTestDB.StudentDetails.ToList();

            foreach (var stf in resources)
            {
                resourceModel res = new resourceModel();
                res.title = stf.StudentName;
                res.staffMemberId = stf.StudentId;
                res.resourceId = stf.StudentId;
                res.phonenumber = stf.StudentId;
                res.email = stf.StudentName;
                //res.dateOfBirth = stf.dateOfBirth;
                res.groupId = "Teacher";
                res.id = stf.StudentId;
                resList.Add(res);

            }
            return resList;
        }

    }
}
