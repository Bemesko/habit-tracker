using HabitTracker.Api.Contracts;

namespace HabitTracker.Api.Models;

public class Habit
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public static Habit From(CreateHabitRequest habitRequest)
    {
        return new Habit()
        {
            Id = Guid.NewGuid(),
            Name = habitRequest.Name,
            Description = habitRequest.Description
        };
    }
}