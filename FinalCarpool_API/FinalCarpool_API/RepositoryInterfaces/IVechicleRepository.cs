using FinalCarpool_API.Models;

namespace FinalCarpool_API.Interfaces
{
   public interface IVechicleRepository
    { 
       bool ProvideASeat(Vechicle car);
       bool DedeuctASeat(Vechicle Car);
    }
}
