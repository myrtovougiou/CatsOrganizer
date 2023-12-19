using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/owner")]
    public class OwnerController : Controller
    {
        private readonly IOwnerService _ownerService;

        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService ?? throw new ArgumentNullException(nameof(ownerService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _ownerService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            var result = await _ownerService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] OwnerRequest request,
            CancellationToken token = default)
        {
            var result = await _ownerService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _ownerService.DeleteAsync(id, token);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<OwnerRequest> request,
            CancellationToken token = default)
        {
            var result = await _ownerService.UpdateAsync(id, request, token);
            return Ok(result);
        }
    }
}
