using FinalCarpool_API.Models;
using FinalCarpool_API.Enums;

namespace FinalCarpool_API.Interfaces
{
   public interface IUserRepository
    {
        User LogIn(string userId, string password);
        User Create( string name, string password, Gender gender);
        Booking AddBookingByUserId(Offering offerer, string userId);
        Booking GetBookingByUserId( string userId);
        Offering GetPreviousCreatedOffer(string userId);
        User GetUserByUserId(string userId);
    }
}
