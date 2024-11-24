using Byte2Byte.Services;
using Microsoft.AspNetCore.Mvc;

namespace Byte2Byte.Controllers;
[Route("api/v1/[controller]")]
[ApiController]
public class LoopsController : Controller
{
    private readonly LoopsService _loopsService;
    public LoopsController(LoopsService loopsService)
    {
        _loopsService = loopsService;
    }
    
    [HttpPost]
    public IActionResult ForLoops()
    {
        _loopsService.AddToDatabase();
        return Created();
    }
    
}