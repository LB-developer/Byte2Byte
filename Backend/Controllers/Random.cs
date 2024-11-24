using Microsoft.AspNetCore.Mvc;

namespace Setup.Controllers;
[Route("api/v1/[controller]")]
[ApiController]
public class RandomNumberController : Controller
{
    [HttpGet]
    public IActionResult RandomNumber()
    {
        var num = new {num = 5};
        // logic goes in here
        
        return Ok(num);
    }
    
}