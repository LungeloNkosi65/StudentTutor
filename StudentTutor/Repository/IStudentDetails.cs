using StudentTutor.Models;
using System.Collections.Generic;

namespace StudentTutor.Interfaces
{
    public interface IStudentDetails
    {
        IEnumerable<StudentDetails> GetAllStudentDetails();
        int AddStudentDetails(StudentDetails studentDetails);
        int UpdateStudentDetails(StudentDetails studentDetails);
        StudentDetails GetStudentDetailsData(int id);
        int DeleteStudentDetails(int id);
    }
}
