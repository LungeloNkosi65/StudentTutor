
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AngularLogin4.Models;
using AngularLogin4.Interfaces;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularLogin4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentDetailsController : ControllerBase
    {
        private readonly IStudentDetails objStudentDetails;

        public StudentDetailsController(IStudentDetails _objStudentDetails) 
        {
            objStudentDetails = _objStudentDetails;
        }

        [HttpGet]
        [Route("Index")]
        public List<StudentDetails> Index()
        {
            List<StudentDetails> resList = new List<StudentDetails>();
            var resources = objStudentDetails.GetAllStudentDetails();
           
            foreach (var stf in resources)
            {
                StudentDetails details = new StudentDetails();
                details.StudentId = stf.StudentId;
                details.StudentName = stf.StudentName;
                resList.Add(details);
            }
            
            return resList;
        }

        [HttpPost]
        [Route("GetAllStudentDetails")]
        public List<resourceModel> GetAllStudentDetails()
        {
                //Tempory holder for resrouces
                List<resourceModel> resList = new List<resourceModel>();
                var resources = objStudentDetails.GetAllStudentDetails();

                foreach (var stf in resources)
                {
                    resourceModel res = new resourceModel();
                    res.title = stf.StudentName;
                    res.staffMemberId = stf.StudentId;
                    res.resourceId = stf.StudentId;
                    res.phonenumber = stf.StudentId;
                    res.email = stf.StudentName;
                    //res.dateOfBirth = stf.dateOfBirth;
                    res.groupId = stf.StudentLevel;
                    res.id = stf.StudentId;
                    resList.Add(res);

                }
                return resList;
        }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] StudentDetails StudentDetails)
        {
            return objStudentDetails.AddStudentDetails(StudentDetails);
        }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody] StudentDetails StudentDetails)
        {
            return objStudentDetails.UpdateStudentDetails(StudentDetails);
        }
        [HttpGet]
        [Route("Details/{id}")]
        public StudentDetails Details(int id)
        {
            return objStudentDetails.GetStudentDetailsData(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public int Delete(int id)
        {
            return objStudentDetails.DeleteStudentDetails(id);
        }

    }
}
