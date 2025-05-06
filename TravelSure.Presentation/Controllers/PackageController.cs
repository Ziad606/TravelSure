using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelSure.Business;

namespace TravelSure.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageService _packageService;
        public PackageController(IPackageService packageService)
        {
            _packageService = packageService;
        }


        [HttpPost]
        public async Task<IActionResult> CreatePackage([FromBody] CreatePackageDto packageDto)
        {
            if(packageDto == null)
            {
                return BadRequest("Invalid Data");

            }
            
            await _packageService.CreatePackage(packageDto);
            return Ok("Pakage Created Successfully");
        }


        [HttpGet]
        public async Task<IActionResult> GetAllPackages()
        {
            var packages = await _packageService.GetAllPackages();
            if(packages == null) return NotFound("No Packages Available");
            return Ok(packages);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPackage(int id)
        {
            var package = await _packageService.GetPackage(id);
            if(package == null)
            {
                return NotFound("There Is No Such Package");
            }
            return Ok(package);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePackage(int id, [FromBody] UpdatePackageDto packageDto)
        {

            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updated = await _packageService.UpdatePackage(id, packageDto);
            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePackage(int id)
        {
            var deleted = await _packageService.DeletePackage(id);
            if (!deleted)
            {
                return NotFound("There Is No Such Package");
            }

            return NoContent();
        }

        [HttpGet("search")]
        public async Task<IActionResult> Search(
            [FromQuery] string? destination,
            [FromQuery] decimal? minPrice,
            [FromQuery] decimal? maxPrice,
            [FromQuery] DateTime? startDate,
            [FromQuery] DateTime? endDate)
        {
            var packages = await _packageService.Search(destination, minPrice, maxPrice, startDate, endDate);
            if (!packages.Any()) { 
                return NotFound("There Is No Packages With These Terms");
            }
            return Ok(packages);
        }

    }
}
