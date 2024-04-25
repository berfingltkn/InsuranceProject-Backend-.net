using Businnes.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalsController : ControllerBase
    {
        IHospitalService _hospitalService;

        public HospitalsController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _hospitalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Hospital hospital)
        {
            var result = _hospitalService.Add(hospital);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Hospital hospital)
        {
            var result = _hospitalService.Update(hospital);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Hospital hospital)
        {
            var result = _hospitalService.Delete(hospital);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("gethospitalwithdetails")]
        public IActionResult GetHospitalWithDetails()
        {
            var result = _hospitalService.GetHospitalWithDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("GetHospitalsByCityAndDistrict")]
        public IActionResult GetHospitalsByCityAndDistrict(string cityName, string districtName)
        {
            var result = _hospitalService.GetHospitalsByCityAndDistrict(cityName, districtName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpGet("GetDistrictByCityID")]
        public IActionResult GetDistrictByCityID(string cityName)
        {
            var result = _hospitalService.GetDistrictByCityID(cityName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
