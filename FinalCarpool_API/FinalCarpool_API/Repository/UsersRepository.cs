using FinalCarpool_API.Enums;
using FinalCarpool_API.Interfaces;
using FinalCarpool_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalCarpool_API.Repository
{
    public class UsersRepository:IUserRepository
    {
        private DbContext _context;

        public UsersRepository(DbContext context) => _context = context;

        Booking IUserRepository.AddBookingByUserId(Offering offerer, string userId)
        {
            throw new System.NotImplementedException();
        }

        User IUserRepository.Create(string name, string password, Gender gender)
        {
            throw new System.NotImplementedException();
        }

        Booking IUserRepository.GetBookingByUserId(string userId)
        {
            throw new System.NotImplementedException();
        }

        Offering IUserRepository.GetPreviousCreatedOffer(string userId)
        {
            throw new System.NotImplementedException();
        }

        User IUserRepository.GetUserByUserId(string userId)
        {
            throw new System.NotImplementedException();
        }

        User IUserRepository.LogIn(string userId, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}
