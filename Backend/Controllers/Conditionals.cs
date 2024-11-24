using Byte2Byte.Data;
using Microsoft.AspNetCore.Mvc;

namespace Setup.Controllers;

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

