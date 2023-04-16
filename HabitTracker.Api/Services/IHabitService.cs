using HabitTracker.Api.Contracts;
using HabitTracker.Api.Models;
namespace HabitTracker.Api.Services;

interface IHabitService
{
    public Habit ListHabits();
    public Habit GetHabit(Guid id);
    public void CreateHabit(Habit habit);
}