using FinalCarpool_API.Enums;
namespace FinalCarpool_API.Models
{
    public class Offering
    {
        public string UserId;
        public bool Active;
        public Discount Discount;
        public Vechicle Cardetails ;
        public Journey JourneyDetails ;
        public Address CurrentLocation;
        public float TotalEarning;
        public int MaxOfferSeats;
    }
}
