using StudentTutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Repository
{
   public interface ICourseRepository
    {
        IQueryable<Course> Get();
        IQueryable<Course> Get(int? id);

        Course Add(Course course);
        void Delete(int id);
        void Update(Course course);
        Course Find(int? id);
    }
}
