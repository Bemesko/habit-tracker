using HabitTracker.Api.Contracts;
using HabitTracker.Api.Models;

namespace HabitTracker.Api.Services;

public class HabitService : IHabitService
{
    private readonly Dictionary<Guid, Habit> _habitRepository = new();

    public void CreateHabit(Habit habit)
    {
        throw new NotImplementedException();
    }

    public Habit GetHabit(Guid id)
    {
        throw new NotImplementedException();
    }

    public Habit ListHabits()
    {
        throw new NotImplementedException();
    }
}