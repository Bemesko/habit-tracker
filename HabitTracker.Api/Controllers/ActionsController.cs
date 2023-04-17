using HabitTracker.Api.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace HabitTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ActionsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAction()
    {

    }

    [HttpPost]
    public IActionResult PostAction(CreateActionRequest actionRequest)
    {

    }
}