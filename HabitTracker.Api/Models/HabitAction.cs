using System.ComponentModel.DataAnnotations;
using HabitTracker.Api.Contracts;

namespace HabitTracker.Api.Models;

public class HabitAction
{
    [Key]
    public Guid Id { get; init; }
    [Required]
    public required DateTime ActionTime { get; init; }

    public static HabitAction From(CreateHabitActionRequest actionRequest)
    {
        return new HabitAction()
        {
            Id = Guid.NewGuid(),
            ActionTime = actionRequest.actionTime
        };
    }

    public HabitActionResponse AsResponse()
    {
        HabitActionResponse response = new(
            Id: this.Id,
            ActionTime: this.ActionTime
        );

        return response;
    }
}