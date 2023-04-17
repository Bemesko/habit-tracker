using HabitTracker.Api.Contracts;

namespace HabitTracker.Api.Models;

public class Habit
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }

    public static Habit From(CreateHabitRequest habitRequest)
    {
        return new Habit()
        {
            Id = Guid.NewGuid(),
            Name = habitRequest.Name,
            Description = habitRequest.Description
        };
    }

    public static Habit From(Guid id, UpdateHabitRequest habitRequest)
    {
        return new Habit()
        {
            Id = id,
            Name = habitRequest.Name,
            Description = habitRequest.Description
        };

    }
}