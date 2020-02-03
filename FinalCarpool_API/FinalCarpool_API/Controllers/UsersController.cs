using FinalCarpool_API.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FinalCarpool_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserRepository _repos;

        public UsersController(IUserRepository repos) => _repos = repos;

    }
}