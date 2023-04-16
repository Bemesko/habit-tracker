namespace HabitTracker.Api.Contracts;

public record UpdateHabitRequest(
    string Name,
    string Description
);