
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentTutor.Models;

namespace StudentTutor.Repository
{
   public interface IFAcultyRepository
    {
        IQueryable<Faculty>Get();
        IQueryable<Faculty> Get(int ? id);

        Faculty Add(Faculty faculty);
        void Delete(int id);
        void Update(Faculty faculty);
        Faculty Find(int? id);




    }
}
