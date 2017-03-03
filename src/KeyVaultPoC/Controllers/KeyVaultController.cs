using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace KeyVaultPoC.Controllers
{
    [Route("api/[controller]")]
    public class KeyVaultController : Controller
    {
        private readonly IConfiguration _configuration;

        public KeyVaultController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get()
        {
            return _configuration["ScoobyAPIKey"];
        }
    }
}