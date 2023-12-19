using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/vet")]
    public class VetController : Controller
    {
        private readonly IVetService _vetService;

        public VetController(IVetService vetService)
        {
            _vetService = vetService ?? throw new ArgumentNullException(nameof(vetService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _vetService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            var result = await _vetService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] VetRequest request,
            CancellationToken token = default)
        {
            var result = await _vetService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _vetService.DeleteAsync(id, token);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<VetRequest> request,
            CancellationToken token = default)
        {
            var result = await _vetService.UpdateAsync(id, request, token);
            return Ok(result);
        }
    }
}
