using Microsoft.AspNetCore.Mvc;
using ProgiBidCalculator.API.DTO.BaseModel;
using ProgiBidCalculator.Domain.BidCalculatorModels;
using ProgiBidCalculator.Domain.Services.Interfaces;

namespace ProgiBidCalculator.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BidCalculatorController : ControllerBase
    {
        private readonly IBidCalculatorService _calculatorService;
        public BidCalculatorController(IBidCalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Content("Healthcheck OK.");
        }

        [HttpPost]
        [Produces("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BidCalculationResponse))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(BaseResponse))]
        public IActionResult Post(BidCalculationRequest request)
        {
            if (ModelState.IsValid && request.VehicleBasePrice > 0)
            {
                var response = _calculatorService.CalculateFee(request);
                return Ok(response);
            }
            else
            {
                return BadRequest(new BaseResponse { Message = "The request is not properly formed." });
            }
        }
    }
}
