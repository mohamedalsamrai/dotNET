using Microsoft.AspNetCore.Mvc;
using Booking_Api.Models;
namespace Booking_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotalBookingController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _contex = context;
        [HttpPost]
        public IActionResult CrestEdite(HotelBooking model)
        {
            if (model.Id == 0)
            {
                _contex.Add(model);
            }
            else
            {
                var bookingDb = _contex.Bookings.Find(model.Id);
                if (bookingDb == null)
                {
                    return NotFound();
                }
                bookingDb.RoomNumber = model.RoomNumber;
                bookingDb.ClientName = model.ClientName;
            }
            _contex.SaveChanges();
            return Ok(model);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var bookings = _contex.Bookings;
            return Ok(bookings);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var bookingDb = _contex.Bookings.Find(id);
            if (bookingDb == null)
            {
                return NotFound();
            }
            _contex.Bookings.Remove(bookingDb);
            _contex.SaveChanges();
            return Ok();
        }
    }

    
}
