using StudentTutor.Models;
using System.Collections.Generic;

namespace StudentTutors.Interfaces
{
    public interface IBooking
    {
        IEnumerable<Booking> GetAllBookings();
        int AddBooking(Booking booking);
        int UpdateBooking(Booking booking);
        Booking GetBookingData(int id);
        int DeleteBooking(int id);
    }
}
