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
    public IActionResult CreateHabit(CreateHabitRequest habitRequest)
    {
        var habit = Habit.From(habitRequest);

        _habitService.CreateHabit(habit);

        return Ok(habit);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteHabit(Guid id)
    {
        _habitService.DeleteHabit(id);

        return NoContent();
    }

    [HttpPut("{id:guid}")]
    public IActionResult UpdateHabit(Guid id, UpdateHabitRequest habitRequest)
    {
        var habit = Habit.From(id, habitRequest);

        _habitService.UpdateHabit(habit);

        return Ok(habit);
    }

    [HttpGet("{habitId:guid}/Actions")]
    public IActionResult GetHabitActions(Guid habitId)
    {
        var actions = _habitService.GetHabit(habitId).Actions;
        return Ok(actions);
    }

    [HttpPost("{habitId:guid}/Actions")]
    public IActionResult CreateHabitAction(Guid habitId, CreateHabitActionRequest actionRequest)
    {
        var action = HabitAction.From(actionRequest);

        _habitService.GetHabit(habitId).Actions.Add(action);

        return Ok(action);
    }
}