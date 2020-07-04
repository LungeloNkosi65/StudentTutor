using AngularLogin4.Interfaces;
using AngularLogin4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularLogin4.DataAccess
{
    public class BookingDataAccessLayer : IBooking
    {
        private myTestDBContext db;

        public BookingDataAccessLayer(myTestDBContext _db)
        {
            db = _db;
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            try
            {
                return db.Booking.ToList().OrderBy(x => x.BookingId);
            }
            catch
            {
                throw;
            }
        }

        //To Add new employee record 
        public int AddBooking(Booking booking)
        {
            try
            {
                db.Booking.Add(booking);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

        //To Update the records of a particluar employee
        public int UpdateBooking(Booking booking)
        {
            try
            {
                db.Entry(booking).State = EntityState.Modified;
                db.SaveChanges();

                return 1;
            }
            catch
            {
                throw;
            }
        }

        //Get the details of a particular employee
        public Booking GetBookingData(int id)
        {
            try
            {
                Booking booking = db.Booking.Find(id);
                return booking;
            }
            catch
            {
                throw;
            }
        }

        //To Delete the record on a particular employee
        public int DeleteBooking(int id)
        {
            try
            {
                Booking booking = db.Booking.Find(id);
                db.Booking.Remove(booking);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }

    }
}
