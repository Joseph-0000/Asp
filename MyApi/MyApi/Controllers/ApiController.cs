using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using Microsoft.Extensions.Logging;
using System.IO; 

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult PostData([FromBody] MyModel data)
        {
            _logger.LogInformation("Received data: Id = {Id}, Name = {Name}", data.Id, data.Name);

            // Process the received data
            // Save the received data to a text file
            string filePath = "received_data.txt"; 
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"Received data: Id = {data.Id}, Name = {data.Name}");
            }

            // Response
            return Ok("Data received successfully");
        }
    }
}
