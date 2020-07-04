using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentTutor.Models;
using StudentTutor.Repository;

namespace StudentTutor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.Get().Include(x=>x.Faculty);
        }

        [HttpGet("{id}")]
        public IEnumerable<Department>Get(int ? id)
        {
            return _departmentRepository.Get(id);
        }

        [HttpPost]
        public Department Add(Department department)
        {
            _departmentRepository.Add(department);
            return department;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _departmentRepository.Delete(id);
        }

        [HttpPut]
        public void Update(Department department)
        {
            _departmentRepository.Update(department);
        }


    }
}