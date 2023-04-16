namespace HabitTracker.Api.Contracts;

public record CreateHabitRequest(
    string Name,
    string Description
);