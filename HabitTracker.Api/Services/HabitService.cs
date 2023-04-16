using HabitTracker.Api.Models;

namespace HabitTracker.Api.Services;

public class HabitService : IHabitService
{
    private readonly Dictionary<Guid, Habit> _habitRepository = new();

    //TODO: return a created habit response
    public void CreateHabit(Habit habit)
    {
        _habitRepository.Add(habit.Id, habit);
    }

    public Habit GetHabit(Guid id)
    {
        return _habitRepository[id];
    }

    public IEnumerable<Habit> ListHabits()
    {
        return _habitRepository.Values.ToList();
    }
}