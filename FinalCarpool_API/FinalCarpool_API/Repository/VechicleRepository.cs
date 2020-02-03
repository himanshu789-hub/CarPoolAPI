using FinalCarpool_API.Interfaces;
using FinalCarpool_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalCarpool_API.Repository
{
    public class VechicleRepository:IVechicleRepository
    {
        private DbContext _context;

        public VechicleRepository(DbContext context) => _context = context;

        bool IVechicleRepository.DedeuctASeat(Vechicle Car)
        {
            throw new System.NotImplementedException();
        }

        bool IVechicleRepository.ProvideASeat(Vechicle car)
        {
            throw new System.NotImplementedException();
        }
    }
}
