using StudentTutor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTutor.Repository
{
    public interface IDepartmentRepository
    {
        IQueryable<Department> Get();
        IQueryable<Department> Get(int? id);

        Department Add(Department department);
        void Delete(int id);
        void Update(Department department);
        Department Find(int? id);
    }
}
