
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AngularLogin4.Models;
using AngularLogin4.Interfaces;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.VisualBasic;
using System;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentTutor.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBooking objBooking;

        public BookingController(IBooking _objBooking) 
        {
            objBooking = _objBooking;
        }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Booking> Index()
        {
            return objBooking.GetAllBookings();
        }

        [HttpGet]
        [Route("GetBookings")]
        public IEnumerable<Booking> GetBookings()
        {
            return  objBooking.GetAllBookings();
        }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] Booking booking)
        {
            return objBooking.AddBooking(booking);
        }
        
        [HttpGet]
        [Route("Create2")]
        public JsonResult create2(int BookingId,string Title,string Description, DateTime ScheduleEndDate, DateTime ScheduleStartDate, string ThemeColor, string Location,int SeniorStudentId, int StudentId,bool Archived)
        {
            Booking booking = new Booking { BookingId = BookingId, Title=Title, Description=Description, ScheduleEndDate=ScheduleEndDate, ScheduleStartDate=ScheduleStartDate, ThemeColor=ThemeColor, Location=Location, SeniorStudentId=SeniorStudentId, StudentId=StudentId, Archived = Archived };
            var status = false;
            if (booking!=null)
            {
                status = true;
                objBooking.AddBooking(booking);
            }

            return new JsonResult(new { data = status });
        }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody] Booking Booking)
        {
            return objBooking.UpdateBooking(Booking);
        }
        [HttpGet]
        [Route("Details/{id}")]
        public Booking Details(int id)
        {
            return objBooking.GetBookingData(id);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public int Delete(int id)
        {
            return objBooking.DeleteBooking(id);
        }

    }
}
