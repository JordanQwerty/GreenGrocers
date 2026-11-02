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
        var message = "";
        var isHosted =  !string.IsNullOrWhiteSpace(Environment.GetEnvironmentVariable("WEBSITE_SITE_NAME"));
        if (isHosted == false)
        {
           message = "Hello, this is the undeployed version of GreenGrocersApp!";
        }
        else
        {
           message = "Hello, this is the deployed version of GreenGrocersApp!"; 
        }

        return Ok(new Greeting { Message = message });
    }
}