using HabitTracker.Api.Contracts;
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

    [HttpGet("{id:guid}")]
    public IActionResult GetHabit(Guid id)
    {
        return Ok($"Habit {id}");
    }

    [HttpPost]
    public IActionResult CreateHabit(CreateHabitRequest habitRequest)
    {
        return Ok(habitRequest);
    }

}