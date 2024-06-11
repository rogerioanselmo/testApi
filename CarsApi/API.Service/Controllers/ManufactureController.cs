using API.Service.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufactureController : ControllerBase
    {
        private readonly ManufactureService _manufactureService;

        public ManufactureController(ManufactureService manufactureService) => _manufactureService = manufactureService;

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_manufactureService.GetAll());
        }
    }
}
