using FinalCarpool_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalCarpool_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VechicleController : ControllerBase
    {
        private IVechicleRepository _repos;
        public VechicleController(IVechicleRepository repos)=>_repos = repos;

    }
}