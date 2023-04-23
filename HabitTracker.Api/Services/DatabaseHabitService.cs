using HabitTracker.Api.Data;
using HabitTracker.Api.Models;

namespace HabitTracker.Api.Services;

public class DatabaseHabitService : IHabitService
{
    private readonly ApplicationDbContext _dbContext;
    public DatabaseHabitService(ApplicationDbContext dbContext)
    {
        this._dbContext = dbContext;

    }

    public void CreateHabit(Habit habit)
    {
        throw new NotImplementedException();
    }

    public void CreateHabitAction(Guid habitId, HabitAction action)
    {
        throw new NotImplementedException();
    }

    public void DeleteHabit(Guid id)
    {
        throw new NotImplementedException();
    }

    public void DeleteHabitAction(Guid habitId, Guid actionId)
    {
        throw new NotImplementedException();
    }

    public Habit GetHabit(Guid id)
    {
        throw new NotImplementedException();
    }

    public HabitAction? GetHabitAction(Guid habitId, Guid actionId)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<HabitAction> GetHabitActions(Guid id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Habit> ListHabits()
    {
        throw new NotImplementedException();
    }

    public void UpdateHabit(Habit habit)
    {
        throw new NotImplementedException();
    }
}