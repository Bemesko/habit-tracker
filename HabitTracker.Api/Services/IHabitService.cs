using HabitTracker.Api.Contracts;
using HabitTracker.Api.Models;
namespace HabitTracker.Api.Services;

public interface IHabitService
{
    public IEnumerable<Habit> ListHabits();
    public Habit GetHabit(Guid id);
    public void CreateHabit(Habit habit);
}