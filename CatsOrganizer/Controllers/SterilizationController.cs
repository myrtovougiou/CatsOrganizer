using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/sterilization")]
    public class SterilizationController : Controller
    {
        private readonly ISterilizationService _sterilizationService;

        public SterilizationController(ISterilizationService sterilizationService)
        {
            _sterilizationService = sterilizationService ?? throw new ArgumentNullException(nameof(sterilizationService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _sterilizationService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id, CancellationToken token = default)
        {
            var result = await _sterilizationService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpGet("cat/{id}")]
        public async Task<IActionResult> GetByCatIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _sterilizationService.GetByCatIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] SterilizationRequest request,
            CancellationToken token = default)
        {
            var result = await _sterilizationService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _sterilizationService.DeleteAsync(id, token);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<SterilizationRequest> request,
            CancellationToken token = default)
        {
            var result = await _sterilizationService.UpdateAsync(id, request, token);
            return Ok(result);
        }
    }
}
