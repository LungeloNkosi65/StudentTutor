using Microsoft.EntityFrameworkCore;
using StudentTutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private ApplicationDbContext _context;
        public DepartmentRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public Department Add(Department department)
        {
            try
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return department;
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
                _context.Departments.Remove(dbRecord);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Id");
            }
        }

        public Department Find(int? id)
        {
            return _context.Departments.Find(id);
        }

        public IQueryable<Department> Get()
        {
            return _context.Departments;
        }

        public IQueryable<Department> Get(int? id)
        {
            try
            {
                return _context.Departments.Where(x => x.DepartmentId == id);

            }
            catch (Exception)
            {

                throw new ArgumentNullException("Invalid Id");
            }
        }

        public void Update(Department  department)
        {
            try
            {
                _context.Entry(department).State = EntityState.Modified;
            }
            catch (Exception)
            {

                throw new ArgumentNullException("faculty");
            }
        }
    }
}
