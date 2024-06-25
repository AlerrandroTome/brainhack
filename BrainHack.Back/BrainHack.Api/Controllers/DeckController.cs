using BrainHack.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BrainHack.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeckController : ControllerBase
    {
        private readonly IDeckService deckService;

        public DeckController(IDeckService deckService)
        {
            this.deckService = deckService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string id)
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
