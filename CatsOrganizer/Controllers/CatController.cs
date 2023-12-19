using CatsOrganizer.Core.Abstractions.Services;
using CatsOrganizer.Core.Requests;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace CatsOrganizer.Controllers
{
    [Route("api/cat")]
    public class CatController : Controller
    {
        private readonly ICatService _catService;

        public CatController(ICatService catService)
        {
            _catService = catService ?? throw new ArgumentNullException(nameof(catService));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync(CancellationToken token = default)
        {
            var result = await _catService.GetAllAsync(token);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            var result = await _catService.GetByIdAsync(id, token);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(
            [FromBody] CatRequest request,
            CancellationToken token = default)
        {
            var result = await _catService.CreateAsync(request, token);
            return Ok(result);
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateAsync(
            [FromRoute] Guid id,
            [FromBody] JsonPatchDocument<CatRequest> patchDocument,
            CancellationToken token = default)
        {
            var result = await _catService.UpdateAsync(id, patchDocument, token);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromRoute] Guid id,
            CancellationToken token = default)
        {
            await _catService.DeleteAsync(id, token);
            return NoContent();
        }
    }
}
