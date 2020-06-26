using StudentTutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Repository
{
    public interface IStudentRepository
    {
        IQueryable<Student> Get();
        IQueryable<Student> Get(string ? id);

        Student Add(Student student);
        void Delete(string id);
        void Update(Student student);
        Student Find(string ? id);
    }
}
