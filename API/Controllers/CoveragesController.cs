using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoveragesController : ControllerBase
    {
       private readonly ICoverageService _coverageService;

        public CoveragesController(ICoverageService coverageService)
        {
            _coverageService = coverageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _coverageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Coverage coverage)
        {
            var result = _coverageService.Add(coverage);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Coverage coverage)
        {
            var result = _coverageService.Update(coverage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Coverage coverage)
        {
            var result = _coverageService.Delete(coverage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetAmountByCoverageType")]
        public IActionResult GetAmountByCoverageType(string type)
        {
            var result = _coverageService.GetAmountByCoverageType(type);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("GetOfferNoByCoverageType")]
        public IActionResult GetOfferNoByCoverageType(string type)
        {
            var result = _coverageService.GetOfferNoByCoverageType(type);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
