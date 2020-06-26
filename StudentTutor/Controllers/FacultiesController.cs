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
    public class FacultiesController : ControllerBase
    {
        private readonly IFAcultyRepository _facultyRepository;

        public FacultiesController (IFAcultyRepository facultyRepository)
        {
            _facultyRepository = facultyRepository;
        }

        [HttpGet]
        public IEnumerable<Faculty> GetAll()
        {
           return _facultyRepository.Get();
        }
        [HttpGet("{id}")]
        public IEnumerable<Faculty>Get(int ? id)
        {
            return _facultyRepository.Get(id);
        }
        [HttpPost]
        public Faculty Add(Faculty faculty)
        {
            _facultyRepository.Add(faculty);
            return faculty;
        }
        [HttpDelete]
        public void Delete(int id)
        {
            _facultyRepository.Delete(id);
        }
        [HttpPut]
        public void Update(Faculty faculty)
        {
            _facultyRepository.Update(faculty);
        }
    }
}