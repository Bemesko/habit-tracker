using HabitTracker.Api.Contracts;

namespace HabitTracker.Api.Models;

public class HabitAction
{
    public required DateTime ActionTime { get; init; }

    public static HabitAction From(CreateHabitActionRequest actionRequest)
    {
        return new HabitAction()
        {
            ActionTime = actionRequest.actionTime
        };
    }
}