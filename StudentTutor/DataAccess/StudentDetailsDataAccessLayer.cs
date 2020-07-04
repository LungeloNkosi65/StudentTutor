using AngularLogin4.Interfaces;
using AngularLogin4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLogin4.DataAccess
{
    public class StudentDetailsDataAccessLayer : IStudentDetails
    {
        private myTestDBContext db;

        public StudentDetailsDataAccessLayer(myTestDBContext _db)
        {
            db = _db;
        }

        public IEnumerable<StudentDetails> GetAllStudentDetails()
        {
            try
            {
                return db.StudentDetails.ToList().OrderBy(x => x.StudentId);
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record 
        public int AddStudentDetails(StudentDetails StudentDetails)
        {
            try
            {
                db.StudentDetails.Add(StudentDetails);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee
        public int UpdateStudentDetails(StudentDetails StudentDetails)
        {
            try
            {
                db.Entry(StudentDetails).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee
        public StudentDetails GetStudentDetailsData(int id)
        {
            try
            {
                StudentDetails StudentDetails = db.StudentDetails.Find(id);
                return StudentDetails;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record on a particular employee
        public int DeleteStudentDetails(int id)
        {
            try
            {
                StudentDetails StudentDetails = db.StudentDetails.Find(id);
                db.StudentDetails.Remove(StudentDetails);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

    }
}
