using Microsoft.AspNetCore.Mvc;

namespace Byte2Byte.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class ConditionalsController : Controller
{
    [HttpGet]
   public IActionResult Conditionals()
   {


       
       return Ok();


   }
}

