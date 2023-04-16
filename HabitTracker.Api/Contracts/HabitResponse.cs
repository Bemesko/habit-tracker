namespace HabitTracker.Api.Contracts;

public record HabitResponse(
    Guid Id,
    string Name,
    string Description
);