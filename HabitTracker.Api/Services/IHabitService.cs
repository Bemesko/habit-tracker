using HabitTracker.Api.Contracts;
using HabitTracker.Api.Models;
namespace HabitTracker.Api.Services;

public interface IHabitService
{
    public IEnumerable<Habit> ListHabits();
    public Habit GetHabit(Guid id);
    public void CreateHabit(Habit habit);
    public void UpdateHabit(Habit habit);
    public void DeleteHabit(Guid id);
    public IEnumerable<HabitAction> GetHabitActions(Guid id);
    public HabitAction? GetHabitAction(Guid habitId, Guid actionId);
    public void CreateHabitAction(Guid habitId, HabitAction action);
    public void DeleteHabitAction(Guid habitId, Guid actionId);
}