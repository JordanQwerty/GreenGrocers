using GreenGrocersApp.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GreenGrocersApp.WebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingController : Controller
{
    [HttpGet]
    public ActionResult<Greeting> GetGreeting()
    {
        var message = "Hello, this is the undeployed version of GreenGrocersApp!";
        return Ok(new Greeting { Message = message });
    }
}