using Microsoft.EntityFrameworkCore;
using StudentTutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public Student Add(Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return student;
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Data Submited");
            }
        }

        public void Delete(string id)
        {
            var dbRecord = Find(id);
            try
            {
                _context.Students.Remove(dbRecord);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Id");
            }
        }

        public Student Find(string ? id)
        {
           return _context.Students.Find(id);
        }

        public IQueryable<Student> Get()
        {
            return _context.Students;
        }

        public IQueryable<Student> Get(string? id)
        {
            try
            {
                return _context.Students.Where(x => x.StudentId == id);
            }
            catch (ArgumentNullException)
            {

                throw;
            }
        }

        public void Update(Student student)
        {
            try
            {
                _context.Entry(student).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new ArgumentNullException("faculty");
            }
        }
    }
}
