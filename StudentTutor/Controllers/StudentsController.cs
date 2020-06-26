using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentTutor.Models;
using StudentTutor.Repository;

namespace StudentTutor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpGet]
        public IEnumerable<Student> GetAll()
        {
            return _studentRepository.Get();
        }

        [HttpGet("{id}")]
        public IEnumerable<Student>Get(string id)
        {
            return _studentRepository.Get(id);
        }

        [HttpPost]
        public Student Add(Student student)
        {
            _studentRepository.Add(student);
            return student;
        }
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _studentRepository.Delete(id);
        }

        [HttpPut]
        public void Update(Student student)
        {
            _studentRepository.Update(student);
        }
    }
}