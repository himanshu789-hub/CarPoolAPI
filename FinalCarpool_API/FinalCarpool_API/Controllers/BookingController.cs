using FinalCarpool_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalCarpool_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private IBookingRepository _repos;

        public BookingController(IBookingRepository repos) => _repos = repos;
        
    }
}