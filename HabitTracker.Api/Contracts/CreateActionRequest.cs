namespace HabitTracker.Api.Contracts;

public record CreateActionRequest(
    Guid habitID,
    DateTimeOffset actionTime
);