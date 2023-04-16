using Microsoft.AspNetCore.Mvc;

namespace HabitTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HabitsController : ControllerBase
{
    [HttpGet]
    public IActionResult ListHabits()
    {
        return Ok("All Habits");
    }

    [HttpGet("{id}")]
    public IActionResult GetHabit(Guid id)
    {
        return Ok($"Habit {id}");
    }
}