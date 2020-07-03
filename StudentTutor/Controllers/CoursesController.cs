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
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CoursesController (ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        [HttpGet]
        
        public IEnumerable<Course> GetALl()
        {
            return _courseRepository.Get().Include(x=>x.Department);
        }

        [HttpGet("{id}")]
        public IEnumerable<Course>Get(int? id)
        {
            return _courseRepository.Get(id).Include(x=>x.Department);
        }
        [HttpPost]
        public Course Add(Course course)
        {
            return _courseRepository.Add(course);
        }
        [HttpDelete("id")]
        public void Delete(int id)
        {
            _courseRepository.Delete(id);
        }
        [HttpPut]
        public void Update(Course course)
        {
            _courseRepository.Update(course);
        }

    }
}