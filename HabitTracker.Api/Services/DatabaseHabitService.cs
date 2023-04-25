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
        _dbContext.Habits.Add(habit);
        _dbContext.SaveChanges();
    }

    public void CreateHabitAction(Guid habitId, HabitAction action)
    {
        throw new NotImplementedException();
    }

    public void DeleteHabit(Guid id)
    {
        var deletedHabit = _dbContext.Habits.Find(id);

        if (deletedHabit == null)
        {
            return;
        }

        _dbContext.Habits.Remove(deletedHabit);
        _dbContext.SaveChanges();
    }

    public void DeleteHabitAction(Guid habitId, Guid actionId)
    {
        throw new NotImplementedException();
    }

    public Habit GetHabit(Guid id)
    {
        var habit = _dbContext.Habits.Find(id);

        return habit;
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