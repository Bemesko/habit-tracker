using HabitTracker.Api.Contracts;
using HabitTracker.Api.Models;
using HabitTracker.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace HabitTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HabitsController : ControllerBase
{
    private readonly IHabitService _habitService;

    public HabitsController(IHabitService habitService)
    {
        this._habitService = habitService;
    }

    [HttpGet]
    public IActionResult GetHabit()
    {
        var habits = _habitService.ListHabits();
        return Ok(habits);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetHabit(Guid id)
    {
        var habit = _habitService.GetHabit(id);

        if (habit == null)
        {
            return NotFound();
        }

        HabitResponse response = new(
            Id: habit.Id,
            Name: habit.Name,
            Description: habit.Description
        );

        return Ok(response);
    }

    [HttpPost]
    public IActionResult PostHabit(CreateHabitRequest habitRequest)
    {
        Habit habit = new Habit()
        {
            Id = Guid.NewGuid(),
            Name = habitRequest.Name,
            Description = habitRequest.Description
        };

        _habitService.CreateHabit(habit);

        return Ok(habitRequest);
    }
}