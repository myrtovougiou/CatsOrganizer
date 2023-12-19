using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/vaccination")]
    public class VaccinationController : Controller
    {
        private readonly IVaccinationService _vaccinationService;

        public VaccinationController(IVaccinationService vaccinationService)
        {
            _vaccinationService = vaccinationService ?? throw new ArgumentNullException(nameof(vaccinationService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _vaccinationService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(Guid id, CancellationToken token = default)
        {
            var result = await _vaccinationService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpGet("cat/{id}")]
        public async Task<IActionResult> GetByCatIdAsync(Guid id, CancellationToken token = default)
        {
            var result = await _vaccinationService.GetByCatIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] VaccinationRequest request,
            CancellationToken token = default)
        {
            var result = await _vaccinationService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _vaccinationService.DeleteAsync(id, token);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<VaccinationRequest> request,
            CancellationToken token = default)
        {
            var result = await _vaccinationService.UpdateAsync(id, request, token);
            return Ok(result);
        }
    }
}
