using BrainHack.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrainHack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return await Task.FromResult(Ok());
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return await Task.FromResult(Ok());
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            return await Task.FromResult(Ok());
        }

        [HttpPost]
        public async Task<IActionResult> Login()
        {
            return await Task.FromResult(Ok());
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            return await Task.FromResult(NoContent());
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] string id)
        {
            return await Task.FromResult(NoContent());
        }
    }
}
