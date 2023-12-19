using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using CatsOrganizer.Core.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/microchip")]
    public class MicrochipController : Controller
    {
        private readonly IMicrochipService _microchipService;

        public MicrochipController(IMicrochipService microchipService)
        {
            _microchipService = microchipService ?? throw new ArgumentNullException(nameof(microchipService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _microchipService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id, CancellationToken token = default)
        {
            var result = await _microchipService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpGet("cat/{id}")]
        public async Task<IActionResult> GetByCatIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _microchipService.GetByCatIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] MicrochipRequest request,
            CancellationToken token = default)
        {
            var result = await _microchipService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _microchipService.DeleteAsync(id, token);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<MicrochipRequest> request,
            CancellationToken token = default)
        {
            var result = await _microchipService.UpdateAsync(id, request, token);
            return Ok(result);
        }
    }
}
