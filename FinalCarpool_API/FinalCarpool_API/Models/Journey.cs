using FinalCarpool_API.Enums;
namespace FinalCarpool_API.Models
{
    public class Journey
    {
        public Address Source;
        public Address Destination;
        public float Price;
        public int Distance;//in km
    }
}
