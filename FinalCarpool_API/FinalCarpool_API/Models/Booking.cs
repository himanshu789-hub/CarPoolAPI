using FinalCarpool_API.Enums;
namespace FinalCarpool_API.Models
{
    public class Booking
    {
        public string Id;
        public string OffererId;
        public Journey JourneyDetails;
        public string UserId;
        public BookingStatus BookingStatus;
        public bool Active;
    }
}
