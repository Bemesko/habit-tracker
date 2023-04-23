using HabitTracker.Api.Models;

namespace HabitTracker.Api.Services;

public class HabitService : IHabitService
{
    private readonly Dictionary<Guid, Habit> _habitRepository = new();

    public Habit GetHabit(Guid id)
    {
        return _habitRepository[id];
    }

    public IEnumerable<Habit> ListHabits()
    {
        return _habitRepository.Values.ToList();
    }

    public void CreateHabit(Habit habit)
    {
        _habitRepository.Add(habit.Id, habit);
    }

    public void UpdateHabit(Habit habit)
    {
        _habitRepository[habit.Id] = habit;
    }

    public void DeleteHabit(Guid id)
    {
        _habitRepository.Remove(id);
    }

    public IEnumerable<HabitAction> GetHabitActions(Guid id)
    {
        var actions = GetHabit(id).Actions;

        return actions;
    }

    public HabitAction? GetHabitAction(Guid habitId, Guid actionId)
    {
        try
        {
            var action = GetHabit(habitId).Actions.FirstOrDefault(o => o.Id == actionId);

            return action;
        }
        catch (KeyNotFoundException)
        {
            return null;
        }

    }

    public void CreateHabitAction(Guid habitId, HabitAction action)
    {
        GetHabit(habitId).Actions.Add(action);
    }

    public void DeleteHabitAction(Guid habitId, Guid actionId)
    {
        var removedAction = GetHabit(habitId).Actions.FirstOrDefault(o => o.Id == actionId);

        GetHabit(habitId).Actions.Remove(removedAction);
    }
}