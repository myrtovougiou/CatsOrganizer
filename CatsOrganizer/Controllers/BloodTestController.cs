using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{    
    [Route("api/bloodTest")]
    public class BloodTestController : Controller
    {
        private readonly IBloodTestService _bloodTestService;

        public BloodTestController(IBloodTestService bloodTestService)
        {
            _bloodTestService = bloodTestService ?? throw new ArgumentNullException(nameof(bloodTestService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _bloodTestService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id, CancellationToken token = default)
        {
            var result = await _bloodTestService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpGet("cat/{id}")]
        public async Task<IActionResult> GetByCatIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _bloodTestService.GetByCatIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] BloodTestRequest request, 
            CancellationToken token = default)
        {
            var result = await _bloodTestService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<BloodTestRequest> request,
            CancellationToken token = default)
        {
            var result = await _bloodTestService.UpdateAsync(id, request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _bloodTestService.DeleteAsync(id, token);
            return NoContent();
        }
    }
}
