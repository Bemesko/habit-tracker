namespace HabitTracker.Api.Contracts;

public record HabitActionResponse(
    Guid Id,
    DateTime ActionTime
);