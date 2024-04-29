using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyCoveragesController : ControllerBase
    {
        private readonly IPolicyCoverageService _policyCoverageService;
        public PolicyCoveragesController(IPolicyCoverageService policyCoverageService)
        {
            _policyCoverageService = policyCoverageService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _policyCoverageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(PolicyCoverage policyCoverage)
        {
            var result = _policyCoverageService.Add(policyCoverage);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(PolicyCoverage policyCoverage)
        {
            var result = _policyCoverageService.Update(policyCoverage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PolicyCoverage policyCoverage)
        {
            var result = _policyCoverageService.Delete(policyCoverage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
