using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/surgery")]
    public class SurgeryController : Controller
    {
        private readonly ISurgeryService _surgeryService;

        public SurgeryController(ISurgeryService surgeryService)
        {
            _surgeryService = surgeryService ?? throw new ArgumentNullException(nameof(surgeryService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _surgeryService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id, CancellationToken token = default)
        {
            var result = await _surgeryService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpGet("cat/{id}")]
        public async Task<IActionResult> GetByCatIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _surgeryService.GetByCatIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] SurgeryRequest request,
            CancellationToken token = default)
        {
            var result = await _surgeryService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _surgeryService.DeleteAsync(id, token);
            return Ok(null);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<SurgeryRequest> request,
            CancellationToken token = default)
        {
            var result = await _surgeryService.UpdateAsync(id, request, token);
            return Ok(result);
        }
    }
}
