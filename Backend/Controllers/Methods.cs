using Microsoft.AspNetCore.Mvc;

namespace Byte2Byte.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class Methods : Controller
{
    public IActionResult StringMethods()
    {
        return Ok();
    }
    
}