using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using CatsOrganizer.Core.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/parasitetreatment")]
    public class ParasiteTreatmentController : Controller
    {
        private readonly IParasiteTreatmentService _parasiteTreatmentService;

        public ParasiteTreatmentController(IParasiteTreatmentService parasiteTreatmentService)
        {
            _parasiteTreatmentService = parasiteTreatmentService ?? throw new ArgumentNullException(nameof(parasiteTreatmentService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _parasiteTreatmentService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id, CancellationToken token = default)
        {
            var result = await _parasiteTreatmentService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpGet("cat/{id}")]
        public async Task<IActionResult> GetByCatIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _parasiteTreatmentService.GetByCatIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] ParasiteTreatmentRequest request,
            CancellationToken token = default)
        {
            var result = await _parasiteTreatmentService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _parasiteTreatmentService.DeleteAsync(id, token);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<ParasiteTreatmentRequest> request,
            CancellationToken token = default)
        {
            var result = await _parasiteTreatmentService.UpdateAsync(id, request, token);
            return Ok(result);
        }
    }
}
