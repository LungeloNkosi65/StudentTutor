using Microsoft.EntityFrameworkCore;
using StudentTutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Repository
{
    public class FacultyRepository : IFAcultyRepository
    {
        private ApplicationDbContext _context;

        public FacultyRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public Faculty Add(Faculty faculty)
        {
            try
            {
                _context.Faculties.Add(faculty);
                _context.SaveChanges();
                return faculty;
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
                _context.Faculties.Remove(dbRecord);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Id");
            }
        }

        public Faculty Find(int? id)
        {
            return _context.Faculties.Find(id);
        }

        public IQueryable<Faculty> Get()
        {
            return _context.Faculties ;
        }

        public IQueryable<Faculty> Get(int? id)
        {
            try
            {
                return _context.Faculties.Where(x => x.FacultyId == id);
            }
            catch (ArgumentNullException)
            {

                throw;
            }
        }

        public void Update(Faculty faculty)
        {
            try
            {
                _context.Entry(faculty).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw new ArgumentNullException("faculty");
            }
        }
    }
}
