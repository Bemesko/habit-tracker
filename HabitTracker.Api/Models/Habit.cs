using System.ComponentModel.DataAnnotations;
using HabitTracker.Api.Contracts;

namespace HabitTracker.Api.Models;

public class Habit
{
    [Key]
    public Guid Id { get; init; }
    [Required]
    public required string Name { get; set; }
    [Required]
    public required string Description { get; set; }
    public List<HabitAction> Actions { get; set; } = new();

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

    public HabitResponse AsResponse()
    {
        HabitResponse habitResponse = new(
            Id: this.Id,
            Name: this.Name,
            Description: this.Description
        );

        return habitResponse;
    }
}