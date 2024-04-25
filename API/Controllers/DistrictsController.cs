using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        IDistrictService _districtService;

        public DistrictsController(IDistrictService district)
        {
            _districtService = district;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _districtService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(District district)
        {
            var result = _districtService.Add(district);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(District district)
        {
            var result = _districtService.Update(district);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(District district)
        {
            var result = _districtService.Delete(district);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
