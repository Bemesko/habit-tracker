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
    public IActionResult ListHabits()
    {
        var habits = _habitService.ListHabits();
        return Ok(habits);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetHabit(Guid id)
    {
        return Ok($"Habit {id}");
    }

    [HttpPost]
    public IActionResult CreateHabit(CreateHabitRequest habitRequest)
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