using Businnes.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Sockets;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {

            var result = _customerService.Add(customer);


            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {

            var result = _customerService.Update(customer);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("delete")]
        //public IActionResult Delete(int ticketID)
        //{


        //}

        [HttpGet("getcustomerbytcno")]
        public IActionResult GetCustomerByTcno(int tcno)
        {
            var result = _customerService.GetCustomerByTcno(tcno);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
