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
        var actionDictionary = GetHabit(id).Actions;

        var actions = actionDictionary.Select(action => action.Value);

        return actions;
    }

    public HabitAction? GetHabitAction(Guid habitId, Guid actionId)
    {
        try
        {
            var action = GetHabit(habitId).Actions[actionId];

            return action;
        }
        catch (KeyNotFoundException)
        {
            return null;
        }

    }

    public void CreateHabitAction(Guid habitId, HabitAction action)
    {
        throw new NotImplementedException();
    }

    public void DeleteHabitAction(Guid habitId, HabitAction action)
    {
        throw new NotImplementedException();
    }
}