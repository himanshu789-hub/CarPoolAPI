using FinalCarpool_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalCarpool_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferingController : ControllerBase
    {
        private IOfferRepository _repos;

        public OfferingController(IOfferRepository repos) => _repos = repos;

    }
}