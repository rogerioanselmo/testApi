using API.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarService _carService;
        public CarsController(CarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var cars = _carService.GetAll();
                return Ok(cars);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpGet("sold")]
        public IActionResult GetAllSold()
        {
            try
            {
                var cars = _carService.GetByStatus("sold");
                return Ok(cars);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpGet("byYear/{year}")]
        public IActionResult GetByYear([FromRoute] int year)
        {
            try
            {
                var cars = _carService.GetByYear(year);
                return Ok(cars);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }

        [HttpGet("byAmount/{amount}")]
        public IActionResult GetByAmount([FromRoute] int amount)
        {
            try
            {
                var cars = _carService.GetByAmount(amount);
                return Ok(cars);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
