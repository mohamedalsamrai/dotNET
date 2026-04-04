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
        public JsonResult CrestEdite(HotelBooking model ){
            if (model.Id==0)
            {
                _contex.Add(model);
            }
            else
            {
               var bookingDb = _contex.Bookings.Find(model.Id);
               if (bookingDb == null)
               {
                   return new JsonResult(NotFound());
               }
               bookingDb = model;
               
            }
            _contex.SaveChanges();
            return new JsonResult(model);
        }  
    }

    
}
