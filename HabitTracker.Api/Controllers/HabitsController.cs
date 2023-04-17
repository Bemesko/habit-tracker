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

        var response = habits.Select(habit => habit.AsResponse());

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

        return Ok(habit.AsResponse());
    }

    [HttpPost]
    public IActionResult CreateHabit(CreateHabitRequest habitRequest)
    {
        var habit = Habit.From(habitRequest);

        _habitService.CreateHabit(habit);

        return Ok(habit.AsResponse());
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

        return Ok(habit.AsResponse());
    }

    [HttpGet("{habitId:guid}/Actions")]
    public IActionResult GetHabitActions(Guid habitId)
    {
        var actions = _habitService.GetHabit(habitId).Actions;
        var response = actions.Select(action => action.Value.AsResponse());

        return Ok(response);
    }

    [HttpPost("{habitId:guid}/Actions")]
    public IActionResult CreateHabitAction(Guid habitId, CreateHabitActionRequest actionRequest)
    {
        var action = HabitAction.From(actionRequest);

        _habitService.GetHabit(habitId).Actions.Add(action.Id, action);

        return Ok(action.AsResponse());
    }

    [HttpGet("{habitId:guid}/Actions/{actionId:guid}")]
    public IActionResult GetHabitAction(Guid habitId, Guid actionId)
    {
        var action = _habitService.GetHabit(habitId).Actions[actionId];

        return Ok(action.AsResponse());
    }

    [HttpDelete("{habitId:guid}/Actions/{actionId:guid}")]
    public IActionResult DeleteHabitAction(Guid habitId, Guid actionId)
    {
        _habitService.GetHabit(habitId).Actions.Remove(actionId);

        return NoContent();
    }
}