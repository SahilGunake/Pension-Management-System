using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PensionDetailService.Models;
using PensionDetailService.Provider;

namespace PensionDetailService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PensionerDetailController : ControllerBase
    {
        private readonly ILogger<PensionerDetailController> _logger;
        private readonly IPensionerDetailProvider _provider;

        public PensionerDetailController(ILogger<PensionerDetailController> logger, IPensionerDetailProvider provider)
        {
            _logger = logger;
            _provider = provider;
        }

        [HttpGet]
        public IActionResult PensionerDetailByAadhaar(string aadhaarNumber)
        {
            PensionerDetail response = _provider.PensionerDetailByAadhaar(aadhaarNumber);
            if (response == null)
                return BadRequest(response);

            return Ok(response);
        }
    }
}
