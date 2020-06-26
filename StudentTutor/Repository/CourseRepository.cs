using Microsoft.EntityFrameworkCore;
using StudentTutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private ApplicationDbContext _context;
        public CourseRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public Course Add(Course course)
        {
            try
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return course;
            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Data Submited");
            }
        }

        public void Delete(int id)
        {
            var dbRecord = Find(id);
            try
            {
                _context.Courses.Remove(dbRecord);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Id");
            }
        }
        
        //bfbgcgncncb
        public Course Find(int? id)
        {
            return _context.Courses.Find(id);
        }

        public IQueryable<Course> Get()
        {
            return _context.Courses; 
        }

        public IQueryable<Course> Get(int? id)
        {
            try
            {
                return _context.Courses.Where(x => x.CourseId == id);
            }
            catch (ArgumentNullException)
            {

                throw;
            }
           
        }

        public void Update(Course course)
        {
            try
            {
                _context.Entry(course).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new ArgumentNullException("faculty");
            }
        }
    }
}
